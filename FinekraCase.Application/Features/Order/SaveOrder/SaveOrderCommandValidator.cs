using FluentValidation;

namespace FinekraCase.Application.Features.Order.SaveOrder
{
    public class SaveOrderCommandValidator : AbstractValidator<SaveOrderCommand>
    {
        public SaveOrderCommandValidator()
        {
            RuleFor(x => x.ShipAddress).NotEmpty().NotNull();
            RuleFor(x => x.UserDetailId).NotEmpty().WithMessage("UserDetailId boş olamaz!"); 
        }
    }
}
