namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            startEan();
        } // Main Ende
        private static void startEan()
        {
            bool ende = false;
            string? e = "a";

            while (!ende)
            {
                ean();
                Console.WriteLine("Program beenden (e)?");
                e = Console.ReadLine();
                if (e != "e") { ende = false; } else { ende = true; }

            }
        }
        private static void ean()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Büromaterials.Hello("Wilkommen in Ean Checkkonsole");
            Büromaterials.Hello("Bitte geben Sie  die EAN ein");
            string? eanNr = Console.ReadLine();

            while (eanNr.Length != 13)
            {
                Console.Write("Bitte korrekte Daten eingeben: ");
                eanNr = Console.ReadLine();
                if ((eanNr == null))
                {
                    Console.WriteLine("Wieder shief");
                    return;
                }
            }

            int summe = 0;

            //char arrMitZahl = new [13] char ;
            for (int i = 0; i < eanNr.Length; i++)
            {
                // alternative 1
                char cZeichnen = eanNr[i];
                string zeichnen = eanNr[i].ToString();

                // alternative 2
                //zeichnen = eanNr.Substring(i, 1);

                int ziffer = Convert.ToInt32(zeichnen);

                if (i % 2 == 1) { summe = summe + 3 * ziffer; } else summe = summe + ziffer;

            }
            if (summe % 10 == 0) Console.WriteLine("Die EAN ist gültig (" + summe + ")");
            else
                Console.WriteLine("Die EAN ist gültig");


            
        }
    
    } // Klass Ende

    internal class Büromaterials
    {  
        
      
        public static void Hello (string str){ Console.WriteLine(str); }
    } // Ende Büromaterials
} // namespace Ende
