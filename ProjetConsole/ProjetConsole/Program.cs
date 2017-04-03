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
            Console.WriteLine(Pers1.Métier.ActivitéProduction);
            Console.ReadKey();
        }
    }
}
