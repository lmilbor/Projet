using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public static class Results
    {
        /// <summary>
        /// Retourne les durées de travail réalisée restante d'une personne sur une version.
        /// </summary>
        /// <param name="listeTache">La liste des taches du projet</param>
        /// <param name="personne"></param>
        /// <param name="version">Numéro de version</param>
        /// <returns></returns>
        public static string DuréeTravailPersonne(List<TachesProduction> listeTache, Personnes personne, string version)
        {
            double duréeRestante, duréeRéalisée;
            Personnes tempPers = new Personnes();
            duréeRéalisée = listeTache.Where(t => (t.Version.CompareTo(version) == 0) && (t.Personne.TryGetValue(personne.Code, out tempPers))).Sum(d => d.DuréeTravailRéalisé);
            duréeRestante = listeTache.Where(t => (t.Version.CompareTo(version) == 0) && (t.Personne.TryGetValue(personne.Code, out tempPers))).Sum(d => d.DuréeTravailRéstante);
            return String.Format("Pour la version {0}, {1} a efféctué(e) {2} jours de travail, il lui reste {3} jours.", version, personne.Code, duréeRéalisée, duréeRestante);
        }
        /// <summary>
        /// Le nombre de jours et le pourcentage d'avance ou de retard sur une version.
        /// </summary>
        /// <param name="listeTache">La liste des taches du projet</param>
        /// <param name="version">numéro de version</param>
        /// <returns></returns>
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
                return string.Format("Pour la version {0} le retard est de {1}% soit {2} jours de travail.", version, Math.Round(pourcentage - 100, 2), -jours);
        }
        /// <summary>
        /// Les durées totales de travail réalisées sur la production d'une version, pour chaque activité.
        /// </summary>
        /// <param name="listeTache">La liste des taches du projet</param>
        /// <param name="version">numéro de version</param>
        /// <returns></returns>
        public static string DuréeTravailActivité(List<TachesProduction> listeTache, string version)
        {
            double jours;
            string retour = "";
            var activités = listeTache.Where(t => t.Version == version).Select(p => p.Activité).Distinct();
            foreach(var a in activités)
            {
                jours = listeTache.Where(t => t.Version == version && t.Activité == a).Sum(p => p.DuréeTravailRéalisé);
                retour += string.Format("Il y a eu {0} jours de travail pour l'activité {1}.\n", jours, a);
            }
            return string.Format("Sur la production de la version {0} :\n{1}", version, retour);
        }
    }
}
