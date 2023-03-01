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
		
		public DbSet<SaleModel> Sales { get; set; }
		
		public DbSet<SellerModel> Sellers { get; set; }
		
		public DbSet<ClientModel> Clients { get; set; }
	}
}