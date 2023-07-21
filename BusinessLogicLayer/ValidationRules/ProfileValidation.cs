using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ValidationRules
{
    public class ProfileValidation : AbstractValidator<AppUser>
    {
        public ProfileValidation()
        {
            RuleFor(I => I.NameSurname).NotEmpty().WithMessage("İsim Soyisim boş geçilemez.");
            RuleFor(I => I.NameSurname).Length(3).WithMessage("İsim Soyisim Minimum 3 karakterden oluşması gerekiyor.");

            RuleFor(I => I.UserName).NotEmpty().WithMessage("Kullanıcı Adı boş geçilemez.");
            RuleFor(I => I.UserName).Length(3,40).WithMessage("Kullanıcı Adı Minimum-3 Maximum-40 karakterden oluşması gerekiyor.");

            RuleFor(I => I.Email).NotEmpty().WithMessage("EMail Adresi boş geçilemez.");
            RuleFor(I => I.Email).EmailAddress().WithMessage("EMail Adresi Tipi | @gmail.com | @hotmail.com | @programdunyasi.com | olması gerekiyor.");

            RuleFor(I => I.About).NotEmpty().WithMessage("Açıklama boş geçilemez.");
            RuleFor(I => I.About).Length(3, 200).WithMessage("Açıklama Minimum-3 Maximum-200 karakterden oluşması gerekiyor.");
        }
    }
}
