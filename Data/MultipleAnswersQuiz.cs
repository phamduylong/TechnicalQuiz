namespace TechnicalQuiz.Data
{
    public class MultipleAnswersQuiz
    {
        public MultipleAnswersQuiz(string title, List<string> answers, List<string> options)
        {
            Title = title;
            Answers = answers;
            Options = options;
            Id = Guid.NewGuid().ToString();
        }
        public string Title { get; set; }

        public List<string> Answers { get; set; }

        public List<string> Options { get; set; }

        public string Id { get; set; }

    }
}