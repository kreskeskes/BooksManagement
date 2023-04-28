using Books.DataAccess.Data;
using Books.DataAccess.Repository.IRepository;
using Books.Models.Models;

namespace Books.DataAccess.Repository
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		private ApplicationDbContext _db;
		public ProductRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}



		public void Update(Product obj)
		{
			_db.Products.Update(obj);
		}


	}
}