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
    private int _LoggedIn_UserIDs = 0;
    //private readonly IFilesRepository _filesRepository;
    //private readonly static ConnectionMapping<string> _connections = new ConnectionMapping<string>();
    public MessagesController(IConfiguration config, IChatServices 
        chatServices, IMapper mapper, DataContexts dataContexts,IHubContext<ChatHub> hubContext, IHttpContextAccessor httpContextAccessor)
    {
        _config = config;
        _context = dataContexts;
      _chatServices = chatServices;
       _hubContext = hubContext;
        _serviceResponse = new ServiceResponse<object>();

    }

 
}
