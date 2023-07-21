using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ValidationRules
{
    public class BlogValidation : AbstractValidator<Blog>
    {
        public BlogValidation()
        {
            RuleFor(I => I.BlogTitle).NotEmpty().WithMessage("Blog ismi boş geçilemez.");
            RuleFor(I => I.BlogContent).NotEmpty().WithMessage("Blog açıklaması boş geçilemez.");
        }
    }
}
