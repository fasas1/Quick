using QuickLogistics.Models;

namespace QuickLogistics.Repository.IRepository
{
    public interface IShipmentRepository: IRepository<Shipment>
    {
        Task<Shipment> UpdateAsync(Shipment entity);
    }
}
