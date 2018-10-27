using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBoxSellApp.Data.DataDBContext
{
    public class StoreProduceModel
    {
        public IEnumerable<SqlParameter> Params;
        public string NameProduce;
        public object ReturnResulte;
    }
}
