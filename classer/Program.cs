using System;

class Book
{
    // Publika variabler
    public string Name { get; set; }
    public int Pages { get; set; }

    // Konstruktor
    public Book(string name, int pages)
    {
        Name = name;
        Pages = pages;
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book("Mysteriet på blå tåget", 250);
        Book book2 = new Book("C#-programmering för nybörjare", 320);
        Book book3 = new Book("Universums mysterier", 450);

        Console.WriteLine($"Bok 1: {book1.Name}, Antal sidor: {book1.Pages}");
        Console.WriteLine($"Bok 2: {book2.Name}, Antal sidor: {book2.Pages}");
        Console.WriteLine($"Bok 3: {book3.Name}, Antal sidor: {book3.Pages}");
        Console.ReadLine();
        
    }
}

