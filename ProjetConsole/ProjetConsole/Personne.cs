using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public class Personne
    {
        #region Propriétés
        public string Code { get; }
        public string Nom { get; }
        public string Prénom { get; }
        public Métiers Métier { get; }

        #endregion

        #region Constructeur

        public Personne(string code, string prénom, string nom, Métiers métier)
        {
            Code = code;
            Nom = nom;
            Prénom = prénom;
            Métier = métier;
        }

        #endregion

        #region Méthodes
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",Code, Prénom, Nom, Métier.Intitulé);
        }
        #endregion

    }
}
