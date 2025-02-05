using System;
using System.Collections.Generic;

// Book class representing individual books
class Book
{
    // Properties for book title and author
    public string Title { get; set; }
    public string Author { get; set; }

    // Constructor to initialize book details
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    // Method to display book details
    public void DisplayBook()
    {
        Console.WriteLine("Book Title: " + Title + " | Author: " + Author);
    }
}

// Library class containing a collection of books
class Library
{
    // Property for library name
    public string LibraryName { get; set; }

    // List to store books
    public List<Book> Books { get; private set; }

    // Constructor to initialize library name and book list
    public Library(string libraryName)
    {
        LibraryName = libraryName;
        Books = new List<Book>();
    }

    // Method to add a book to the library
    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine("Book " + book.Title + " added to " + LibraryName);
    }

    // Method to display books available in the library
    public void DisplayBooks()
    {
        Console.WriteLine("Books available in " + LibraryName + ":");

        if (Books.Count == 0)
        {
            Console.WriteLine("No books available");
        }
        else
        {
            foreach (Book book in Books)
            {
                book.DisplayBook();
            }
        }
    }
}

// Main program
class Program
{
    static void Main()
    {
        // Creating two libraries
        Library nationalLibrary = new Library("National Library");
        Library universityLibrary = new Library("University Library");

        // Creating popular Indian books
        Book bookOne = new Book("Ramcharitmanas", "Tulsidas");
        Book bookTwo = new Book("Mahabharata", "Vyasa");
        Book bookThree = new Book("Bhagavad Gita", "Krishna written by Vyasa");
        Book bookFour = new Book("Panchatantra", "Vishnu Sharma");
        Book bookFive = new Book("Mudrarakshasa", "Vishakhadatta");
        Book bookSix = new Book("Abhijnanasakuntalam", "Kalidasa");

        // Adding books to the National Library
        nationalLibrary.AddBook(bookOne);
        nationalLibrary.AddBook(bookTwo);
        nationalLibrary.AddBook(bookThree);

        // Adding books to the University Library
        universityLibrary.AddBook(bookFour);
        universityLibrary.AddBook(bookFive);
        universityLibrary.AddBook(bookSix);

        // Displaying books in each library
        nationalLibrary.DisplayBooks();
        universityLibrary.DisplayBooks();
    }
}