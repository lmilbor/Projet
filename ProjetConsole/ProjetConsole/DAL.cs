using System;
using System.Collections.Generic;
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
        public Dictionary<double, Array> Version { get; set; } //TODO pour l'instant on affiche que des date -> qui à participé, etc.
        public List<Métier> ListeMétiers { get; set; }
        public List<Personne> ListePersonne { get; set; } //TODO List ou Dictionary
        public Tache ListeTache { get; set; }
        #endregion
        #region Constructeur

        #endregion
    }
}
