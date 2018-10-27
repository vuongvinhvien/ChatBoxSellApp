using ChatBoxSellApp.Data.DataDBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBoxSellApp.Data.Repositories
{
    public interface IStoreProduce
    {
        IEnumerable<T> Run<T>(StoreProduceModel Store);
    }
    public class StoreProduce : IStoreProduce
    {
        private readonly IUnitOfWork _Db;

        public StoreProduce(IUnitOfWork Db)
        {
            _Db = Db;
        }
        public IEnumerable<T> Run<T>(StoreProduceModel Store)
        {
            IEnumerable<T> result = _Db.Runstore<T>(Store);

            return result;
        }
    }
}
