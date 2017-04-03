using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public abstract class Taches
    {
        #region Propriétés
        public DateTime DateDébut { get; }
        public int DuréeTravailRéalisé { get; }
        #endregion

        #region Constructeurs
        public Taches()
        {
            DateDébut = DateTime.Today;
            DuréeTravailRéalisé = 0;
        }

        public Taches(DateTime dateInitiation) :this()
        {
            DateDébut = dateInitiation;
        }
        #endregion
        
        #region Méthodes
        public void Annulation()
        {

        }

        #endregion
    }

    public class TachesProduction : Taches
    {
        #region Propriétés
        public int DuréeTravailPrévue { get; }
        public int DuréeTravailRéstante { get; set; }
        public bool TacheTerminée
        {
            get
            {
                if (DuréeTravailRéstante == DateDébut.)
                    return true;
                else
                    return false;
            }
        }
        #endregion

        #region Constructeur
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="duréePrévue"></param>
        /// <param name="duréeRéstante"></param>
        public TachesProduction(int duréePrévue, int duréeRéstante)
        {
            DuréeTravailPrévue = duréePrévue;
            DuréeTravailRéstante = duréeRéstante;
        }
        #endregion
    }

    public class TachesAnnexes : Taches
    {
        #region Propriétés
        public int DuréeTravailRéaliséMensuelle
        {
            get
            {
                return DuréeTravailRéaliséMensuelle;
            }
            set
            {
                if (DateTime.Today == new DateTime(DateTime.Today.Year, DateTime.Today.Month, 01, 00, 00, 00)) // Si on est le 1er du mois à 00h00min00sec alors DuréeRéaliséeMensuel = 0.
                    DuréeTravailRéaliséMensuelle = 0;
            }
        }
        #endregion

        #region Constructeur
        public TachesAnnexes() :base()
        {
            DuréeTravailRéaliséMensuelle = 0;
        }
        #endregion
    }
}
