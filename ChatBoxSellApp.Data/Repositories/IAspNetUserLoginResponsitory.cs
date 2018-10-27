using ChatBoxSellApp.Data.DataDBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBoxSellApp.Data.Repositories
{
    public interface IAspNetUserLoginResponsitory : IRepositoryBase<AspNetUserLogin>
    {

    }
    public class AspNetUserLoginResponsitory : RepositoryBase<AspNetUserLogin>, IAspNetUserLoginResponsitory
    {

        public AspNetUserLoginResponsitory(IUnitOfWork _Db) : base(_Db)
        {

        }

    }
}
