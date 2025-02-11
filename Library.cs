using System;

// Node class representing a book in the library
class BookNode
{
    public string Title;         
    public string Author;     
    public string Genre;      
    public int BookID;           
    public bool IsAvailable;     
    public BookNode Previous;     
    public BookNode Next;        

    // Constructor to initialize a book node
    public BookNode(string title, string author, string genre, int bookID)
    {
        Title = title;
        Author = author;
        Genre = genre;
        BookID = bookID;
        IsAvailable = true; // By default, the book is available
        Previous = null;
        Next = null;
    }
}


class Library
{
    private BookNode head; // Head of the doubly linked list
    private BookNode tail; // Tail of the doubly linked list
    private int count;    

    // Constructor to initialize an empty library
    public Library()
    {
        head = null;
        tail = null;
        count = 0;
    }

    // Method to add a book at the beginning of the list
    public void AddBookAtBeginning(string title, string author, string genre, int bookID)
    {
        BookNode newBook = new BookNode(title, author, genre, bookID);

        if (head == null) // If the list is empty
        {
            head = newBook;
            tail = newBook;
        }
        else
        {
            newBook.Next = head;
            head.Previous = newBook;
            head = newBook;
        }
        count++;
        Console.WriteLine($"Book '{title}' added at the beginning.");
    }

    // Method to add a book at the end of the list
    public void AddBookAtEnd(string title, string author, string genre, int bookID)
    {
        BookNode newBook = new BookNode(title, author, genre, bookID);

        if (tail == null) // If the list is empty
        {
            head = newBook;
            tail = newBook;
        }
        else
        {
            newBook.Previous = tail;
            tail.Next = newBook;
            tail = newBook;
        }
        count++;
        Console.WriteLine($"Book '{title}' added at the end.");
    }

    // Method to add a book at a specific position
    public void AddBookAtPosition(string title, string author, string genre, int bookID, int position)
    {
        if (position < 1 || position > count + 1)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        if (position == 1)
        {
            AddBookAtBeginning(title, author, genre, bookID);
        }
        else if (position == count + 1)
        {
            AddBookAtEnd(title, author, genre, bookID);
        }
        else
        {
            BookNode newBook = new BookNode(title, author, genre, bookID);
            BookNode current = head;
            for (int i = 1; i < position - 1; i++)
            {
                current = current.Next;
            }
            newBook.Next = current.Next;
            newBook.Previous = current;
            current.Next.Previous = newBook;
            current.Next = newBook;
            count++;
            Console.WriteLine($"Book '{title}' added at position {position}.");
        }
    }

    // Method to remove a book by Book ID
    public void RemoveBookByID(int bookID)
    {
        BookNode current = head;

        while (current != null)
        {
            if (current.BookID == bookID)
            {
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }

                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    tail = current.Previous;
                }

                count--;
                Console.WriteLine($"Book with ID {bookID} removed.");
                return;
            }
            current = current.Next;
        }
        Console.WriteLine($"Book with ID {bookID} not found.");
    }

    // Method to search for a book by Title
    public void SearchByTitle(string title)
    {
        BookNode current = head;
        bool found = false;

        while (current != null)
        {
            if (current.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Book Found: ID={current.BookID}, Title={current.Title}, Author={current.Author}, Genre={current.Genre}, Available={current.IsAvailable}");
                found = true;
            }
            current = current.Next;
        }

        if (!found)
        {
            Console.WriteLine($"No book found with title '{title}'.");
        }
    }

    // Method to search for a book by Author
    public void SearchByAuthor(string author)
    {
        BookNode current = head;
        bool found = false;

        while (current != null)
        {
            if (current.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Book Found: ID={current.BookID}, Title={current.Title}, Author={current.Author}, Genre={current.Genre}, Available={current.IsAvailable}");
                found = true;
            }
            current = current.Next;
        }

        if (!found)
        {
            Console.WriteLine($"No book found by author '{author}'.");
        }
    }

    // Method to update a book's availability status
    public void UpdateAvailability(int bookID, bool isAvailable)
    {
        BookNode current = head;

        while (current != null)
        {
            if (current.BookID == bookID)
            {
                current.IsAvailable = isAvailable;
                Console.WriteLine($"Book with ID {bookID} availability updated to {isAvailable}.");
                return;
            }
            current = current.Next;
        }
        Console.WriteLine($"Book with ID {bookID} not found.");
    }

    // Method to display all books in forward order
    public void DisplayBooksForward()
    {
        BookNode current = head;

        if (current == null)
        {
            Console.WriteLine("The library is empty.");
            return;
        }

        Console.WriteLine("Books in forward order:");
        while (current != null)
        {
            Console.WriteLine($"ID={current.BookID}, Title={current.Title}, Author={current.Author}, Genre={current.Genre}, Available={current.IsAvailable}");
            current = current.Next;
        }
    }

    // Method to display all books in reverse order
    public void DisplayBooksReverse()
    {
        BookNode current = tail;

        if (current == null)
        {
            Console.WriteLine("The library is empty.");
            return;
        }

        Console.WriteLine("Books in reverse order:");
        while (current != null)
        {
            Console.WriteLine($"ID={current.BookID}, Title={current.Title}, Author={current.Author}, Genre={current.Genre}, Available={current.IsAvailable}");
            current = current.Previous;
        }
    }

    // Method to count the total number of books in the library
    public int CountBooks()
    {
        return count;
    }
}

// Main program to test the library management system
class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        library.AddBookAtBeginning("Hero academy", "Yogesh singh", "Fiction", 101);
        library.AddBookAtEnd("120", "Indian ", "Dystopian", 102);
        library.AddBookAtPosition("To Kill", "someone", "Fiction", 103, 2);
        library.DisplayBooksForward();
        library.DisplayBooksReverse();
        library.SearchByTitle("1984");
        library.SearchByAuthor("Harper Lee");
        library.UpdateAvailability(102, false);
        library.RemoveBookByID(101);
        library.DisplayBooksForward();
        Console.WriteLine($"Total number of books in the library: {library.CountBooks()}");
    }
}