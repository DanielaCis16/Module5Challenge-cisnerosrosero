using System;
using System.Collections.Generic;
using System.Linq;

public class Library
{
    public string Name { get; set; } //name of the library
    private List<Book> Books { get; set; } // private list to store books

    // initialize the Book list as an empty list
    public Library(string name)
    {
        Name = name;
        Books = new List<Book>();
    }

    // Method add books to list
    public void AddBook(Book book)
    {
        Books.Add(book); // adds book to Books list
        Console.WriteLine($"Added: {book}"); // displays confirmation message
    }

    // Method to remove books from list
    public bool RemoveBook(string isbn)
    {
        // takes the ISBN and looks for it in the list
        Book bookToRemove = Books.FirstOrDefault(b => b.ISBN == isbn);
        if (bookToRemove != null) 
        {
            Books.Remove(bookToRemove); // remove it if it exist
            Console.WriteLine($"Removed: {bookToRemove}"); // display confirmation message
            return true;
        }
        Console.WriteLine("Book not found."); // display this message if book not found
        return false;
    }

    public void DisplayAvailableBooks()
    {
        Console.WriteLine("Available Books:");
        foreach (var book in Books) // iterate over the list
        {
            Console.WriteLine(book); // display all books available
        }
    }

    public Book GetBook(string isbn)
    {
        return Books.FirstOrDefault(b => b.ISBN == isbn);
    }
}