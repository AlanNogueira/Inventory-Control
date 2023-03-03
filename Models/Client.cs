using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory_Control.Models
{
	public class Client : BaseEntity
	{
		public string Name { get; set; }
		public string CPF { get; set; }
		public string Email { get; set; }
		
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
		public DateTime BirthDate { get; set; }
	}
}