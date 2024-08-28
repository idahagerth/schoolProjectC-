using System;

class Program4
{
    static void Main()
    {
        Console.Write("Mata in ett tal: "); // Skriver ut en text i konsolen och ber användaren att mata in ett tal.
        int Tal1 = int.Parse(Console.ReadLine());

        if (Tal1 % 7 == 0) // Kontrollerar om talet är jämnt delbart med 7 genom att använda modulusoperatorn (%).
                           // Om resten av divisionen med 7 är 0, är talet jämnt delbart med 7.
        {
            Console.Write("Talet är jämnt delbart med 7! "); // Om talet är jämnt delbart med 7, skriv ut detta meddelande.
        }
        else
        {
            Console.Write($"Talet är ej jämnt delbart med 7. Resten blir: {Tal1 % 7}");  // Om talet inte är jämnt delbart med 7, skriv ut att det inte är det samt visa resten av divisionen.

        }

    }
}