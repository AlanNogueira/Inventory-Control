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
	public class UserController : Controller
	{
		private readonly InventoryControlContext _context;

		public UserController(InventoryControlContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}
		
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Login(User user)
		{
			User userLogin = _context.Users.Where(x => x.userName.Equals(user.userName) && x.password.Equals(user.password)).FirstOrDefault();
			if (userLogin != null)
			{
				ViewBag.loggedUserID = userLogin.Id.ToString();
				ViewBag.loggedUserName = userLogin.userName.ToString();
				return RedirectToAction("Index","Sale");
			}
			else
			{
				return RedirectToAction("Index");
			}
		}
		
		public IActionResult Register()
		{
			return View();
		}
		
		[HttpPost]
		public IActionResult Register(User user)
		{
			User existUser = _context.Users.Where(x => x.userName.Equals(user.userName)).FirstOrDefault();
			if(existUser == null && user.userName != null && user.password != null)
			{
				_context.Users.Add(user);
				_context.SaveChanges();	
				return RedirectToAction(nameof(Index));
			}
			else
			{
				// ModelState.AddModelError("", "Usuário ou senha inválidos");
				return View();
			}
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View("Error!");
		}
	}
}