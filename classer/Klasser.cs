using System;

namespace classer;

public class Book
{
    // Publika variabler
    public string Name { get; set; }
    public int Pages { get; set; }
    public int CurrentPage { get; private set; } // Börjar på 0, endast läsbar utifrån

    // Konstruktor
    public Book(string name, int pages)
    {
        Name = name;
        Pages = pages;
        CurrentPage = 0; // Startar på sidan 0
    }

    // Metod för att bläddra till nästa sida
    public void TurnPage()
    {
        if (CurrentPage < Pages)
        {
            CurrentPage++;
            Console.WriteLine($"Du har bläddrat till sida {CurrentPage} i boken \"{Name}\".");
        }
        else
        {
            Console.WriteLine($"Du har redan nått slutet av boken \"{Name}\".");
        }
    }
}

