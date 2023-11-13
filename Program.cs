namespace Case_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Zufallszahl = rnd.Next(1,7);
            string auswahl;
            string wiederholung;

            do
            {
                Console.WriteLine("Auswahlmenü:");
                Console.WriteLine("1: Summe der Brüche 1/a bis 1/b");

                Console.Write("Auswahl:");
                auswahl = Console.ReadLine();

                switch (auswahl)
                {
                    case "1":
                        // Aufgabe: Die Summe aller Brüche 1/a bis
                        // 1/b berechnen.

                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe.")
                        break;
                }

                Console.WriteLine("Neue Auswahl? (j/n)");
                auswahl = Console.ReadLine();
            } while (auswahl=="j");
        }
    }
}