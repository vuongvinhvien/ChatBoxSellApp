using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBoxSellApp.Data.DataDBContext
{
    [Table("Setting")]
    public partial class Setting
    {
        [Key]
        public string ID_Setting { get; set; }

        [StringLength(128)]
        public string ID_Customer { get; set; }

        [StringLength(256)]
        public string EmailSendScript { get; set; }

        public bool? Sound { get; set; }

        public bool? ShareFileAgent { get; set; }

        public bool? ShareFileVisitor { get; set; }
    }
}
