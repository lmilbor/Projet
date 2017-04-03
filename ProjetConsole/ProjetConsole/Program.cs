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

            #region Initialisation ListeMétiers
            Métiers ANA = new Métiers("Analyste", "ANA", Activité.DBE | Activité.ARF | Activité.ANF);
            Métiers CDP = new Métiers("Chef de projet", "CDP", Activité.ARF | Activité.ANF | Activité.ART | Activité.TES | Activité.GDP);
            Métiers DEV = new Métiers("Développeur", "DEV", Activité.ANF | Activité.ART | Activité.ANT | Activité.DEV | Activité.TES);
            Métiers DES = new Métiers("Designer", "DES", Activité.ANF | Activité.DES | Activité.INF);
            Métiers TES = new Métiers("Testeur", "TES", Activité.RPT | Activité.TES);
            List<Métiers> listeMétiers = new List<Métiers> { ANA, CDP, DEV, DES, TES };
            #endregion

            #region Initialisation ListePersonnes
            Personnes GL = new Personnes("GL", "Genevieve", "LECLERCQ", ANA);
            Personnes AL = new Personnes("AL", "Angèle", "FERRAND", ANA);
            Personnes BN = new Personnes("BN", "Balthazar", "NORMAND", CDP);
            Personnes RF = new Personnes("RF", "Raymond", "FISHER", DEV);
            Personnes LB = new Personnes("LB", "Lucien", "BUTLER", DEV);
            Personnes RB = new Personnes("RB", "Roseline", "BEAUMONT", DEV);
            Personnes MW = new Personnes("MW", "Marguerite", "WEBER", DES);
            Personnes HK = new Personnes("HK", "Hilaire", "KLEIN", TES);
            Personnes NP = new Personnes("NP", "Nino", "PALMER", TES);
            List<Personnes> listePersonnes = new List<Personnes> { GL, AL, BN, RF, LB, RB, MW, HK, NP };
            #endregion

            // On charge la liste des personnes et des métiers dans un DAL
            DAL genomica = new DAL(listeMétiers, listePersonnes);

            #region Initialisation Tâches annexe
            Dictionary<string, TachesAnnexes> tacheAnnexes = new Dictionary<string, TachesAnnexes>();
            bool nouvelleTache = true;
            string temp;
            while (nouvelleTache)
            {
                Console.WriteLine("Bonjour, avez vous de nouvelles activités annexes (oui ou non).");
                temp = Console.ReadLine();
                if (temp.CompareTo("non") != 0 && temp.CompareTo("oui") != 0)
                {
                    Console.WriteLine("Veuillez répondre par oui ou par non.");
                }
                else if (temp.CompareTo("non") == 0)
                {
                    nouvelleTache = false;
                    Console.Clear();
                    tacheAnnexes.OrderBy(k => k.Key);
                    foreach (var item in tacheAnnexes)
                    {
                        Console.WriteLine("code : {0}, {1}", item.Key, item.Value);
                    }
                }
                else
                {
                    Console.WriteLine("Veuillez saisir une nouvelle activité annexe. (libellé)");
                    TachesAnnexes tempTache = new TachesAnnexes(Console.ReadLine());
                    tacheAnnexes.Add(tempTache.Code, tempTache);
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}
