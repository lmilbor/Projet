using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{

    [Flags]
    //Enumération des activtés relatives aux métiers
    public enum Activités
    {
        Aucun = 0,
        DBE = 1,
        ARF = 2,
        ANF = 4,
        DES = 8,
        INF = 16,
        ART = 32,
        ANT = 64,
        DEV = 128,
        RPT = 256,
        TES = 512,
        GDP = 1024
    }
    public class Métiers
    {
        #region Propriétés

        // Définition des variables et propriétés qui constitue la classe métier
        public String Intitulé { get; set; }
        public Activités ActivitéProduction { get; set; }
        public string Code { get; set; }

        #endregion

        #region Constructeurs
        // Instancier/créer un nouveau métier nécessite de compléter les champs suivants
        public Métiers(string intitulé, string code, Activités activitéProduction)
        {
            Intitulé = intitulé;
            Code = code;
            ActivitéProduction = activitéProduction;
        }

        #endregion
    }
}
