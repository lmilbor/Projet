using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{

    public class Métier
    {
        #region Propriétés
        public String NomPoste { get; }
        public Activité ActivitéProduction { get; }
        #endregion

        #region Constructeurs

        #endregion
    }
    public class Personne
    {
        #region Propriétés
        public string Nom { get; }
        public string Prénom { get; }
        public Métier Poste { get; }

        #endregion

        #region Constructeur

        public Personne(string nom, string prénom, Métier métier)
        {
            Nom = Nom;
            Prénom = prénom;
            Poste = métier;
        }

        #endregion

        #region Méthodes
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Nom, Prénom, Poste.NomPoste);
        }
        #endregion

    }
}
