using Entities;
using System.Collections.Generic;

namespace Repository
{
    public interface IMessagesRepository : IRepository<Messages>
    {
        int GetMessageId(Messages message);
        IEnumerable<Messages> GetReceivedMessages(int userId);
        IEnumerable<Messages> GetSentMessages(int userId);
    }
}
