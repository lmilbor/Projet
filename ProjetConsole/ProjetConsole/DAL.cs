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
        public List<Personnes> ListePersonnes { get; set; } //TODO List ou Dictionary
        public List<Taches> ListeTaches { get; set; } //TODO Faire un Dico ?
        #endregion

        #region Constructeur

        #endregion

        #region Méthodes

        public void ChargerFichier (string texte)
        {
            string[] fichier = File.ReadAllLines(texte);
            string[] temp;
            for (int i = 0; i < fichier.Length; i++)
            {
                temp = fichier[i].Split('\t');
                // TODO numéro de tache
                Version.Add(temp[1]);

                ListeMétiers.Add();

                ListePersonnes.Add();

                ListeTaches.Add();
            }
        }

        #endregion
    }
}
