using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory_Control.Models
{
	public class Seller : BaseEntity
	{
		public string Name { get; set; }
		public string CPF { get; set; }
		public string Email { get; set; }
		public DateTime BirthDate { get; set; }
		public int TotalSales { get; set; }
	}
}