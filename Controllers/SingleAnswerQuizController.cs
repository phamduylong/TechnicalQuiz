using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
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
				new SingleAnswerQuiz("In what year was Svelte first released", "2016", new List<string>() { "2013", "2018", "2021" }),
				new SingleAnswerQuiz("Linux 1.0.0 was released in March 1994. How many lines of code were there in the release?", "176,250", new List<string>() { "51,923", "100,097", "252,766" }),
				new SingleAnswerQuiz("Which version of JavaScript introduced the arrow syntax?", "ECMAScript 2015 (ES6)", new List<string>() { "ECMAScript 5 2009 (ES5)", "ECMAScript 2017", "ECMAScript 2019" }),
				new SingleAnswerQuiz("How many design patterns was included in the book Design Patterns written by Gangs of Four?", "23", new List<string>() { "15", "29", "31" }),

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
