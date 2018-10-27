using ChatBoxSellApp.Data.DataDBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBoxSellApp.Data.Repositories
{
    public interface ISettingResponsitory : IRepositoryBase<Setting>
    {



    }
    public class SettingResponsitory : RepositoryBase<Setting>, ISettingResponsitory
    {

        public SettingResponsitory(IUnitOfWork _Db) : base(_Db)
        {

        }

    }
}
