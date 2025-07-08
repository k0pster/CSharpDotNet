var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

Book[] library = [
    new Book("A farewell to Arms", "Ernest Hemingway"),
    new Book("Ulsysses", "James Joyces"),
    new Book("Clear Light of Day", "Anita Desai"),
    new Book("Finansowa Forteca", "Marcin Iwuć")
];

app.MapGet("/api/books/list", () => library);

app.MapGet("/api/books/authorsearch/{authorName}", (string authorName) =>
{
    return Array.FindAll(library, book => book.Author.Contains(authorName, StringComparison.OrdinalIgnoreCase));
});

app.Run();

record Book(string Title, string Author)
{
    
}