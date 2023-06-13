namespace ZaverecnaEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            // založení evidence pojištěných
            EvidencePojistenych evidence = new EvidencePojistenych();
            // nastavená počáteční hodnota volby
            char volba = '0';
            // hlavní cyklus
            while (volba != '4')
            {
                evidence.UvodniObraz();
                
                //výběr volby
                Console.WriteLine("\nVyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                // reakce na volbu
                switch (volba)
                {
                    case '1':
                        evidence.PridejPojisteneho();
                        break;
                    case '2':
                        evidence.VypisPojistene();
                        break;
                    case '3':
                        evidence.VyhledejPojisteneho();
                        break;
                    case '4':
                        Console.WriteLine("\nProgram ukončíte libovolnou klávesou...");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        break;
                }
                Console.ReadKey();
            }
                
        }
    }
}