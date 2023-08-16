// IHR NAME
// IHRE KLASSE

/// <summary>
/// SAS Kontrollstrukturen
/// Arbeitsauftrag 3 - Aufgabe 1
/// Die kleinere Zahl
/// </summary>


Aufgabe_1.Aufgabe1();

public static class Aufgabe_1
{
    public static void Aufgabe1()
    {

        //Diese Zeile mit Ihrem Quellcode ersetzen
        Console.WriteLine("Die kleinere Zahl");

        Console.WriteLine("Geben Sie die erste Zahl ein:");

        double Zahl1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Geben Sie die zweite Zahl ein:");

        double Zahl2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("------------------");

        if (Zahl1==Zahl2)
        {
            Console.WriteLine("Die kleinere Zahl ist: Gleicher Wert");
        }
        else if (Zahl1>Zahl2)
        {
            Console.WriteLine("Die kleinere Zahl ist: {0}",Zahl2);
        }
        else
        {
            Console.WriteLine("Die kleinere Zahl ist: {0}",Zahl1);
        }



    }
}
