using Application.Wrappers;
using MediatR;

namespace Application.Features.Vehicle.Queries
{
    public class ValidateDuplicated : IRequest<Response<bool>>
    {
        public string PlateNumbe { get; set; }
    }
}
