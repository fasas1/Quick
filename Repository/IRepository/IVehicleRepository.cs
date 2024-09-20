using QuickLogistics.Models;

namespace QuickLogistics.Repository.IRepository
{
    public interface IVehicleRepository: IRepository<Vehicle>
    {
        Task<Vehicle> UpdateAsync(Vehicle entity);
    }
}
