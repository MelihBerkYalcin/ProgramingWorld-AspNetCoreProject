using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogContentSetupDetails { get; set; }
        public string BlogProgramingRequirement { get; set; }
        public string BlogIMGURL { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int SubCategoryID { get; set; }
        public SubCategory SubCategory { get; set; }
        public List<Comment> Comment { get; set; }
        public string BlogKeyword { get; set; }
        public string MediaFire { get; set; }
        public string Turbobit { get; set; }
        public string GoogleDriver { get; set; }
        public string Mega { get; set; }
        public string BitLY { get; set; }
        public string Torrent { get; set; }
    }
}
