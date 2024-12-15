using HotChocolateDemo.Models;

namespace HotChocolateDemo.GraphQL;

public class Query
{
    // Field is named `GetBook` but the name will be shortened to just `book` in the resulting schema
    public Book GetBook() => new Book
    {
        Title = "The Hitchhiker's Guide to the Galaxy",
        Author = new Author
        {
            Name = "Douglas Adams"
        }
    };
}
