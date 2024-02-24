using Ardalis.Specification;
using Domain.Entities;

namespace Application.Specifications
{
    public class SearchPlateNumber : Specification<Vehicle>
    {
        public SearchPlateNumber(string number)
        {
            Query.Where(x => x.PlateNumbe.Equals(number));
        }
    }
}
