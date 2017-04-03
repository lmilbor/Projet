using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public class Gestion
    {

        #region Champs Privés

        #endregion

        #region Propriétés

        public DateTime DateDébut { get; }

        public DateTime DuréePrévue { get; }

        //public DateTime DuréePassée { get {return DateTime  - DateDébut; } } //TODO A corriger

        public DateTime DuréeRéstante { get; set; }

        public Personnes Ressource { get; set; }

        #endregion

        #region Constructeurs

        #endregion

        #region Méthodes

        public void Annulation()
        {

        }

        #endregion
    }

    public class GestionVersion : Gestion
    {
        #region Champs Privés

        #endregion

        #region Propriétés
        public Dictionary<double, List<DateTime>> Version { get; set; } //TODO pour l'instant on affiche que des date -> qui à participé, etc.
        #endregion

        #region Constructeurs

        #endregion

        #region Méthodes

        #endregion
    }
    public class GestionTache :Gestion
    {
        #region Champs Privés

        #endregion

        #region Propriétés
        public DateTime DuréeRestante { get; set; }
        public bool TacheFinie { get; }
        #endregion

        #region Constructeurs

        #endregion

        #region Méthodes

        #endregion
    }
}
