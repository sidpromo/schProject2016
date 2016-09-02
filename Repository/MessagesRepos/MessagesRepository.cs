using Repository.GenericRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities;

namespace Repository.UserRepos
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

    }
}
