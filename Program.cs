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
                Console.WriteLine("2: Verflixte 4");
                Console.WriteLine("Palindrom?");
                Console.Write("Auswahl:");
                auswahl = Console.ReadLine();

                switch (auswahl)
                {
                    case "1":
                        // Aufgabe: Die Summe aller Brüche 1/a bis
                        // 1/b berechnen.
                        int a, b;
                        double ergebnis = 0;
                        Console.Write("a=?, (a!=0):");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("b=");
                        b = Convert.ToInt32(Console.ReadLine());

                        if (a > b)
                        {
                            int c = a;
                            a = b;
                            b = c;
                        }

                        for (int i = a; i <= b; i++)
                        {
                            ergebnis += 1.0 / i; //ergebnis = ergebnis + 1/i
                        }

                        Console.WriteLine($"Die Summe der Brüche von 1/{a} bis 1/{b} ergibt {Math.Round(ergebnis,4)}.");
                        
                        break;
                    case "2":
                        // Aufgabe: Alle ganzen zahlen bis zum Max m sollen aufsteigend
                        // ausgegeben werden. Jede Zahl die die Ziffer 4 enthält oder durch
                        // vier teilbar ist wird dabei ersetzt durch "--4--".
                        int max;
                        Console.Write("Maximum=");
                        max = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i<=max; i++)
                        {
                            if(i % 4 == 0 || i.ToString().Contains('4'))
                            {
                                Console.WriteLine("--4--");
                            }
                            else Console.WriteLine(i);
                        }

                        break;
                    case "3":
                        // Aufgabe: Eine Eingabe daraufhin überprüfen, ob sie ein
                        // Palindrom ist.
                        Console.WriteLine("Palindromprüfung.");
                        Console.Write("Wort eingeben: ");
                        string wort = Console.ReadLine();

                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe.");
                        break;
                }

                Console.WriteLine("Neue Auswahl? (j/n)");
                auswahl = Console.ReadLine();
            } while (auswahl=="j");
        }
    }
}