namespace TechnicalQuiz.Models
{
    public class SingleAnswerQuiz
    {
        public SingleAnswerQuiz(string title, string answer, List<string> options)
        {
            Title = title;
            Answer = answer;
            Options = options;
            Id = Guid.NewGuid().ToString();
        }
        public string Title { get; set; }

        public string Answer { get; set; }

        public List<string> Options { get; set; }

        public string Id { get; set; }

    }
}