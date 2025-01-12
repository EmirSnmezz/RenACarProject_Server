using Core.Utilities.Messages.Constants;
using Entity.Entities.Concrete;
using FluentValidation;

namespace Business.ValidatonRules.FluentValidation
{
    public class CarValidations : AbstractValidator<Car>
    {
        public CarValidations()
        {
            #region Validation Rules For Car Descprition
            RuleFor(car => car.Description).NotEmpty().WithMessage(Messages.CarNameMustBeNotNull);
            RuleFor(car => car.Description).NotNull().WithMessage(Messages.CarNameMustBeNotNull);
            RuleFor(car => car.Description).MinimumLength(2);
            //RuleFor(car => car.Description).Must(StartsWithA); // kendi tanımladığımız fonksiyondaki şartı yerine getirmesini istiyorsak yani tanımlı olan kurallar yerine FluentValidation bizim tanımlamış olduğumuz kuralları kullansın istiyorsak Must() methoduna ilgili kontrolü yaptığımız metohdun adını gireriz.
            #endregion

            #region Validation Rules For BrandId
            RuleFor(car => car.BrandId).NotEmpty().WithMessage(Messages.BrandAddError);
            RuleFor(car => car.BrandId).NotNull().WithMessage(Messages.BrandAddError);
            #endregion

            #region Validation Rules For ColorId
            RuleFor(car => car.ColorId).NotEmpty().WithMessage(Messages.ColorAddedError);
            RuleFor(car => car.ColorId).NotNull().WithMessage(Messages.ColorAddedError);
            #endregion

            #region Validation Rules For DailyPrice
            RuleFor(car => car.DailyPrice).NotEmpty().WithMessage(Messages.DailyPriceNotBeNullOnTheCartDefinition);
            RuleFor(car => car.DailyPrice).NotNull().WithMessage(Messages.DailyPriceNotBeNullOnTheCartDefinition);
            #endregion

        }
    }
}
