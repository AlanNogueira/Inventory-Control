using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Inventory_Control.Context;
using Inventory_Control.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Inventory_Control.Controllers
{
	public class SaleController : Controller
	{
		private readonly InventoryControlContext _context;

		public SaleController(InventoryControlContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			List<Sale> sales = _context.Sales.Where( x => x.DeletionDate == null).ToList();
			
			foreach(Sale sale in sales)
			{
				sale.Client = _context.Clients.Find(sale.ClientId);
				sale.Seller = _context.Sellers.Find(sale.SellerId);
				List<ProductsToSale> productsToSales = _context.ProductsToSales.Where( x => x.SaleId == sale.Id).ToList();
				List<Product> products = new List<Product>();
				foreach(ProductsToSale productsToSale in productsToSales)
				{
					Product product = _context.Products.Find(productsToSale.ProductId);
					products.Add(product);
				}
				sale.Products = products;
				ViewBag.ProductsToSales = productsToSales;
			}
			
			return View(sales);
		}
		
		public IActionResult Create()
		{
			var Clients = _context.Clients.Where(x => x.DeletionDate == null).OrderBy(x => x.Name).Select( x => new SelectListItem() 
			{ Text = x.Name.ToString(), Value = x.Id.ToString() });
			var Sellers = _context.Sellers.Where(x => x.DeletionDate == null).OrderBy(x => x.Name).Select( x => new SelectListItem() 
			{ Text = x.Name.ToString(), Value = x.Id.ToString() });
			var Products = _context.Products.Where(x => x.DeletionDate == null).OrderBy(x => x.ProductName).Select( x => new SelectListItem() 
			{ Text = x.ProductName.ToString(), Value = x.Id.ToString() });
			
			ViewBag.Clients = Clients;
			ViewBag.Sellers = Sellers;
			ViewBag.Products = Products;
			
			return View();
		}
		
		[HttpPost]
		public IActionResult Create(int Seller, int Client, List<int> Products)
		{
			Sale sale = new Sale
			{
				ClientId = Client,
				SellerId = Seller,
				CreationDate = DateTime.Now
			};
			
			_context.Sales.Add(sale);
			_context.SaveChanges();
			
			foreach(int Product in Products)
			{
				_context.Products.Find(Product);
				ProductsToSale productsToSale = new ProductsToSale
				{
					SaleId = sale.Id,
					SellerId = Seller,
					ProductId = Product,
					CreationDate = DateTime.Now
				};
				_context.ProductsToSales.Add(productsToSale);
			}
			
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