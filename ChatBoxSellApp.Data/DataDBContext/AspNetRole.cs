using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBoxSellApp.Data.DataDBContext
{
    public partial class AspNetRole
    {
        public string Id { set; get; }

        [Required]
        [StringLength(256)]
        public string Name { set; get; }
    }
}
