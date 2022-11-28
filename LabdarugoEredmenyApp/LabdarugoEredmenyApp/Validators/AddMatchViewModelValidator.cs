using FluentValidation;
using LabdarugoEredmenyApp.Data;
using LabdarugoEredmenyApp.ViewModels;
using LabdarugoEredmenyApp.Models;
namespace LabdarugoEredmenyApp.Validators
{
    public class AddMatchViewModelValidator : AbstractValidator<AddMatchViewModel>
    {
        private LabdarugoEredmenyekContext _context;
        public AddMatchViewModelValidator(LabdarugoEredmenyekContext context)
        {
            _context = context;
            RuleFor(x => x.HazaiFelideiEredmeny)
                .Custom((x, context) =>
                {
                    if ((!(int.TryParse(x, out int value))))
                    {
                        context.AddFailure($"{x} is not a valid number");
                    }
                    if ((value < 0 || value > 10))
                    {
                        context.AddFailure($"{x} is not a valid cannot be less than 0 or greater than 10");
                    }
                });
            RuleFor(x => x.VendegFelideiEredmeny)
                .Custom((x, context) =>
                {
                    if ((!(int.TryParse(x, out int value))))
                    {
                        context.AddFailure($"{x} is not a valid number)");
                    }
                    if ((value < 0 || value > 10))
                    {
                        context.AddFailure($"{x} is not a valid cannot be less than 0 or greater than 10");
                    }
                });
            RuleFor(x => x.hazaiVegeredmeny)
                .Custom((x, context) =>
                {
                    if ((!int.TryParse(x, out int value)))
                    {
                        context.AddFailure($"{x} is not a valid number");
                    }
                    if ((value < 0 || value > 10))
                    {
                        context.AddFailure($"{x} is not a valid cannot be  less than 0 or greater than 10");
                    }
                });
            RuleFor(x => x.VendegVegeredmeny)
                .Custom((x, context) =>
                {
                    if ((!(int.TryParse(x, out int value))))
                    {
                        context.AddFailure($"{x} is not a valid number");
                    }
                    if ((value < 0 || value > 10))
                    {
                        context.AddFailure($"{x} is not a valid cannot be  less than 0 or greater than 10");
                    }
                });
            

            RuleFor(x => x.VendegVegeredmeny).NotEmpty().NotNull().WithMessage("Töltsd ki a mezőt");
            RuleFor(x => x.hazaiVegeredmeny).NotEmpty().NotNull().WithMessage("Töltsd ki a mezőt");

            RuleFor(x => x.HazaiFelideiEredmeny).NotEmpty().NotNull().WithMessage("Töltsd ki a mezőt").DependentRules(() =>
            {
                RuleFor(m => new { m.HazaiFelideiEredmeny, m.hazaiVegeredmeny }).Must(x => !IsBiggerNumber(x.hazaiVegeredmeny, x.HazaiFelideiEredmeny)).WithMessage("Vegeredmeny nem lehet kisebb mint a felidei eredmeny");
            });

            RuleFor(x => x.VendegFelideiEredmeny).NotEmpty().NotNull().WithMessage("Töltsd ki a mezőt").DependentRules(() =>
            {
                RuleFor(m => new { m.VendegFelideiEredmeny, m.VendegVegeredmeny }).Must(x => !IsBiggerNumber(x.VendegVegeredmeny, x.VendegFelideiEredmeny)).WithMessage("Vegeredmeny nem lehet kisebb mint a felidei eredmeny");
            });
            RuleFor(x => x.HazaiCsapatId).Must((x, y) => y != x.VendegCsapatId).WithMessage("Válassz csapat nevet");
            RuleFor(x => x.JegyzoKonyv).NotEmpty().WithMessage("Töltsd ki a jegyző könyvet");

            RuleFor(m => new { m.Időpont, m.HazaiCsapatId }).Must(x => !IsTeamBooked(x.HazaiCsapatId, x.Időpont))
                                      .WithMessage("A hazai csapat már játszik ezen a napon! Válassz egy más időpontot!");
            RuleFor(m => new { m.Időpont, m.VendegCsapatId }).Must(x => !IsTeamBooked(x.VendegCsapatId, x.Időpont))
                                      .WithMessage("A vendég csapat már játszik ezen a napon! Válassz egy más időpontot!");
        }
        public bool IsTeamBooked(Guid teamId, DateTime time)
        {
            return _context.Merkozesek.Where(x => x.Idopont.Date == time.Date).Any(x => x.HazaiCsapatId == teamId || x.VendegCsapatId == teamId);
        }
        public bool IsBiggerNumber(string veg,string fel)
        {
            if(int.TryParse(veg, out var szam) && int.TryParse(fel, out  var szam2))
            {
                return szam < szam2;
            }
            return false;

        }
    }


}
