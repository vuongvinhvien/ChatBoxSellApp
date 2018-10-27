using ChatBoxSellApp.Data.DataDBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBoxSellApp.Data.Repositories
{
    public interface IVisitorResponsitory : IRepositoryBase<Visitor>
    {

    }
    public class VisitorResponsitory : RepositoryBase<Visitor>, IVisitorResponsitory
    {

        public VisitorResponsitory(IUnitOfWork _Db) : base(_Db)
        {

        }

    }
}
