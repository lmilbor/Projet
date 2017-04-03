using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{

    public class Métiers
    {
        #region Propriétés
        public String Intitulé { get; }
        public Activité ActivitéProduction { get; }
        #endregion

        #region Constructeurs

        #endregion
    }
    public class Personne
    {
        #region Propriétés
        public string Code { get; }
        public string Nom { get; }
        public string Prénom { get; }
        public Métiers Métier { get; }

        #endregion

        #region Constructeur

        public Personne(string nom, string prénom, Métiers métier)
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
