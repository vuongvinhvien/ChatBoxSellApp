using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBoxSellApp.Data.DataDBContext
{
    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        public string ID_Customer { get; set; }

        public DateTime? DateCreate { get; set; }

        [StringLength(50)]
        public string MaSoThue { get; set; }
    }
}
