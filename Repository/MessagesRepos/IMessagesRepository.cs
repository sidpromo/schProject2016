using Entities;

namespace Repository
{
    public interface IMessagesRepository : IRepository<Messages>
    {
        int GetMessageId(Messages message);
    }
}
