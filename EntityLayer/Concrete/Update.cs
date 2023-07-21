using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Update
    {
        [Key]
        public int UpdateID { get; set; }
        public string UpdateName { get; set; }
        public string UpdateDetails { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}
