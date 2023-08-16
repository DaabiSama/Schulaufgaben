// IHR NAME
// IHRE KLASSE

/// <summary>
/// SAS Kontrollstrukturen
/// Arbeitsauftrag 3 - Aufgabe3
/// Rechner
/// </summary>


Aufgabe_3.Aufgabe3();

public static class Aufgabe_3
{
    public static void Aufgabe3()
    {

        //Diese Zeile mit Ihrem Quellcode ersetzen
        Console.WriteLine("Rechner");

        Console.WriteLine("Geben Sie den ersten Wert ein");
        double Zahl1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Geben Sie den zweiten Wert ein");
        double Zahl2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("1 Addition");
        Console.WriteLine("2 Subtraktion");
        Console.WriteLine("3 Mulitplikation");
        Console.WriteLine("4 Division");
        Console.WriteLine("5 Potenz");
        Console.WriteLine("Wählen sie einen operator");

        string Operator = Console.ReadLine();

        Console.WriteLine("------------------");


        switch (Operator)

        {
            case "1":
                Console.WriteLine("Ihr Ergebnis ist: {0}", Zahl1 + Zahl2);
                break;

            case "2":
                Console.WriteLine("Ihr Ergebnis ist: {0}", Zahl1 - Zahl2);
                break;

            case "3":
                Console.WriteLine("Ihr Ergebnis ist: {0}", Zahl1 * Zahl2);
                break;

            case "4":
                Console.WriteLine("Ihr Ergebnis ist: {0}", Zahl1 / Zahl2);
                break;

            case "5":
                Console.WriteLine("Ihr Ergebnis ist: {0}", Math.Pow(Zahl1,Zahl2));
                break;




        }



    }
}
