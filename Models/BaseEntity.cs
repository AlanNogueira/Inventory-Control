using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory_Control.Models
{
	public class BaseEntity
	{
		public int Id { get; set; }
		
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
		public DateTime CreatioDate { get; set; }
		
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
		public DateTime? DeletionDate { get; set; }
	}
}