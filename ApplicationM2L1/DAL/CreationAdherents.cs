using ApplicationM2L1.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationM2L1.DAL
{
    public class CreationAdherents
    {
       
        /// <summary>
        /// Création des adhérents en dur pour simuler une base de données
        /// </summary>
        /// <returns>La liste des adhérents</returns>
        public static List<Adherent> CreationListe()
        {
             List<Adherent> LesAdherents = new List<Adherent>();
            Adherent a1 = new Adherent(55, "Durand", "Jean", new DateTime(2016, 5, 5));
            Adherent a2 = new Adherent(4, "Martin", "Louis", new DateTime(2016, 6, 6));
            Adherent a3 = new Adherent(2, "Wang", "Pierre", new DateTime(2016, 7, 9));
            LesAdherents.Add(a1);
            LesAdherents.Add(a2);
            LesAdherents.Add(a3);

            return LesAdherents;
        }
    }
}
