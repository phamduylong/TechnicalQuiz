using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TechnicalQuiz.Data;
using TechnicalQuiz.Models;

namespace TechnicalQuiz.Controllers
{
    public class SingleAnswerQuizController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public SingleAnswerQuizController(ILogger<HomeController> logger)
		{
			_logger = logger;
			_logger.LogInformation("Logger is on SingleAnswerQuizzesController");
		}

		public IActionResult Index()
		{
			var quizzes = new List<SingleAnswerQuiz>
			{
				new SingleAnswerQuiz("Who created the SvelteKit framework/compiler?", "Rich Harris", new List<string>() { "Bill Gates", "Linus Torsvald", "Ada Lovelace" }),
				new SingleAnswerQuiz("In what year was Svelte first released", "2016", new List<string>() { "2013", "2018", "2021" })
			};
			return View(model: quizzes);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
