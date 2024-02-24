using Application.Features.Vehicle.Commands;
using FluentValidation;

namespace Application.Features.Vehicle
{
    public class ValidateVehicle : AbstractValidator<CreateVehicleCommand>
    {
    }
}
