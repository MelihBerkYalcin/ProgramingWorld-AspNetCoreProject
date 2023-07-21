using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingWorld.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "Lütfen Adınızı Soyadınızı Giriniz.")]
        public string NameSurname { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz.")]
        public string UserName { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Lütfen EMail Adresinizi Giriniz.")]
        public string EMail { get; set; }

        [Display(Name = "Şifre")]
        [Compare("Password", ErrorMessage = "Lütfen Şifrenizi Giriniz.")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar")]
        [Compare("Password", ErrorMessage = "Lütfen Adınızı Soyadınızı Giriniz.")]
        public string ConfirmPassword { get; set; }
        public string About { get; set; }
        public string PhoneNumber { get; set; }
        public bool Status { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Youtube { get; set; }
        public AppRole AppRole { get; set; }
    }
}
