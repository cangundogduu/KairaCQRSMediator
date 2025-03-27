using FluentValidation;
using KairaCQRSMediator.Features.Mediator.Commands.ProductCommands;

namespace KairaCQRSMediator.Validations.ProductValidators
{
    public class UpdateProductValidator:AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün Adı Boş Bırakılamaz!")
                                      .MinimumLength(3).WithMessage("Ürün Adı En Az 3 Karakter Olmalıdır!")
                                      .MaximumLength(50).WithMessage("Ürün Adı En Fazla 50 Karakter Olmalıdır!");


            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Ürün Resmi Boş Bırakılamaz!");


            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün Fiyatı Boş Bırakılamaz!")
                                 .InclusiveBetween(10, 10000).WithMessage("Ürün fiyatı 10 ile 10.000 arasında bir değer olmalıdır!");


            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Ürün Kategorisi Boş Bırakılamaz!");
        }
    }
}
