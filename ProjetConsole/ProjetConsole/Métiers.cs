using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{

    [Flags]
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
        public String Intitulé { get; set; }
        public Activités ActivitéProduction { get; set; }
        public string Code { get; set; }
        #endregion

        #region Constructeurs
        public Métiers(string intitulé, string abréviation, Activités activitéProduction)
        {
            Intitulé = intitulé;
            Code = abréviation;
            ActivitéProduction = activitéProduction;
        }



        #endregion
    }
}
