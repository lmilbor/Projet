using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public static class Results
    {
        public static string DuréeTravailPersonne(List<TachesProduction> listeTache, Personnes personne, string version)
        {
            double duréeRestante, duréeRéalisée;
            Personnes tempPers = new Personnes();
            duréeRéalisée = listeTache.Where(t => (t.Version.CompareTo(version) == 0) && (t.Personne.TryGetValue(personne.Code, out tempPers))).Sum(d => d.DuréeTravailRéalisé);
            duréeRestante = listeTache.Where(t => (t.Version.CompareTo(version) == 0) && (t.Personne.TryGetValue(personne.Code, out tempPers))).Sum(d => d.DuréeTravailRéstante);
            return  String.Format("Pour la version {0}, {1} a efféctué(e) {2} jours de travail, il lui reste {3} jours.",version, personne.Code, duréeRéalisée, duréeRestante);
        }

        public static string Avancement(List<TachesProduction> listeTache, string version)
        {
            double jours;
            double pourcentage;
            jours = listeTache.Where(t => t.Version.CompareTo(version) == 0).Sum(t => t.DuréeTravailPrévue - t.DuréeTravailRéalisé);
            pourcentage = 100 * listeTache.Where(t => t.Version.CompareTo(version) == 0).Sum(t => t.DuréeTravailRéalisé) / listeTache.Where(t => t.Version.CompareTo(version) == 0).Sum(t => t.DuréeTravailPrévue);

            if (jours >= 0)
            {
                return string.Format("Pour la version {0} l'avancement est de {1}% soit {2} jours de travail.", version, Math.Round(pourcentage, 2), jours);
            }
            else
                return string.Format("Pour la version {0} le retard est de {1}% soit {2} jours de travail.", version, Math.Round(pourcentage-100, 2), -jours);
        }

        public static string DuréeTravailActivité()
        {

            return "";
        }
    }
}
