using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Inventory_Control.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Inventory_Control.Controllers
{
	public class SellerController : Controller
	{
		private readonly InventoryControlContext _context;

		public SellerController(InventoryControlContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var sellers = _context.Sellers.ToList();
			return View(sellers);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View("Error!");
		}
	}
}