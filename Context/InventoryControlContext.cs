using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory_Control.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory_Control.Context
{
	public class InventoryControlContext : DbContext
	{
		public InventoryControlContext(DbContextOptions<InventoryControlContext> options) : base(options)
		{
			
		}
		
		public DbSet<Sale> Sales { get; set; }
		
		public DbSet<Seller> Sellers { get; set; }
		
		public DbSet<Client> Clients { get; set; }
		
		public DbSet<Product> Products { get; set; }
		
		public DbSet<ProductsToSale> ProductsToSales { get; set; }
		
		public DbSet<User> Users { get; set; }
	}
}