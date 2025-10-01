// Declare class
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

// Constructor to initialize the corresponding properties of the 'Book' object
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

// Override ToString() method to display a representation of the book when called
    public override string ToString()
    {
        return $"{Title} by {Author} (ISBN: {ISBN})";
    }
}
