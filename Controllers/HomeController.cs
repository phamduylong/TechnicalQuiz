using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TechnicalQuiz.Models;

namespace TechnicalQuiz.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View(model:new Quiz("Who created the SvelteKit framework/compiler?", "Rich Harris", new List<string>() { "Bill Gates", "Linus Torsvald", "Ada Lovelace" }, false));
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
}