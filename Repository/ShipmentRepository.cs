using QuickLogistics.Data;
using QuickLogistics.Models;
using QuickLogistics.Repository.IRepository;

namespace QuickLogistics.Repository
{
    public class ShipmentRepository :Repository<Shipment>, IShipmentRepository
    {
        private readonly ApplicationDbContext _db;


        public ShipmentRepository(ApplicationDbContext db):base(db) 
        {
            _db = db;
        }
        public async Task<Shipment> UpdateAsync(Shipment entity)
        {
            entity.ShippedDate = DateTime.Now;
            _db.Shipments.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

    }
}
