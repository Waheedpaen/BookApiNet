using EntitiesClasses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ViewModels.MessageChatViewModel.MessageDto;

namespace DataAccessLayer.IRepositories
{
    public  interface IChatRepository : IRepository<Message, int>
    {
        Task<List<Message>> GetUserMessages(int senderId,int ReceiverId);
    }
}
