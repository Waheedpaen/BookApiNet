using EntitiesClasses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services;

public interface IChatServices
{
  
    Task<Message> SendorReceiverMessagesSave(Message model);
    Task<List<Message>> GetUserMessages(int SenderId, int ReceiverId);
}
