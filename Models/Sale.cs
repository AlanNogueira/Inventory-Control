using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory_Control.Models;

public class Sale : BaseEntity
{
	public Seller Seller { get; set; }
	
	public List<Product> Products { get; set; }
	
	public float TotalPrice { get; set; }
	
	public Client Client { get; set; }
}