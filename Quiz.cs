public class Quiz
{
    public Quiz(string _title, string _answer, List<string> _options) 
    {
        Title = _title;
        Answer = _answer;
        Options = _options;
        Id = Guid.NewGuid().ToString();
    }
    public string Title { get; set; }

    public string Answer { get; set; }

    public List<string> Options { get; set; }

    public string Id { get; set; }

}