using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisation des métiers.
            Métiers ANA = new Métiers("Analyste", Activité.DBE | Activité.ARF | Activité.ANF);
            Métiers CDP = new Métiers("Chef de projet", Activité.ARF | Activité.ANF | Activité.ART | Activité.TES | Activité.GDP);
            Métiers DEV = new Métiers("Développeur", Activité.ANF | Activité.ART | Activité.ANT | Activité.DEV | Activité.TES);
            Métiers DES = new Métiers("Designer", Activité.ANF | Activité.DES | Activité.INF);
            Métiers TES = new Métiers("Testeur", Activité.RPT | Activité.TES);

            Personnes Pers1 = new Personnes("GL", "Genevieve", "LECLERCQ", ANA);
            Personnes Pers2 = new Personnes("AL", "Angèle", "FERRAND", ANA);
            Personnes Pers3 = new Personnes("BN", "Genevieve", "LECLERCQ", ANA);
            Personnes Pers4 = new Personnes("RF", "Genevieve", "LECLERCQ", ANA);
            Personnes Pers5 = new Personnes("LB", "Genevieve", "LECLERCQ", ANA);
            Personnes Pers6 = new Personnes("RB", "Genevieve", "LECLERCQ", ANA);
            Personnes Pers7 = new Personnes("MW", "Genevieve", "LECLERCQ", ANA);
            Personnes Pers8 = new Personnes("HK", "Genevieve", "LECLERCQ", ANA);
            Personnes Pers9 = new Personnes("NP", "Genevieve", "LECLERCQ", ANA);

            Console.WriteLine(Pers1.Métier.ActivitéProduction);
            Console.ReadKey();
        }
    }
}
