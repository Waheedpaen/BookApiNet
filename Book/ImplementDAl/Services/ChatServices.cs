using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDAl.Services;

public class ChatServices : IChatServices
{
    private readonly IUnitofWork _unitOfWork;

    public ChatServices(IUnitofWork unitOfWork)
    {

        _unitOfWork = unitOfWork;
    }

    public async Task<List<Message>> GetUserMessages(int SenderId, int ReceiverId)
    {
         return await _unitOfWork.IChatRepository.GetUserMessages(SenderId, ReceiverId); 
    }

    public async Task<Message> SendorReceiverMessagesSave(Message model)
    {
        await _unitOfWork.IChatRepository.AddAsync(model);
        await _unitOfWork.CommitAsync();
        return model;
    }

 
}
