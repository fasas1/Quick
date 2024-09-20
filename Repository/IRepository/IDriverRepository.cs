using QuickLogistics.Models;

namespace QuickLogistics.Repository.IRepository
{
    public interface IDriverRepository: IRepository<Driver>
    {
        Task<Driver> UpdateAsync(Driver entity);
    }
}
