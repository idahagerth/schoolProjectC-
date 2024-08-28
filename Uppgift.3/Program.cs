using System;

class Program3
{
    static void Main()
    {
        Console.Write("Mata in tal 1: "); // Skriver ut en text i konsolen och ber användaren att mata in det första talet.
        int Tal1 = int.Parse(Console.ReadLine());

        Console.Write("Mata in tal 2: "); // Skriver ut en text i konsolen och ber användaren att mata in det andra talet.
        int Tal2 = int.Parse(Console.ReadLine());

        if (Tal1 > Tal2)      // Kontrollerar om det första talet är större än det andra.
        {
            Console.Write($"Tal 1 var störst: {Tal1}");
        }
        else if (Tal2 > Tal1)
        {
            Console.Write($"Tal 2 var störst: {Tal2}");
        }
        else
        {
            Console.WriteLine("Talen var lika!");  // Om de två talen är lika stora, skriv ut att talen är lika.
        }

    }
}

