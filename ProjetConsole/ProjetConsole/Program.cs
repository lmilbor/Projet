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
            // Instantiation de la liste des métiers
            Métiers ANA = new Métiers("Analyste", "ANA", Activités.DBE | Activités.ARF | Activités.ANF);
            Métiers CDP = new Métiers("Chef de projet", "CDP", Activités.ARF | Activités.ANF | Activités.ART | Activités.TES | Activités.GDP);
            Métiers DEV = new Métiers("Développeur", "DEV", Activités.ANF | Activités.ART | Activités.ANT | Activités.DEV | Activités.TES);
            Métiers DES = new Métiers("Designer", "DES", Activités.ANF | Activités.DES | Activités.INF);
            Métiers TES = new Métiers("Testeur", "TES", Activités.RPT | Activités.TES);
            List<Métiers> listeMétiers = new List<Métiers> { ANA, CDP, DEV, DES, TES };
            #endregion

            #region Initialisation ListePersonnes
            // Instantiation de la liste des personnes
            Personnes GL = new Personnes("GL", "Genevieve", "LECLERCQ", ANA);
            Personnes AF = new Personnes("AF", "Angèle", "FERRAND", ANA);
            Personnes BN = new Personnes("BN", "Balthazar", "NORMAND", CDP);
            Personnes RF = new Personnes("RF", "Raymond", "FISHER", DEV);
            Personnes LB = new Personnes("LB", "Lucien", "BUTLER", DEV);
            Personnes RB = new Personnes("RB", "Roseline", "BEAUMONT", DEV);
            Personnes MW = new Personnes("MW", "Marguerite", "WEBER", DES);
            Personnes HK = new Personnes("HK", "Hilaire", "KLEIN", TES);
            Personnes NP = new Personnes("NP", "Nino", "PALMER", TES);

            // Création d'un Dictionnaire contenant la liste des personnes et dont la clé sont les initiales
            Dictionary<string, Personnes> listePersonnes = new Dictionary<string, Personnes> {};
            listePersonnes.Add(GL.Code, GL);
            listePersonnes.Add(AF.Code, AF);
            listePersonnes.Add(BN.Code, BN);
            listePersonnes.Add(RF.Code, RF);
            listePersonnes.Add(LB.Code, LB);
            listePersonnes.Add(RB.Code, RB);
            listePersonnes.Add(MW.Code, MW);
            listePersonnes.Add(HK.Code, HK);
            listePersonnes.Add(NP.Code, NP);
            #endregion

            // On charge la liste des personnes et des métiers dans un DAL

            DAL genomica = new DAL(listeMétiers, listePersonnes);
            genomica.ChargerFichier(@"C:\Users\lmilbor\OneDrive\Documents\Support de cours\Projets\Data.txt");
            List<TachesProduction> listeRésultat = new List<TachesProduction>();
            listeRésultat = genomica.ListeTaches.Select(t => t.Value).ToList();
            Console.WriteLine(Results.DuréeTravailPersonne(listeRésultat, MW, "2.00"));
            Console.WriteLine(Results.Avancement(listeRésultat, "2.00"));
            Console.WriteLine(Results.DuréeTravailActivité(listeRésultat, "1.00"));
            /*
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
            */
            Console.ReadKey();
        }
    }
}
