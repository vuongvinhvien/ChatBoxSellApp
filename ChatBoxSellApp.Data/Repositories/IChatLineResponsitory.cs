using ChatBoxSellApp.Data.DataDBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBoxSellApp.Data.Repositories
{
    public interface IChatLineResponsitory : IRepositoryBase<ChatLine>
    {

    }
    public class ChatLineResponsitory : RepositoryBase<ChatLine>, IChatLineResponsitory
    {

        public ChatLineResponsitory(IUnitOfWork _Db) : base(_Db)
        {

        }

    }
}
