namespace TechnicalQuiz
{
	public class MultipleAnswersQuiz
	{
		public MultipleAnswersQuiz(string _title, List<string> _answers, List<string> _options)
		{
			Title = _title;
			Answer = _answers;
			Options = _options;
			Id = Guid.NewGuid().ToString();
		}
		public string Title { get; set; }

		public List<string> Answer { get; set; }

		public List<string> Options { get; set; }

		public bool AllowMultipleChoices { get; set; }

		public string Id { get; set; }

	}
}