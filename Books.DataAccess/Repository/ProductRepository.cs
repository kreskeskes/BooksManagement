﻿using Books.DataAccess.Data;
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
			var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
			if (objFromDb != null)
			{
				objFromDb.Title = obj.Title;
				objFromDb.Description = obj.Description;
				objFromDb.ISBN = obj.ISBN;
				objFromDb.Author = obj.Author;
				objFromDb.Price100 = obj.Price100;
				objFromDb.ListPrice = obj.ListPrice;
				objFromDb.Price50 = obj.Price50;
				objFromDb.CategoryId = obj.CategoryId;
				objFromDb.Price = obj.Price;
				objFromDb.ProductImages = obj.ProductImages;
				//if (obj.ImageUrl != null)
				//{
				//	objFromDb.ImageUrl = obj.ImageUrl;
				//}



			}
		}


	}
}