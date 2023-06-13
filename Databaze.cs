using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnaEasy
{
    class Databaze
    {   /// <summary>
        /// List pojištěný
        /// </summary>
        public List<Pojisteny> pojisteny;
        /// <summary>
        /// Vznik databáze
        /// </summary>
        public Databaze() 
        {
            pojisteny = new List<Pojisteny>();
        }
        /// <summary>
        /// Metoda na přidání pojištěného
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="vek"></param>
        /// <param name="telCislo"></param>
        public void PridejPojisteneho(string jmeno, string prijmeni, int vek, int telCislo)
        {
            pojisteny.Add(new Pojisteny(jmeno, prijmeni, vek, telCislo));
        }
        /// <summary>
        /// Metoda na vypsání pojištěných
        /// </summary>
        public void VypisPojistene()
        {
            foreach(Pojisteny p in pojisteny)
            {
                Console.WriteLine(p);
            }
        }
        /// <summary>
        /// Vyhledání záznamu v pojištěných
        /// </summary>
        /// <param name="pojisteny">Pojištěný</param>
        /// <param name="dleJmena">Hledáme dle jména</param>
        /// <param name="dlePrijmeni">Hledáme dle přijmení</param>
        /// <returns>Vypíše nalezené pojištěné</returns>
        public List<Pojisteny> VyhledejPojisteneho(string jmeno, string prijmeni)
        {
            List<Pojisteny> nalezene = new List<Pojisteny>();
            foreach (Pojisteny p in pojisteny)
            {
                if (p.Jmeno == jmeno && p.Prijmeni == prijmeni) //dle jména a přijmení
                    nalezene.Add(p);
            }
            return nalezene;
        }

    }
}
