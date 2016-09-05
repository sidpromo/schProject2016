using System.Linq;
using System.Data.Entity;
using Entities;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class MessagesRepository : Repository<Messages>, IMessagesRepository
    {
        public MessagesRepository(DbContext context) : base(context)
        {
        }

        /// <summary>
        /// A megadott message id-ját adja vissza.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public int GetMessageId(Messages message)
        {
            return GetAll().Where(x => x.Id == message.Id).FirstOrDefault().Id;
        }

        /// <summary>
        /// A megadott id-jú felhasználó fogadott üzeneteit adja vissza.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IEnumerable<Messages> GetReceivedMessages(int userId)
        {
            return GetAll().Where(x => x.ToUserId == userId);
        }

        /// <summary>
        /// A megadott id-jú felhasználó küldött üzeneteit adja vissza.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IEnumerable<Messages> GetSentMessages(int userId)
        {
            return GetAll().Where(x => x.FromUserId == userId);
        }
    }
}
