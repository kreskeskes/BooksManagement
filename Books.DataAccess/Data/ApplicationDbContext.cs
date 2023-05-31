using Books.Models;
using Books.Models.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Books.DataAccess.Data
{
	public class ApplicationDbContext : IdentityDbContext<IdentityUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<Company> Companies { get; set; }
		public DbSet<ShoppingCart> ShoppingCarts { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Category>().HasData(
				new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
				new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
				new Category { Id = 3, Name = "History", DisplayOrder = 3 }
				);
			modelBuilder.Entity<Company>().HasData(
				new Company
				{
					Id = 1,
					Name = "CompanieNr1",
					StreetAddress = "Str. A. Puskin 32",
					City = "Chisinau",
					PostalCode = "MD-2020",
					PhoneNumber = 069705018

				},
				new Company
				{
					Id = 2,
					Name = "Best Co",
					StreetAddress = "Str. Stefan Cel Mare 3",
					City = "Balti",
					PostalCode = "MD-2920",
					PhoneNumber = 065785412
				},
				new Company
				{
					Id = 3,
					Name = "Book Lovers",
					StreetAddress = "Str. Studentilor 9/7",
					City = "Chisinau",
					PostalCode = "MD-2045",
					PhoneNumber = 022509905
				}
				);
			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "To Kill a Mockingbird",
					Author = "Harper Lee",
					Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
					ISBN = "9780446310789",
					ListPrice = 99,
					Price = 90,
					Price50 = 85,
					Price100 = 80,
					CategoryId = 1,
					ImageUrl = ""


				},
				new Product
				{
					Id = 2,
					Title = "The Great Gatsby",
					Author = "F. Scott Fitzgerald",
					Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
					ISBN = "9780743273565",
					ListPrice = 40,
					Price = 30,
					Price50 = 25,
					Price100 = 20,
					CategoryId = 2,
					ImageUrl = ""
				},
				new Product
				{
					Id = 3,
					Title = "1984",
					Author = "George Orwell",
					Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
					ISBN = "9780451524935",
					ListPrice = 55,
					Price = 50,
					Price50 = 40,
					Price100 = 35,
					CategoryId = 3,
					ImageUrl = ""
				},
				new Product
				{
					Id = 4,
					Title = "The Catcher in the Rye",
					Author = "J.D. Salinger",
					Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
					ISBN = "9780316769488",
					ListPrice = 70,
					Price = 65,
					Price50 = 60,
					Price100 = 55,
					CategoryId = 2,
					ImageUrl = ""
				},
				new Product
				{
					Id = 5,
					Title = "Pride and Prejudice",
					Author = "Jane Austen",
					Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
					ISBN = "9780141439518",
					ListPrice = 30,
					Price = 27,
					Price50 = 25,
					Price100 = 20,
					CategoryId = 1,
					ImageUrl = ""

				});
		}
	}
}
