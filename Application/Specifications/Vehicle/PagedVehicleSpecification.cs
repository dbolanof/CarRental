using Ardalis.Specification;
using Domain.Entities;
namespace Application.Specifications
{
    public class PagedVehicleSpecification : Specification<Vehicle>
    {
        public PagedVehicleSpecification(int PageSize, int PageNumber, string PlateNumber, string Brand)
        {
            Query.Skip((PageNumber - 1) * PageSize).Take(PageSize);
            if (!string.IsNullOrEmpty(PlateNumber))
            {
                Query.Search(s => s.PlateNumbe, "%" + PlateNumber + "%");
            }
            if (!string.IsNullOrEmpty(Brand))
            {
                Query.Search(s => s.Brand, "%" + Brand + "%");
            }        
        }
    }
}
