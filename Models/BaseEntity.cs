using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory_Control.Models
{
	public class BaseEntity
	{
		public int Id { get; set; }
		public DateTime CreatioDate { get; set; }
		public DateTime DeletionDate { get; set; }
	}
}