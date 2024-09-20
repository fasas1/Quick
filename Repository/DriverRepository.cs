using QuickLogistics.Data;
using QuickLogistics.Models;
using QuickLogistics.Repository.IRepository;

namespace QuickLogistics.Repository
{
    public class DriverRepository :Repository<Driver>, IDriverRepository
    {
        private readonly ApplicationDbContext _db;


        public DriverRepository(ApplicationDbContext db):base(db) 
        {
            _db = db;
        }
        public async Task<Driver> UpdateAsync(Driver entity)
        {
            // entity.UpdatedDate = DateTime.Now;
            _db.Drivers.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

    }
}
