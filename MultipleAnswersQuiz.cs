namespace TechnicalQuiz
{
	public class MultipleAnswersQuiz
	{
		public MultipleAnswersQuiz(string title, List<string> answers, List<string> options)
		{
			Title = title;
			Answer = answers;
			Options = options;
			Id = Guid.NewGuid().ToString();
		}
		public string Title { get; set; }

		public List<string> Answer { get; set; }

		public List<string> Options { get; set; }

		public bool AllowMultipleChoices { get; set; }

		public string Id { get; set; }

	}
}