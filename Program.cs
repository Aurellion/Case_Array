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
                Console.WriteLine("3: Palindrom?");
                Console.WriteLine("4: Arrays");
                Console.WriteLine("5: Teilbarkeit");
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

                        Console.WriteLine($"Die Summe der Brüche von 1/{a} bis 1/{b} ergibt {Math.Round(ergebnis, 4)}.");

                        break;
                    case "2":
                        // Aufgabe: Alle ganzen zahlen bis zum Max m sollen aufsteigend
                        // ausgegeben werden. Jede Zahl die die Ziffer 4 enthält oder durch
                        // vier teilbar ist wird dabei ersetzt durch "--4--".
                        int max;
                        Console.Write("Maximum=");
                        max = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= max; i++)
                        {
                            if (i % 4 == 0 || i.ToString().Contains('4'))
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
                        string umgekehrtesWort = "";


                        for (int i = wort.Length - 1; i >= 0; i--)
                        {
                            umgekehrtesWort += wort[i];
                        }
                        if (wort.ToLower() == umgekehrtesWort.ToLower())
                        {
                            Console.WriteLine($"{wort} ist ein Palindrom.");
                        }
                        else
                        {
                            Console.WriteLine("{0} ist kein Palindrom.", wort);
                        }
                        break;
                    case "4":
                        //Array Deklaration:
                        //Variante 1
                        string[] studenten = new string[5];

                        studenten[0] = "Jonas";
                        studenten[1] = "Katherina";
                        studenten[2] = "Louis";
                        studenten[3] = "Max";
                        studenten[4] = "Nia";

                        //Variante 2
                        string[] Bäume = new string[] { "Ahorn", "Buche", "Birke" };

                        //Variante 3
                        string[] Tiere = { "Alpaka", "Bär", "Chameleon" };

                        //Variante 4
                        string[] test = new string[10];

                        //List Deklaration:
                        //Variante 1
                        List<string> list = new List<string>();

                        //Variante 2
                        List<string> s = new List<string>(5);

                        //Variante 3
                        List<string> TierListe = new List<string> {"Dachs", "Elefant"};

                        //Variante 4*
                        List<string> Bäume2 = new List<string>(Bäume);

                        Bäume2.Add("Hasel");
                        


                        break;
                    case "5":
                        Console.WriteLine("Zahl auf Teilbarkeit überprüfen.");
                        Console.Write("Zahl eingeben:");
                        int zahl = Convert.ToInt32(Console.ReadLine());
                        int[] teiler = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        for (int i = 0; i < teiler.Length; i++)
                        {
                            if( zahl % teiler[i] == 0)
                            {
                                Console.WriteLine($"{zahl} ist durch {teiler[i]} teilbar.");
                            }
                        }
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