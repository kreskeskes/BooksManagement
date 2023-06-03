using Books.Models.Models;

namespace Books.DataAccess.Repository.IRepository
{
	public interface IOrderDetailRepository : IRepository<OrderDetail>
	{
		void Update(OrderDetail obj);
	}
}