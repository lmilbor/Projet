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
            Dictionary<string, Personnes> listePersonnes = new Dictionary<string, Personnes> { };
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

            #region Chargement des données dans un DAL
            // On charge la liste des personnes et des métiers dans un DAL
            DAL genomica = new DAL(listeMétiers, listePersonnes);
            genomica.ChargerFichier(@"..\..\Data.txt");
            List<TachesProduction> listeRésultat = new List<TachesProduction>();
            listeRésultat = genomica.ListeTaches.Select(t => t.Value).ToList();
            #endregion

            #region Initialisation Tâches annexe
            Dictionary<string, TachesAnnexes> tacheAnnexes = new Dictionary<string, TachesAnnexes>();
            bool nouvelleTache = true;
            string temp;
            while (nouvelleTache) // Tant qu'on a une nouvelle tache à ajouter la boucle continue
            {
                Console.WriteLine("Bonjour, avez vous de nouvelles activités annexes (oui ou non).");
                temp = Console.ReadLine();
                if (temp.CompareTo("non") != 0 && temp.CompareTo("oui") != 0) // si on ne répond ni par oui ni par non, on repose la question.
                {
                    Console.WriteLine("Veuillez répondre par oui ou par non.");
                }
                else if (temp.CompareTo("non") == 0)
                {
                    nouvelleTache = false;
                    Console.Clear();
                    tacheAnnexes.OrderBy(k => k.Key); // on trie les taches annexes et on les affiches.
                    foreach (var item in tacheAnnexes)
                    {
                        Console.WriteLine("code : {0}, {1}", item.Key, item.Value);
                    }
                }
                else
                {
                    Console.WriteLine("Veuillez saisir une nouvelle activité annexe. (libellé)"); // si on a répondue oui, on doit alors rentrer un nouveau libellé de tache.
                    TachesAnnexes tempTache = new TachesAnnexes(Console.ReadLine());
                    tacheAnnexes.Add(tempTache.Code, tempTache);
                }
            }
            Console.WriteLine("Appuyez sur une touche pour continuer."); // On passe à la suite et on vide l'écran.
            Console.ReadKey();
            #endregion

            #region Affichage des résultats

            bool résultatAfficher = true;
            while (résultatAfficher) // tant qu'on veut afficher des résultats, on continue la boucle.
            {
                Console.Clear();
                Console.WriteLine("Quelle résultat souhaitez-vous voir ?\n 1) Durée de travail réalisée et restante d'une personne sur une version du programme \n 2) Le nombre de jour et le pourcentage d'avance ou de retard sur une version du programme \n 3) Les durée totales de travail réalisée sur la production d'une version du programme pour chaque activité");
                string résultat = Console.ReadLine();
                string codePers = "";
                string verProg = "";
                Personnes tempPers = new Personnes();

                switch (résultat) // On compare la demande de l'utilisateur au resultat possible.
                {
                    case "1":
                        Console.WriteLine("Saisissez le code d'une personne ?");
                        codePers = Console.ReadLine();
                        Console.WriteLine("Saisissez une version du programme ?");
                        verProg = Console.ReadLine();
                        listePersonnes.TryGetValue(codePers, out tempPers); // on rentre la personne correspondante au code rentré par l'utilisateur dans tempPers.
                        Console.WriteLine(Results.DuréeTravailPersonne(listeRésultat, tempPers, verProg));
                        break;

                    case "2":
                        Console.WriteLine("Saisissez une version du programme svp.");
                        verProg = Console.ReadLine();
                        Console.WriteLine(Results.Avancement(listeRésultat, verProg));
                        break;

                    case "3":
                        Console.WriteLine("Saisissez le code d'une personne ?");
                        codePers = Console.ReadLine();
                        Console.WriteLine("Saisissez une version du programme svp.");
                        verProg = Console.ReadLine();
                        listePersonnes.TryGetValue(codePers, out tempPers); // on rentre la personne correspondante au code rentré par l'utilisateur dans tempPers.
                        Console.WriteLine(Results.DuréeTravailPersonne(listeRésultat, tempPers, verProg));
                        break;

                    default:
                        Console.WriteLine("Attention, entrez 1, 2 ou 3"); // si on ne rentre pas 1, 2 ou 3 on repose la question.
                        break;
                }
                Console.ReadKey();
                Console.WriteLine("Avez-vous d'autres résultats à afficher ? (oui, non)");
                string réponse = Console.ReadLine();
                if (réponse == "non")
                    résultatAfficher = false; // Si on a plus de résultats à afficher.
            }
            Console.WriteLine("Au revoir. Appuyez sur une touche pour quitter");
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);
            //Console.ReadKey();
        }
        #endregion
    }
}
