// See https://aka.ms/new-console-template for more information
using BooksStore.Module;


Console.WriteLine("Hello, World!");

var booksstore = new List<BookStore>();


while (true)
{
    Console.WriteLine("Please enter your command: Add, List, Remove, Update");
    var command = Console.ReadLine();

    if (command.ToLower() == "add")
    {
        Console.WriteLine("Please enter the title:");

        var title = Console.ReadLine();

        Console.WriteLine("Please enter the description:");
        var description = Console.ReadLine();

        Console.WriteLine("Please enter the amount");
        int amount = Convert.ToInt32(Console.ReadLine());

        var uniqueTitle = booksstore.Where(a => a.Title == title).ToList().Count();
        
        if (uniqueTitle > 0)
        {
            foreach (var bookStore in booksstore)
            {
                if (bookStore.Title == title)
                {
                    Console.WriteLine("Duplicate title");
                    continue;
                }
            }
        }

        var bookstore = new BookStore(title, description, amount);
        booksstore.Add(bookstore);
    }

    if (command.ToLower() == "list")
    {
        foreach (var bookstore in booksstore)
        {
            Console.WriteLine($"Title: {bookstore.Title}, Description: {bookstore.Description}, Amount: {bookstore.Amount} ");
        }

    }
    if (command.ToLower() == "remove")
    {
        Console.WriteLine("Enter title what you want remove from list:");
        var delete = Console.ReadLine();
        booksstore.RemoveAll(x => x.Title == delete);
    }
    if (command.ToLower() == "update")
    {
        Console.WriteLine( "what book to update");
        var update = Console.ReadLine();
        booksstore.Where(y => y.Title == update).ToList();
        Console.WriteLine("write new title");
        var newTitle = Console.ReadLine();
        foreach (var bookstore in booksstore)
        {
            bookstore.Title = newTitle;
        }
        
    }
 
}
