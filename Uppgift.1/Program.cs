using System;

class Program
{
    static void Main() // Huvudmetoden där programmet börjar exekveras.
    {
        Console.Write("Skriv in mönstredjupet: "); // Skriver ut en text i konsolen och ber användaren att mata in ett värde för mönsterdjupet.
        float monsterdjupet = float.Parse(Console.ReadLine()); // Läser in användarens input (en sträng) och konverterar den till ett flyttal (float).
        if (monsterdjupet < 1.6) // Kontrollerar om det inmatade mönsterdjupet är mindre än 1,6 mm.
        {
            Console.Write("Olagligt däck!"); // Om mönsterdjupet är mindre än 1,6 mm, skriver programmet ut att däcket är olagligt.
        }
        else
        {
            Console.WriteLine("Lagligt däck!"); // Om mönsterdjupet är 1,6 mm eller större, skriver programmet ut att däcket är lagligt.
            Console.Write($"{monsterdjupet - 1.6} mm kvar tills olagligt"); // Beräknar skillnaden mellan mönsterdjupet och den lagliga gränsen (1,6 mm) och skriver ut hur mycket mönsterdjup som är kvar tills däcket blir olagligt.
        }
    }
}
