using System;

class Movie {
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public Movie next;
    public Movie prev;

    public Movie(string title, string director, int year, double rating) {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        next = null;
        prev = null;
    }
}

class MovieFunctions {
    private Movie head;
    private Movie tail;

    // Add movie at the beginning
    public void AddStart(string title, string director, int year, double rating) {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null) {
            head = tail = newMovie;
        } else {
            newMovie.next = head;
            head.prev = newMovie;
            head = newMovie;
        }
    }

    // Add movie at the end
    public void AddLast(string title, string director, int year, double rating) {
        Movie newMovie = new Movie(title, director, year, rating);
        if (tail == null) {
            head = tail = newMovie;
        } else {
            tail.next = newMovie;
            newMovie.prev = tail;
            tail = newMovie;
        }
    }

    // Add movie at a specific position
    public void AddPosition(string title, string director, int year, double rating, int position) {
        if (position < 1) {
            Console.WriteLine("Invalid position!");
            return;
        }

        Movie newMovie = new Movie(title, director, year, rating);
        if (position == 1) { // Insert at head
            AddStart(title, director, year, rating);
            return;
        }

        Movie temp = head;
        for (int i = 1; temp != null && i < position - 1; i++) {
            temp = temp.next;
        }

        if (temp == null) {
            Console.WriteLine("Position out of range!");
            return;
        }

        newMovie.next = temp.next;
        newMovie.prev = temp;
        if (temp.next != null) {
            temp.next.prev = newMovie;
        } else {
            tail = newMovie;
        }
        temp.next = newMovie;
    }

    // Remove movie by Title
    public void RemoveByTitle(string title) {
        if (head == null) {
            Console.WriteLine("No movies found!");
            return;
        }

        Movie temp = head;

        while (temp != null && temp.Title != title) {
            temp = temp.next;
        }

        if (temp == null) {
            Console.WriteLine("Movie not found!");
            return;
        }

        if (temp == head) {
            head = temp.next;
            if (head != null) head.prev = null;
        } else if (temp == tail) {
            tail = temp.prev;
            if (tail != null) tail.next = null;
        } else {
            temp.prev.next = temp.next;
            temp.next.prev = temp.prev;
        }

        Console.WriteLine($"Movie '{title}' removed successfully.");
    }

    // Search movie by Director
    public void SearchByDirector(string director) {
        Movie temp = head;
        bool found = false;

        while (temp != null) {
            if (temp.Director == director) {
                Console.WriteLine($"Found - Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
                found = true;
            }
            temp = temp.next;
        }

        if (!found) {
            Console.WriteLine("No movies found for the given director.");
        }
    }

    // Search movie by Rating
    public void SearchByRating(double rating) {
        Movie temp = head;
        bool found = false;

        while (temp != null) {
            if (temp.Rating == rating) {
                Console.WriteLine($"Found - Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
                found = true;
            }
            temp = temp.next;
        }

        if (!found) {
            Console.WriteLine("No movies found with the given rating.");
        }
    }

    // Update movie rating by Title
    public void UpdateRating(string title, double newRating) {
        Movie temp = head;
        while (temp != null) {
            if (temp.Title == title) {
                temp.Rating = newRating;
                Console.WriteLine($"Updated - Title: {temp.Title}, New Rating: {temp.Rating}");
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Movie not found!");
    }

    // Display all movies in forward order
    public void DisplayForward() {
        Movie temp = head;
        if (temp == null) {
            Console.WriteLine("No movies available.");
            return;
        }
        Console.WriteLine("Movies List (Forward):");
        while (temp != null) {
            Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = temp.next;
        }
    }

    // Display all movies in reverse order
    public void DisplayReverse() {
        Movie temp = tail;
        if (temp == null) {
            Console.WriteLine("No movies available.");
            return;
        }
        Console.WriteLine("Movies List (Reverse):");
        while (temp != null) {
            Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = temp.prev;
        }
    }
}

class DoublyLinkedList {
    static void Main() {
        MovieFunctions movieList = new MovieFunctions();

        // Adding movie records
        movieList.AddStart("Inception", "Christopher Nolan", 2010, 8.8);
        movieList.AddLast("Interstellar", "Christopher Nolan", 2014, 8.6);
        movieList.AddLast("The Matrix", "Lana Wachowski", 1999, 8.7);
        movieList.AddPosition("Avatar", "James Cameron", 2009, 7.9, 2);

        // Display all records
        movieList.DisplayForward();
        movieList.DisplayReverse();

        // Searching for a movie
        Console.WriteLine("\nSearching for movies by 'Christopher Nolan':");
        movieList.SearchByDirector("Christopher Nolan");

        Console.WriteLine("\nSearching for movies with rating 8.6:");
        movieList.SearchByRating(8.6);

        // Updating rating
        Console.WriteLine("\nUpdating rating for 'Inception':");
        movieList.UpdateRating("Inception", 9.0);

        // Display all records after update
        movieList.DisplayForward();

        // Removing a movie
        Console.WriteLine("\nRemoving 'Avatar':");
        movieList.RemoveByTitle("Avatar");

        // Display final list
        movieList.DisplayForward();
    }
}
