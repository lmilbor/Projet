using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Initialisation Métiers
            Métiers ANA = new Métiers("Analyste", "ANA", Activité.DBE | Activité.ARF | Activité.ANF);
            Métiers CDP = new Métiers("Chef de projet", "CDP", Activité.ARF | Activité.ANF | Activité.ART | Activité.TES | Activité.GDP);
            Métiers DEV = new Métiers("Développeur", "DEV", Activité.ANF | Activité.ART | Activité.ANT | Activité.DEV | Activité.TES);
            Métiers DES = new Métiers("Designer", "DES", Activité.ANF | Activité.DES | Activité.INF);
            Métiers TES = new Métiers("Testeur", "TES", Activité.RPT | Activité.TES);
            #endregion

            #region Initialisation Personnes
            Personnes Pers1 = new Personnes("GL", "Genevieve", "LECLERCQ", ANA);
            Personnes Pers2 = new Personnes("AL", "Angèle", "FERRAND", ANA);
            Personnes Pers3 = new Personnes("BN", "Balthazar","NORMAND", CDP);
            Personnes Pers4 = new Personnes("RF", "Raymond", "FISHER", DEV);
            Personnes Pers5 = new Personnes("LB", "Lucien", "BUTLER", DEV);
            Personnes Pers6 = new Personnes("RB", "Roseline", "BEAUMONT", DEV);
            Personnes Pers7 = new Personnes("MW", "Marguerite", "WEBER", DES);
            Personnes Pers8 = new Personnes("HK", "Hilaire", "KLEIN", TES);
            Personnes Pers9 = new Personnes("NP", "Nino", "PALMER", TES);
            #endregion

            #region chargement de fichier

            #endregion

            #region Initialisation Tâches de production
            Taches T1 = new TachesAnnexes {};
            #endregion
            Console.WriteLine(T1.DuréeTravailRéalisé);
            Thread.Sleep(3000);        
            #region Initialisation Tâches Annexes

            #endregion

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
