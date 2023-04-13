using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TechnicalQuiz.Models;

namespace TechnicalQuiz.Controllers
{
    public class MultipleAnswersQuizController : Controller
	{
		public IActionResult Index()
		{
			var quizzes = new List<MultipleAnswersQuiz>
			{
				new MultipleAnswersQuiz("Choose the correct software design patterns:", new List<string> {"Factory", "Builder", "Singleton"}, new List<string>() { "Burger", "Cook", "Vent" }),
				new MultipleAnswersQuiz("Which of these are real Linux distributions:", new List<string> {"Ubuntu", "Fedora", "Red Hat"}, new List<string>() { "Tux", "Linuxes", "WSL" })
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
