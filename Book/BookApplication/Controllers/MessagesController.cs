using Azure;
using CoreWebApi.Hubs;
using EntitiesClasses.Entities;
using HelperData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Globalization;
using System.Security.Claims;
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
    private readonly DataContexts _context;
    private readonly IConfiguration _config;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IHubContext<ChatHub> _hubContext;
    protected ServiceResponse<object> _serviceResponse;
    //DataContexts dataContexts, IHubContext<ChatHub> hubContext, IHttpContextAccessor httpContextAccessor
    private int _LoggedIn_UserIDs = 0;
    //private readonly IFilesRepository _filesRepository;
    //private readonly static ConnectionMapping<string> _connections = new ConnectionMapping<string>();
    public MessagesController(IChatServices 
        chatServices, IMapper mapper)
    { 
      _chatServices = chatServices;
        _mapper = mapper;

    }
    
    [HttpPost("SendorReceiverMessagesSave")]
    public async Task<IActionResult> SendorReceiverMessagesSave(MessageForAddDto model)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var enity = _mapper.Map<Message>(model);
        await _chatServices.SendorReceiverMessagesSave(enity);
        return Ok(new { Success = true, Message = CustomMessage.Added });
      
    }

    [HttpPost("GetUserMessages")]
    public async Task<IActionResult> GetUserMessages(GetMessagesDto model)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        //var enity = _mapper.Map<Message>(model);
  var list =       await _chatServices.GetUserMessages(model.SenderId,model.ReceiverId);
        if (list != null)
        {
            return Ok(new { Data = list, Success = true, });
        }
        else
        {
            return Ok(new { Data = string.Empty, Success = false, });
        } 

    }
}
