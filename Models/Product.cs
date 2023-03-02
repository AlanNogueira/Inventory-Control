using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory_Control.Models
{
	public class Product : BaseEntity
	{
		public string ProductName { get; set; }
		
		public int Quantity { get; set; }
		
		public float Price { get; set; }
	}
}