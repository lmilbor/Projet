using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Métiers ANA = new Métiers
            {
                Intitulé = "Analyste",
                ActivitéProduction = Activité.DBE | Activité.ARF | Activité.ANF

            };
            Personne Pers1 = new Personne("GL", "Genevieve", "LECLERCQ", ANA);
            Console.WriteLine(Pers1.Métier.ActivitéProduction);
            Console.ReadKey();
        }
    }
}
