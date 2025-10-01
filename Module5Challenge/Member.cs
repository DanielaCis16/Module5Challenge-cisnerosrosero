using System;
using System.Collections.Generic;
using System.Linq;

public class Member
{
    public string Name { get; set; }
    public int ID { get; set; }
    private List<Book> BorrowedBooks { get; set; }

    public Member(string name, int id) // constructor
    {
        Name = name; // initialize the Name property
        ID = id; // initialize ID property
        BorrowedBooks = new List<Book>(); // Create empty list for Borrowed Books
    }

    // method to move a book from the available books to the borrowed books
    public void BorrowBook(Library library, string isbn)
    {
        Book book = library.GetBook(isbn); // get the book from the library using ISBN
        if (book != null)
        {
            BorrowedBooks.Add(book); // add book to the BorrowedBooks list
            library.RemoveBook(isbn); // removes the book from the library
            Console.WriteLine($"{Name} borrowed: {book}"); // display confirmation message
        }
        else
        {
            Console.WriteLine("Book not available."); // book not found message
        }
    }
    
    // method to organize the returned books
    public void ReturnBook(Library library, string isbn)
    {
        Book book = BorrowedBooks.FirstOrDefault(b => b.ISBN == isbn);
        if (book != null)
        {
            BorrowedBooks.Remove(book); // remove from borrowed books
            library.AddBook(book); // add book to available books
            Console.WriteLine($"{Name} returned: {book}"); // confirmation message
        }
        else
        {
            Console.WriteLine("Book not found in borrowed list.");
        }
    }

    public void DisplayBorrowedBooks()
    {
        Console.WriteLine($"{Name}'s Borrowed Books:"); // display memeber's name
        foreach (var book in BorrowedBooks) // loop to display all the books borrowed by member
        {
            Console.WriteLine(book);
        }
    }
}