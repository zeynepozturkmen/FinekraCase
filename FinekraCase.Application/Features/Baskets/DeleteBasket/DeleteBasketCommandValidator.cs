using FluentValidation;

namespace FinekraCase.Application.Features.Baskets.DeleteBasket
{
    public class DeleteBasketCommandValidator : AbstractValidator<DeleteBasketCommand>
    {
        public DeleteBasketCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id boş olamaz!"); ;
        }
    }
}
