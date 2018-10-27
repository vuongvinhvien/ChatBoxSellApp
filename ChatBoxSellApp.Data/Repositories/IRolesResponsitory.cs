using ChatBoxSellApp.Data.DataDBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBoxSellApp.Data.Repositories
{
    public interface IRolesResponsitory : IRepositoryBase<AspNetUserRole>
    {
    }

    public class RolesResponsitory : RepositoryBase<AspNetUserRole>
    {
        public RolesResponsitory(IUnitOfWork _Db) : base(_Db)
        {

        }
    }
}
