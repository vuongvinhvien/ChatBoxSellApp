using ChatBoxSellApp.Data.DataDBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBoxSellApp.Data.Repositories
{
    public interface IAccountResponsitory : IRepositoryBase<AspNetUser>
    {

    }
    public class AccountResponsitory : RepositoryBase<AspNetUser>, IAccountResponsitory
    {
        public AccountResponsitory(IUnitOfWork _Db) : base(_Db)
        {

        }
    }
}
