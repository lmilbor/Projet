using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    class DAL
    {
        #region Champs Privés

        #endregion

        #region Propriétés
        public List<string> Version { get; set; } //TODO pour l'instant on affiche que des date -> qui à participé, etc.
        public List<Métiers> ListeMétiers { get; set; }
        public Dictionary<string, Personnes> ListePersonnes { get; set; }
        public Dictionary<string, TachesProduction> ListeTaches { get; set; } //TODO Faire un Dico ?
        #endregion

        #region Constructeur
        public DAL(List<Métiers> listeMétier, Dictionary<string, Personnes> listePersonne)
        {
            ListeMétiers = listeMétier;
            ListePersonnes = listePersonne;
        }
        #endregion

        #region Méthodes

        public void ChargerFichier(string texte)
        {
            ListeTaches = new Dictionary<string, TachesProduction>();
            TachesProduction tache;
            string[] fichier = File.ReadAllLines(texte);
            string[] temp;
            int compteur;
            Personnes tempPers = new Personnes();
            Activités[] tabActivité= { Activités.ANF, Activités.ANF, Activités.ARF, Activités.ART, Activités.Aucun, Activités.DBE, Activités.DES, Activités.DEV, Activités.GDP, Activités.INF, Activités.RPT, Activités.TES};
            for (int i = 1; i < fichier.Length - 1; i++)
            {
                temp = fichier[i].Split('\t');
                ListePersonnes.TryGetValue(temp[2], out tempPers);
                compteur = 0;
                while (temp[3].CompareTo(string.Format("{0}", tabActivité[compteur])) != 0)
                {
                    compteur++;
                }
                tache = new TachesProduction(temp[0], temp[1], tempPers, tabActivité[compteur], temp[4], Convert.ToDateTime(temp[5]), Convert.ToDouble(temp[6]), Convert.ToDouble(temp[7]), Convert.ToDouble(temp[8]));
                ListeTaches.Add(tache.Code, tache);
            }
        }

        #endregion
    }
}
