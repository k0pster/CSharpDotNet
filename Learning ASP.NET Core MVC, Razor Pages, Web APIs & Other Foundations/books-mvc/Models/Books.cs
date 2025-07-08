namespace books_mvc.Models;

public class Books
{
    public string[] Library { get; set; }
    public string FavoriteBook { get; set; }
    public Books()
    {
        Library = ["The C Programming language", "C Language Prata", "CSS Grind"];
        FavoriteBook = Library[1];
    }
}