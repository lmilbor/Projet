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
        public List<Métiers> ListeMétiers { get; set; }
        public List<Personnes> ListePersonnes { get; set; } //TODO List ou Dictionary
        public List<Taches> ListeTaches { get; set; } //TODO Faire un Dico ?
        #endregion
        #region Constructeur

        #endregion
    }
}
