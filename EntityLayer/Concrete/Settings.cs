using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Settings
    {
        [Key]
        public int SettingID { get; set; }
        public string GoogleAdsenseURLHead { get; set; }
        public string AdvertURL { get; set; }
    }
}
