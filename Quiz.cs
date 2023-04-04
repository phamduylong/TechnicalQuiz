public class Quiz
{
    public Quiz(string _title, string _answer, List<string> _options, bool _allowMultiple) 
    {
        Title = _title;
        Answer = _answer;
        Options = _options;
        AllowMultipleChoices = _allowMultiple;
        Id = Guid.NewGuid().ToString();
    }
    public string Title { get; set; }

    public string Answer { get; set; }

    public List<string> Options { get; set; }

    public bool AllowMultipleChoices { get; set; }

    public string Id { get; set; }

}