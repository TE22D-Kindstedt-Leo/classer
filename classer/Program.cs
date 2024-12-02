using System;
namespace classer;
using System;

public class Program
{
    public static void Main()
    {
        // Skapa tre instanser av Book-klassen
        Book book1 = new Book("Mysteriet på blå tåget", 250);
        Book book2 = new Book("C#-programmering för nybörjare", 320);
        Book book3 = new Book("Universums mysterier", 450);

        // Testa TurnPage-metoden
        Console.WriteLine($"Bok 1: {book1.Name}, Totalt antal sidor: {book1.Pages}, Nuvarande sida: {book1.CurrentPage}");
        book1.TurnPage(); // Bläddra till sida 1
        book1.TurnPage(); // Bläddra till sida 2
        Console.WriteLine($"Nuvarande sida i \"{book1.Name}\": {book1.CurrentPage}");
        Console.ReadLine();
        
    }
}