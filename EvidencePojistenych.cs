using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnaEasy
{
    class EvidencePojistenych
    {
        /// <summary>
        /// Nastavení konstruktorů pro Evidenci pojištěných
        /// </summary>
        private Databaze databaze;
        private string jmeno;
        private string prijmeni;
        private string pojisteny;
        private int vek;
        private int telCislo;
        private bool dleJmena;
        private bool dlePrijmeni;

        public EvidencePojistenych()
        {
            databaze = new Databaze();
        }
        /// <summary>
        /// Metoda na přidání pojištěného, kde uživatel zadá hodnoty na vstupu
        /// </summary>
        public void PridejPojisteneho()
        {
            Console.WriteLine("\nZadejte jméno pojištěného: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte přijmení: ");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("Zadejte telefonní číslo: ");
            while (!int.TryParse(Console.ReadLine(), out telCislo))
            {
                Console.WriteLine("\nChyba! Zadejte telefonní číslo znovu...");
            }
            Console.WriteLine("Zadejte věk: ");
            while(!int.TryParse(Console.ReadLine(), out vek))
            {
                Console.WriteLine("\nChyba! Zadejte věk znovu...");
            }
            databaze.PridejPojisteneho(jmeno, prijmeni, vek, telCislo);
            Console.WriteLine("\nData byla uložena. Pokračujte libovolnou klávesou...");
        }
        /// <summary>
        /// Metoda vypsání pojištěných
        /// </summary>
        public void VypisPojistene()
        {
            Console.WriteLine();
            databaze.VypisPojistene();
            Console.WriteLine("\nPokračujte libovolnou klávesou...");
        }
        /// <summary>
        /// Metoda na vyhledávání pojištěných
        /// </summary>
        public void VyhledejPojisteneho()
        {
            // Zadání data uživatelem
            Console.WriteLine("\nZadejte jméno pojištěného: ");
            string jmeno2 = Console.ReadLine();
            Console.WriteLine("Zadejte přijmení: ");
            string prijmeni2 = Console.ReadLine();

            // Vyhledání pojištěných
            List<Pojisteny> pojisteny = databaze.VyhledejPojisteneho(jmeno2, prijmeni2);
            // Výpis pojištěných
            if (pojisteny.Count() > 0)
            {
                Console.WriteLine();
                foreach (Pojisteny p in pojisteny)
                    Console.WriteLine(p);
                Console.WriteLine("\nPokračujte libovolnou klávesou...");
            }
            else
            {
                // Nenalezeno
                Console.WriteLine("\nNebyli nalezeni žádní pojištění. Pokračujte libovolnou klávesou...");
            }
        }
        /// <summary>
        /// Metoda na vypsání úvodní obrazovky 
        /// </summary>
        public void UvodniObraz()
        {
            //výpis obrazovky
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("-------------------------");

        }
    }
}
