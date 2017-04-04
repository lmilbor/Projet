using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetConsole;

namespace Test_ProjetConsole
{
    class TestsUnitaires
    {
        [TestMethod]
        public void TestDuréeTravailPersonne()
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

            Results.DuréeTravailPersonne(listeRésultat, "pas une personne", "1.00");
        }


    }
}
