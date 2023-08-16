// IHR NAME
// IHRE KLASSE

/// <summary>
/// SAS Kontrollstrukturen
/// Arbeitsauftrag 3 - Aufgabe 2
/// Herzinfarkt-Risiko-Test
/// </summary>


Aufgabe_2.Aufgabe2();

public static class Aufgabe_2
{
    public static void Aufgabe2()
    {

        //Diese Zeile mit Ihrem Quellcode ersetzen
        int Risiko = 0;
        Console.WriteLine("Herinfarkt-Risiko-Test");

        Console.WriteLine("Sind Sie übergewichtig?(true/false):");
        bool Übergewicht = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Haben Sie häufiger Stress?(true/false):");
        bool Stress = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("------------------");

        if (Übergewicht == true)

        {

            if (Stress == true)
            {
                Risiko = 62;
            }
            else
            {
                Risiko = 18;
            }


        }
        else
        {
            if (Stress == true)
            {
                Risiko = 15;
            }
            else
            {
                Risiko = 5;
            }
        }

        Console.WriteLine("Ihr Risiko für einen Herzinfarkt liegt bei: {0}%", Risiko);




    }
}
