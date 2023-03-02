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
	public class ProductController : Controller
	{
		private readonly InventoryControlContext _context;

		public ProductController(InventoryControlContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var products = _context.Products.ToList();
			return View(products);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View("Error!");
		}
	}
}