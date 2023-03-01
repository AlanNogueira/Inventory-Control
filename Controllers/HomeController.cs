using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Inventory_Control.Models;
using Inventory_Control.Context;

namespace Inventory_Control.Controllers;

public class HomeController : Controller
{
	private readonly InventoryControlContext _context;

	public HomeController(InventoryControlContext context)
	{
		_context = context;
	}

	public IActionResult Index()
	{
		return View();
	}

	public IActionResult Privacy()
	{
		return View();
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
