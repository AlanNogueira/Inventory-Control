using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory_Control.Models
{
	public class ProductsToSale : BaseEntity
	{
		public Seller Seller { get; set; }
		
		public Sale Sale { get; set; }
		
		public Product Product { get; set; }
	}
}