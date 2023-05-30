using Books.DataAccess.Data;
using Books.DataAccess.Repository.IRepository;
using Books.Models.Models;

namespace Books.DataAccess.Repository
{

	public class CompanyRepository : Repository<Company>, ICompanyRepository
	{
		private ApplicationDbContext _db;
		public CompanyRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}
		public void Update(Company obj)
		{
			_db.Companies.Update(obj);
		}
	}
}
