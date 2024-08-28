using System;

class Program5
{
    static void Main()
    {
        Console.Write("Åmål: "); // Skriver ut en text i konsolen och ber användaren att mata in temperaturen i Åmål.
        int Stad1 = int.Parse(Console.ReadLine());

        Console.Write("Östersund: "); // Skriver ut en text i konsolen och ber användaren att mata in temperaturen i Östersund.
        int Stad2 = int.Parse(Console.ReadLine());

        if (Stad1 < Stad2)
        {
            Console.Write("Åmål är kallast!");
        }
        else if (Stad2 < Stad1)
        {
            Console.Write("Östersund är kallast!");
        }
        else
        {
            Console.WriteLine("Det är lika jävligt på båda ställerna!"); // Om temperaturerna är lika, skriv ut att det är lika kallt på båda ställena.
        }
    }
}