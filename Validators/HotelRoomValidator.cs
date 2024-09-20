using FluentValidation;
using hotel.Dtos;
using hotel.Entities;

namespace hotel.Validators
{
    public class HotelRoomValidator : AbstractValidator<HotelRoomsDto>
    {
        public HotelRoomValidator()
        {
            RuleFor(x => x.Number)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.AmoundOfBed)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.AmoundOfPeople)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.Rating)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.Flour)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.Price)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
            RuleFor(x => x.Discount)
                .InclusiveBetween(0, 100);


        }
        //public bool ValidateUri(string? uri)
        //{
        //    // just so the validation passes if the uri is not required / nullable
        //    if (string.IsNullOrEmpty(uri))
        //    {
        //        return true;
        //    }
        //    return Uri.TryCreate(uri, UriKind.Absolute, out _);
        //}
    }
}
