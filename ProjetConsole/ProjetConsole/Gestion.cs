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

        public DateTime DuréeRéalisée { get; }

        public DateTime DuréeRéstante { get; set; }

        public Personne Ressource { get; set; }

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

        #endregion

        #region Constructeurs

        #endregion

        #region Méthodes

        #endregion
    }

    public class GestionTache : Gestion
    {
        #region Champs Privés

        #endregion

        #region Propriétés
        public DateTime DuréeRestante { get; set; }
        #endregion

        #region Constructeurs
        public DuréeRestante
        #endregion

        #region Méthodes

        #endregion
    }
}
