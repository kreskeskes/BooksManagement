using Books.DataAccess.Data;
using Books.DataAccess.Repository.IRepository;
using Books.Models.Models;

namespace Books.DataAccess.Repository
{
	public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
	{
		private ApplicationDbContext _db;
		public ProductImageRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}


		public void Update(ProductImage obj)
		{
			_db.ProductImages.Update(obj);
		}
	}
}
