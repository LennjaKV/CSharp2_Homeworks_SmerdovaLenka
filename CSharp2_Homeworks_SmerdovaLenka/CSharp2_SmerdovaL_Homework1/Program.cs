using System.IO;

namespace CSharp2_SmerdovaL_Homework1
{
    //třetí úkol - Vytvořte třídu Lucistnik, ktera bude mit vlastnost PocetSipu a metodu Vystrel. PocetSipu muze byt nastaven treba na 10.
    //Pokud bude mit dost sipu, napise metoda Vystrel na konzoli text: Vzdy se strefim primo do prostred!
    //Metoda Vystrel uvnitr s kazdym vystrelem snizi pocet sipu.
    internal class Lucistnik
    {
        private int PocetSipu;
        public Lucistnik(int pocetSipu=10)
        {
            PocetSipu = pocetSipu;
        }
        public void Vystrel()
        {
            if (PocetSipu>0)
            {
                Console.WriteLine("Vždy se strefím přímo do prostřed");
                PocetSipu--;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // první úkol - Napište program, který se zeptá na dvě čísla a zobrazí jejich součet.
            Console.WriteLine("Zadejte první číslo: "); 
            double cislo1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte druhé číslo: ");
            double cislo2 = double.Parse(Console.ReadLine());
            double vysledek = cislo1 + cislo2;
            Console.WriteLine($"Výsledek součtu dvou zadaných čísel je: {vysledek}");

            // druhý úkol - Napište program, který se zeptá na počet hvězdiček a potom je v cyklu zobrazí na konzoli.
            Console.WriteLine("Zadejte počet hvězdiček: ");
            double pocetHvezdicek = int.Parse(Console.ReadLine());
            for (int i = 0; i < pocetHvezdicek; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // čtvrtý úkol - Napiste program, ktery vytvori lucistnika a vystreli vsechny sipy.
            Lucistnik RobinHood = new Lucistnik();
            for (int i = 0; i < 10; i++)
            {
                RobinHood.Vystrel();
            }

            // pátý úkol - Napište program, který umožní hádat číslo. Zeptá se, jaké číslo si myslím. Podle toho, jaké číslo se zadá, napíše, jestli je číslo větší nebo menší a umožní hádat tak dlouho, dokud se uživatel netrefí:
            Console.WriteLine("Myslim si číslo. Zadej svůj tip: ");
            int zadanyTip = int.Parse(Console.ReadLine());
            Random generator = new Random();
            int nahodneCislo = generator.Next();

            while (nahodneCislo != zadanyTip)
            {
                if (zadanyTip < nahodneCislo)
                {
                    Console.WriteLine("Neuhodl jsi. Hádané číslo je větší");
                }
                else
                {
                    Console.WriteLine("Neuhodl jsi. Hádané číslo je menší");
                }
                Console.WriteLine("Hádej znovu: ");
                zadanyTip = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Paráda. Uhodl jsi");
        }
    }
}