using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        [Required(ErrorMessage = "Boş Geçilemez.")]
        public string NameSurname { get; set; }
        public string IMGURL { get; set; }
        public string About { get; set; }
        public bool Status { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Youtube { get; set; }
    }
}
