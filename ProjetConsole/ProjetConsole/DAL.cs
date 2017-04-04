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
        // Définition des variables et propriétés qui constitue un projet
        public List<string> Version { get; set; } //TODO pour l'instant on affiche que des date -> qui à participé, etc.
        public List<Métiers> ListeMétiers { get; set; }
        public Dictionary<string, Personnes> ListePersonnes { get; set; }
        public Dictionary<string, TachesProduction> ListeTaches { get; set; }
        #endregion

        #region Constructeur
        // Permet de charger la liste des personnes et des métier relatifs à un projet
        public DAL(List<Métiers> listeMétier, Dictionary<string, Personnes> listePersonne)
        {
            ListeMétiers = listeMétier;
            ListePersonnes = listePersonne;
        }
        #endregion

        #region Méthodes
        // Fonction permettant de lire et stocker le fichier "txt" relatif au projet dans un tableau et de la parcourir.
        
        /// <summary>
        /// Cette fonction permet de récupérer les données du fichier texte et de la les stocker dans des variables afin de les exploiter.
        /// </summary>
        /// <param name="texte"></param>
        public void ChargerFichier(string texte)
        {
            ListeTaches = new Dictionary<string, TachesProduction>();
            TachesProduction tache;
            string[] fichier = File.ReadAllLines(texte);
            string[] temp;
            int compteur;
            Personnes tempPers = new Personnes();
            Activités[] tabActivité= { Activités.ANF, Activités.ANT, Activités.ARF, Activités.ART, Activités.Aucun, Activités.DBE, Activités.DES, Activités.DEV, Activités.GDP, Activités.INF, Activités.RPT, Activités.TES};
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
