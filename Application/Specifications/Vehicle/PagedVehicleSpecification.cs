using Ardalis.Specification;
using Domain.Entities;
namespace Application.Specifications
{
    public class PagedVehicleSpecification : Specification<Vehicle>
    {
        public PagedVehicleSpecification(int PageSize, int PageNumber, short status, int PlaceDelivery, int PlacePickUp)
        {
            Query.Skip((PageNumber - 1) * PageSize).Take(PageSize);
            if (status > 0)
            {
                Query.Where(s => s.IdStatusVehicle.Equals(status));
            }
            if (PlacePickUp > 0)
            {
                Query.Where(s => s.IdPlacePickUp.Equals(PlacePickUp));
            }
            if (PlaceDelivery > 0)
            {
                Query.Where(s => s.IdPlaceDelivery.Equals(PlaceDelivery));
            }
            Query.Include(s => s.IdPlaceDeliveryNavigation);
            Query.Include(s => s.IdPlacePickUpNavigation);
            Query.Include(s => s.IdStatusVehicleNavigation);

        }
    }
}
