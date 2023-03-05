using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory_Control.Models
{
	public class BaseEntity
	{
		[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
		public DateTime CreationDate { get; set; }
		
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
		public DateTime? DeletionDate { get; set; }
	}
}