using Azure;
using CoreWebApi.Hubs;
using EntitiesClasses.Entities;
using HelperData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Globalization;
using System.Security.Claims;
using ViewModels.AudioDetailViewModel;
using ViewModels.CommonViewModel;
using ViewModels.MessageChatViewModel;
using static ViewModels.MessageChatViewModel.MessageDto;

namespace BookApplication.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MessagesController : ControllerBase
{
    //private readonly IMessageRepository _repo;
    private readonly IMapper _mapper;
    private readonly IChatServices _chatServices;

    private readonly IConfiguration _configuration;
    private readonly DataContexts _context;
    private readonly IWebHostEnvironment _hostEnvironment; 
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IHubContext<ChatHub> _hubContext;
    protected ServiceResponse<object> _serviceResponse;
    //DataContexts dataContexts, IHubContext<ChatHub> hubContext, IHttpContextAccessor httpContextAccessor
    private int _LoggedIn_UserIDs = 0;
    //private readonly IFilesRepository _filesRepository;
    //private readonly static ConnectionMapping<string> _connections = new ConnectionMapping<string>();
    public MessagesController(IChatServices chatServices, IConfiguration configuration, IMapper mapper,  IWebHostEnvironment hostEnvironment, IHubContext<ChatHub> hubContext)
    { 
        _chatServices = chatServices;
        _hostEnvironment = hostEnvironment;
        _mapper = mapper;
        _configuration = configuration;
        _hubContext = hubContext;
    }
    
    [HttpPost("SendorReceiverMessagesSave")]
    public async Task<IActionResult> SendorReceiverMessagesSave([FromForm] MessageForAddDto model)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var pathToSave = Path.Combine(_hostEnvironment.WebRootPath, "SaveMessageForaudio");
        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(model.AudioUrlData.FileName);

        var fullPath = Path.Combine(pathToSave);
        model.FilePath = "SaveMessageForaudio";
        model.FileName = fileName;

        if (!Directory.Exists(pathToSave))
        {
            Directory.CreateDirectory(pathToSave);
        }

        var filePath = Path.Combine(_hostEnvironment.WebRootPath, "SaveMessageForaudio", fileName);

        // Append the file extension to the filePath
        filePath += Path.GetExtension(model.AudioUrlData.FileName);

        using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            await model.AudioUrlData.CopyToAsync(stream);
        }

        var entity = new Message()
        {
            ReceiverId = model.ReceiverId,
            SenderId = model.SenderId,
            Content = model.Content,
            ImageData = Convert.FromBase64String(model.ImageDataAsString),
            FileNameAudio = model.FileName,
            FilePathAudio = model.FilePath
        };

        await _chatServices.SendorReceiverMessagesSave(entity);

        // this code is signral r . see it after 
       var list = await _chatServices.GetUserMessages(model.SenderId, model.ReceiverId);
        //var jsonList = JsonConvert.SerializeObject(list); 
        //var lastMessage = JsonConvert.DeserializeObject(jsonList);
       await _hubContext.Clients.All.SendAsync("MessageNotificationAlert", list);

        return Ok(new { Success = true, Message = CustomMessage.Added });
      
    }

    private byte[]ConvetintoByte(string FilePathAudio, string FolderName)
    {

        string filePath = Path.Combine(_hostEnvironment.WebRootPath, FilePathAudio, FolderName);
        byte[] audioData;

        using (var stream = new FileStream(filePath, FileMode.Open))
        {
            using (var memoryStream = new MemoryStream())
            {
                  stream.CopyTo(memoryStream);
                audioData = memoryStream.ToArray();
            }
        }
        return audioData;
    }
 

    [HttpPost("GetUserMessages")]
    public async Task<IActionResult> GetUserMessages(GetMessagesDto model)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        //var enity = _mapper.Map<Message>(model);
  var list =       await _chatServices.GetUserMessages(model.SenderId,model.ReceiverId);

        //var messagesWithImageData = list.Select(message => new GetMessagesListDto()
        //{
        //     Id=     message.Id,
        //    Content=  message.Content,
        //    Timestamp =message.Timestamp,
        //    SenderId  =   message.SenderId,
        //    ReceiverId=   message.ReceiverId,
        //    ImageDataAsString = Convert.ToBase64String(message.ImageData),
        //    AudioFullPath = _configuration.GetSection("AppSettings:SiteUrl").Value + message.FilePathAudio + '/' + message.FileNameAudio,

        //}).ToList();

        var messagesWithImageData = list.Select( message => new GetMessagesListDto()
        {
            Id = message.Id,
            Content = message.Content,
            Timestamp = message.Timestamp,
            SenderId = message.SenderId,
            ReceiverId = message.ReceiverId,
            AudioData = ConvetintoByte(message.FilePathAudio, message.FileNameAudio),
            ImageDataAsString = Convert.ToBase64String(message.ImageData),
            AudioFullPath = _configuration.GetSection("AppSettings:SiteUrl").Value + message.FilePathAudio + '/' + message.FileNameAudio,

        }).ToList();

        if (messagesWithImageData != null)
        {
            return Ok(new { Data = messagesWithImageData, Success = true, });
        }
        else
        {
            return Ok(new { Data = string.Empty, Success = false, });
        } 

    }




    //[HttpPost("GetUserMessages")]
    //public async Task<IActionResult> GetUserMessages(GetMessagesDto model)
    //{
    //    if (!ModelState.IsValid) return BadRequest(ModelState);
    //    //var enity = _mapper.Map<Message>(model);
    //    var list = await _chatServices.GetUserMessages(model.SenderId, model.ReceiverId);
    //    if (list != null)
    //    {
    //        return Ok(new { Data = list, Success = true, });
    //    }
    //    else
    //    {
    //        return Ok(new { Data = string.Empty, Success = false, });
    //    }

    //}

}
