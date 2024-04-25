using HelperData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDAl.Reporsitory
{
    public class ChatRepository : Reporsitory<Message, int>, IChatRepository
    {
        public ChatRepository(DataContexts context) : base(context)
        {

        }
        public DataContexts DataContexts => Context as DataContexts;

        public async Task<List<Message>> GetUserMessages(int senderId, int ReceiverId)
        {
            var list = await Context.Set<Message>().Where(data => data.SenderId.Equals(senderId) && data.ReceiverId.Equals(ReceiverId) ||    (data.SenderId == ReceiverId && data.ReceiverId == senderId)).ToListAsync();
            return list;
        }
    }
}
