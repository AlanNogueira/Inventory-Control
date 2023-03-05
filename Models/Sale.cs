using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory_Control.Models;

public class Sale : BaseEntity
{
	[NotMapped]
	public Seller Seller { get; set; }
	
	public int SellerId { get; set; }
	
	[NotMapped]
	public List<Product> Products { get; set; }
	
	public float TotalPrice { get; set; }
	[NotMapped]
	public Client Client { get; set; }
	
	public int ClientId { get; set; }
}