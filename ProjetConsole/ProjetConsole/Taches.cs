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
        public TimeSpan DuréeTravailRéalisé { get; }
        #endregion

        #region Constructeurs
        public Taches()
        {
            DateDébut = DateTime.Today;
            DuréeTravailRéalisé = TimeSpan.Zero;
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
        public TimeSpan DuréeTravailPrévue { get; }
        public TimeSpan DuréeTravailRéstante { get; set; }
        public bool TacheTerminée
        {
            get
            {
                if (DuréeTravailRéstante == TimeSpan.Zero)
                    return true;
                else
                    return false;
            }
        }
        #endregion
    }

    public class TachesAnnexes : Taches
    {
        #region Propriétés
        public TimeSpan DuréeTravailRéaliséMensuelle
        {
            get
            {
                return DuréeTravailRéaliséMensuelle;
            }
            set
            {
                if (DateTime.Today == new DateTime(DateTime.Today.Year, DateTime.Today.Month, 01, 00, 00, 00)) // Si on est le 1er du mois à 00h00min00sec alors DuréeRéaliséeMensuel = 0.
                    DuréeTravailRéaliséMensuelle = TimeSpan.Zero;
            }
        }
        #endregion
    }
}
