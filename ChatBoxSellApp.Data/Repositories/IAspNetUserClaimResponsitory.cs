using ChatBoxSellApp.Data.DataDBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBoxSellApp.Data.Repositories
{
    public interface IAspNetUserClaimResponsitory : IRepositoryBase<AspNetUserClaim>
    {

    }
    public class AspNetUserClaimResponsitory : RepositoryBase<AspNetUserClaim>, IAspNetUserClaimResponsitory
    {

        public AspNetUserClaimResponsitory(IUnitOfWork _Db) : base(_Db)
        {

        }

    }
}
