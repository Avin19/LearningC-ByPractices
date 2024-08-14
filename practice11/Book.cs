
public class Book
{
    public Book(string _title, string _author)
    {
        Title = _title;
        Author = _author;
        System.Console.WriteLine($" Book Name {Title} {Author}");
    }

    public string Title { get; set; }
    public string Author { get; set; }

    ~Book()
    {

    }

}