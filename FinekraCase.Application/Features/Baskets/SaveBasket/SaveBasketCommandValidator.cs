using FluentValidation;

namespace FinekraCase.Application.Features.Baskets.SaveBasket
{
    public class SaveBasketCommandValidator : AbstractValidator<SaveBasketCommand>
    {
        public SaveBasketCommandValidator()
        {
            RuleFor(x => x.Count).NotNull().NotNull().GreaterThanOrEqualTo(1).WithMessage("Count alanı 0'dan küçük olamaz"); 
            RuleFor(x => x.Price).NotEmpty().NotNull();
            RuleFor(x => x.UserDetailId).NotEmpty().WithMessage("UserDetailId boş olamaz!"); ;
            RuleFor(x => x.PerfumeId).NotNull().NotEmpty();
        }
    }
}
