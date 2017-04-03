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
        public TimeSpan DuréeTravailRéalisée { get; } //TODO A corriger
        #endregion

        #region Constructeurs

        #endregion

        #region Méthodes
        public void Annulation()
        {

        }

        #endregion
    }

    public class TachesProductions :Taches
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

    public class TachesAnnexes :Taches
    {
        #region Propriétés
        public TimeSpan DuréeRéaliséMensuel
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
}
