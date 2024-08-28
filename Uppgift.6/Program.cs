using System;

class Program6
{
    static void Main()
    {
        Console.Write("Ange temperatur för Östersund: ");  // Skriver ut en text i konsolen och ber användaren att mata in temperaturen för Östersund.
        int ostersund = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ange temperatur för Åmål: ");
        int amal = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ange temperatur för Arboga: ");
        int arboga = Convert.ToInt32(Console.ReadLine());
        if (ostersund < amal && ostersund < arboga) // Jämför temperaturerna för att avgöra vilken stad som är kallast.
        {
            Console.WriteLine("Det är kallast i Östersund");
        }
        else if (amal < ostersund && amal < arboga)
        {
            Console.WriteLine("Det är kallast i Åmål");
        }
        else
        {
            Console.WriteLine("Det är kallast i Arboga"); // Om ingen av de tidigare villkoren är uppfyllda, innebär det att temperaturen i Arboga är lägst, och programmet skriver ut att det är kallast i Arboga.
        }
    }

}