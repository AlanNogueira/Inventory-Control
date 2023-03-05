using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory_Control.Models
{
	public class ProductsToSale : BaseEntity
	{
		[NotMapped]
		public Seller Seller { get; set; }
		public int SellerId { get; set; }
		[NotMapped]
		public Sale Sale { get; set; }
		public int SaleId { get; set; }
		[NotMapped]
		public Product Product { get; set; }
		public int ProductId { get; set; }
	}
}