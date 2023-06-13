using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnaEasy
{
    class Pojisteny
    {
        /// <summary>
        /// Nastavení getterů a setterů pro pojištěného
        /// </summary>
        public string Jmeno {get; set;}
        public string Prijmeni { get; set;}
        public int Vek { get; set;}
        public int TelCislo { get; set;}
        /// <summary>
        /// Parametry co bere pojištěný
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="vek"></param>
        /// <param name="telCislo"></param>
        public Pojisteny(string jmeno, string prijmeni, int vek, int telCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelCislo = telCislo;
        }
        /// <summary>
        /// Výpis pojištěného přes ToString()
        /// </summary>
        /// <returns>Údaje o pojištěném</returns>
        public override string ToString() 
        {
            return Jmeno + " " + Prijmeni + " " + Vek + " " + TelCislo;
        }
    }
}
