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
				new MultipleAnswersQuiz("Which of these are real Linux distributions:", new List<string> {"Ubuntu", "Fedora", "Red Hat"}, new List<string>() { "Tux", "Linuxes", "WSL" }),
				new MultipleAnswersQuiz("What languages are in the Linux kernel as of 2023?", new List<string> {"C", "Rust"}, new List<string>() { "C++", "C#", "Java" }),
				new MultipleAnswersQuiz("Which of these databases are NoSQL databases?", new List<string> {"MongoDB", "Neo4j"}, new List<string>() { "PostgreSQL", "MariaDB" }),
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
