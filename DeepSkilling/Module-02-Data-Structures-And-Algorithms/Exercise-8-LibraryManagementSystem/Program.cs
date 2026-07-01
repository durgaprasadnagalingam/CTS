using System;
using System.Collections.Generic;

class Book
{
    public int Id;
    public string Title = "";
    public string Author = "";
}

class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>()
        {
            new Book { Id = 1, Title = "C# Programming", Author = "Microsoft" },
            new Book { Id = 2, Title = "Java", Author = "James Gosling" },
            new Book { Id = 3, Title = "Python", Author = "Guido van Rossum" }
        };

        Console.WriteLine("Library Books:");
        Console.WriteLine();

        foreach (Book book in books)
        {
            Console.WriteLine($"ID: {book.Id}");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine();
        }
    }
}