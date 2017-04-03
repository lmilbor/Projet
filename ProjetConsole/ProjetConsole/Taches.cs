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
        public int DuréeTravailRéalisé { get; }
        public string LibTache { get; set; }
        public string Code { get; set; }
        #endregion

        #region Constructeurs
        public Taches()
        {
            DuréeTravailRéalisé = 0;
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
        public DateTime DateDébut { get; }
        public int DuréeTravailPrévue { get; }
        public double DuréeTravailRéstante
        {
            get
            {
                return DuréeTravailRéstante;
            }

            set
            {
                DuréeTravailRéstante = (DateDébut - DateTime.Now).TotalDays; // TODO à Corriger
            }
        }
        public bool TacheTerminée
        {
            get
            {
                if (DuréeTravailRéstante == 0)
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
        public TachesProduction(int duréePrévue, int duréeRéstante, DateTime dateInitiation) : base()
        {
            DuréeTravailPrévue = duréePrévue;
            DuréeTravailRéstante = duréeRéstante;
            DateDébut = dateInitiation;
        }
        #endregion
    }

    public class TachesAnnexes : Taches
    {
        public static int _idTache = 0;
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
        public TachesAnnexes() : base()
        {
            DuréeTravailRéaliséMensuelle = 0;
            _idTache++;
            Code = string.Format("AN" + _idTache);
        }
        public TachesAnnexes(string libellé) :this()
        {
            LibTache = libellé;
        }
        #endregion

        #region Méthodes

        public override string ToString()
        {
            return string.Format("Libellé : {0}", LibTache);
        }

        #endregion
    }
}
