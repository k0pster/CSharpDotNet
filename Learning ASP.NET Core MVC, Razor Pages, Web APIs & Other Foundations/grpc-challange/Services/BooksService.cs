using Grpc.Core;
using grpc_challange;


namespace grpc_challange.Services;

public class BooksService : Books.BooksBase
{
    record Book(string Title, string Author) { }

    private Book[] library = [
        new Book("A Farewell to Arms", "Ernest Hemingway"),
        new Book("Ulysses", "James Joyce"),
        new Book("Clear Light of Day", "Anita Desau"),
        new Book("Finansowa Forteca", "Marcin Iwuć")
    ];

    public override Task<BookAuthor> GetAuthor(BookTitle request, ServerCallContext context)
    {
        var BookAuthor = library.FirstOrDefault(book => book.Title == request.Title)?.Author;
        return Task.FromResult(new BookAuthor { Author = BookAuthor });
    }
}