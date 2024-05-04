namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.
            DateTime aktualni = DateTime.Now;
            Console.WriteLine(aktualni);

            // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.
            DateTime datumNarozeni = new DateTime(1987, 7, 7);
            TimeSpan kolikDni = aktualni - datumNarozeni;
            Console.WriteLine($"Od mého narození uteklo už {kolikDni.Days} dní.");

            // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.
            List<string> plysaci = new List<string>
            {
                "medvidek",
                "dinosaur",
                "ponik",
                "princezna",
                "kralicek"
            };
            foreach (string p in plysaci)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            // 4. Smaž z tohoto listu libovolnou hodnotu.
            plysaci.Remove("ponik");
            foreach (string p in plysaci)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains
            Console.WriteLine($"Tento list obsahuje medvídka: {plysaci.Contains("medvidek")}");
            Console.WriteLine($"Tento list obsahuje včeličku: {plysaci.Contains("vcelicka")}");
            Console.WriteLine();

            // 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").
            Console.Write($"V mém listu je počet prvků: {plysaci.Count}: ");
            foreach (string p in plysaci)
            {
                Console.Write($"{p}, ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).
            Dictionary<string, int> nakupniSeznam = new Dictionary<string, int>();
            nakupniSeznam.Add("rohlik", 3);
            nakupniSeznam.Add("jablko", 8);
            nakupniSeznam.Add("maslo", 56);
            nakupniSeznam.Add("olej", 48);

            foreach (KeyValuePair<string, int> item in nakupniSeznam)
            {
                Console.WriteLine("V nákupním seznamu máme: " + item.Key + "\t cena je: " + item.Value+ "Kč.");
            }

            Console.WriteLine();

            // 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.
            if (nakupniSeznam.ContainsKey("jablko"))
            {
                Console.WriteLine($"Cena jablka je: {nakupniSeznam["jablko"]} Kč.");
            }
            else
            {
                Console.WriteLine("Tato potravina v nákupním seznamu není.");
            }
            Console.WriteLine();

            // 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.
            nakupniSeznam["rohlik"] *= 2;
            Console.WriteLine($"Cena rohliku je nyni: {nakupniSeznam["rohlik"]} Kč.");
        }

    }
}

