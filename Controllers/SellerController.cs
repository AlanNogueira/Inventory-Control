using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Inventory_Control.Context;
using Inventory_Control.Models;
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
		
		public IActionResult Create()
		{
			return View();
		}
		
		[HttpPost]
		public IActionResult Create(Seller seller)
		{
			seller.CreationDate = DateTime.Now;
			
			if(ModelState.IsValid)
				_context.Sellers.Add(seller);
			_context.SaveChanges();
			return RedirectToAction(nameof(Index));
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View("Error!");
		}
	}
}