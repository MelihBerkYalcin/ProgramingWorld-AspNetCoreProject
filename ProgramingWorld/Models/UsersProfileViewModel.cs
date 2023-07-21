using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.Models
{
    public class UsersProfileViewModel
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public IFormFile IMGURL { get; set; }
        public string About { get; set; }
        public bool Status { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Youtube { get; set; }
    }
}
