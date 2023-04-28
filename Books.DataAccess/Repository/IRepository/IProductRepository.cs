
using Books.Models.Models;

namespace Books.DataAccess.Repository.IRepository
{
	public interface IProductRepository : IRepository<Product>
	{
		void Update(Product obj);
	}
}
