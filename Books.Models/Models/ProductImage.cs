﻿using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Models.Models
{
	public class ProductImage
	{
		public int Id { get; set; }
		[Required]
		public string ImageUrl { get; set; }
		public int ProductId { get; set; }
		[ForeignKey(nameof(ProductId))]
		public Product Product { get; set; }

	}
}
