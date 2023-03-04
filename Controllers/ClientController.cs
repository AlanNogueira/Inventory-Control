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
	public class ClientController : Controller
	{
		private readonly InventoryControlContext _context;

		public ClientController(InventoryControlContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var clients = _context.Clients.ToList();
			return View(clients);
		}
		
		public IActionResult Create()
		{
			return View();
		}
		
		[HttpPost]
		public IActionResult Create(Client client)
		{
			client.CreatioDate = DateTime.Now;
			
			if(ModelState.IsValid)
				_context.Clients.Add(client);
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