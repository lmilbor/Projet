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
        /// <summary>
        /// Définition des variables et propriétés qui constitue la classe ancètre Taches
        /// </summary>
        public double DuréeTravailRéalisé { get; set; }
        public string LibTache { get; set; }
        public string Code { get; set; }
        public string Version { get; set; }
        public Dictionary<string,Personnes> Personne { get; set; }
        #endregion

        #region Constructeurs
        // Initialisation de la durée de travail réalisée à 0
        public Taches()
        {
            DuréeTravailRéalisé = 0;
        }

        #endregion

        #region Méthodes
        // Prévision d'une fonction annulation pour une ou plusieurs taches
        public void Annulation()
        {

        }

        #endregion
    }

    // Définition de la classe "enfants" TacheProduction et de ses propriétés, suivant le principe de l'héritage
    public class TachesProduction : Taches
    {
        #region Propriétés
        public DateTime DateDébut { get; }
        public double DuréeTravailPrévue { get; }
        public Activités Activité { get; set; }
        public double DuréeTravailRéstante { get; }
        //{
        //    get
        //    {
        //        return DuréeTravailRéstante;
        //    }

        //    set
        //    {
        //        DuréeTravailRéstante = value;// (DateDébut - DateTime.Now).TotalDays; // TODO à Corriger Attention au arrondi du double ( 0 != 0)
        //    }
        //}
        //public bool TacheTerminée
        //{
        //    get
        //    {
        //        if (DuréeTravailRéstante == 0)
        //            return true;
        //        else
        //            return false;
        //    }
        //} TODO A revoir!
        #endregion

        #region Constructeur
        //public TachesProduction()
        //{

        //}
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="duréePrévue"></param>
        /// <param name="duréeRéstante"></param>
        
        // Instancier/créer une nouvelles tache relative à la production nécessite de compléter les champs suivants
        public TachesProduction(string code, string version, Personnes personne, Activités activité, string libelléTache, DateTime dateInitiation, double duréePrévue, double duréeRéalisée, double duréeRéstante) : base()
        {
            Personne = new Dictionary<string, Personnes>();
            Code = code;
            Version = version;
            Personne.Add(personne.Code, personne);
            //Activité = activité;
            LibTache = libelléTache;
            DateDébut = dateInitiation;
            DuréeTravailPrévue = duréePrévue;
            DuréeTravailRéalisé = duréeRéalisée;
            DuréeTravailRéstante = duréeRéstante;
        }
        #endregion
    }

    // ??
    public class TachesAnnexes : Taches
    {
        public static int _idTache = 0;
        #region Propriétés
        public double DuréeTravailRéaliséMensuelle
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
        //??
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

        // Redéfinition de la méthode string
        public override string ToString()
        {
            return string.Format("Libellé : {0}", LibTache);
        }

        #endregion
    }
}
