using System;

class Program2
{
    static void Main()
    {
        Console.Write("Mata in ålder: "); // Skriver ut en text i konsolen och ber användaren att mata in sin ålder.
        int Age = int.Parse(Console.ReadLine()); // Läser in användarens input (en sträng) och konverterar den till ett heltal (int).
        Console.Write("Färg: "); // Ber användaren mata in en färg, även om detta värde inte används vidare i programmet.
        if (Age <= 12) { Console.Write("Vit"); }  // Kontrollerar vilken åldersgrupp användaren tillhör och skriver ut motsvarande färg.
        else if (Age >= 13 && Age <= 18)
        {
            Console.Write("Grön");
        }

        else if (Age >= 19 && Age <= 25)
        {
            Console.Write("Röd");
        }
        else if (Age >= 26 && Age <= 99)
        {
            Console.Write("Blå");
        }
        else { Console.Write("Ogiltig ålder!"); } // Om åldern inte passar in i någon av de tidigare kategorierna (t.ex. över 99 eller negativ), skriv ut "Ogiltig ålder!".
    }
}
