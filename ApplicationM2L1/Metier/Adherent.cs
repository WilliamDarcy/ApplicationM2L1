using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationM2L1.Metier
{
    public class Adherent
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateAdhesion { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="id">l'id de l'adhérent</param>
        /// <param name="nom">le nom de l'adhérent</param>
        /// <param name="prenom">le prénom de l'adhérent</param>
        /// <param name="dateAdhesion">la date de l'adhésion</param>
        public Adherent(int id, string nom, string prenom, DateTime dateAdhesion)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            DateAdhesion = dateAdhesion;
        }

        /// <summary>
        /// Obtient le nom de l'adhérent
        /// </summary>
        /// <returns>le nom de l'adherent</returns>
        public string GetNom()
        {
            return Nom;
        }

        /// <summary>
        /// Obtient le prénom de l'adhérent
        /// </summary>
        /// <returns>le prénom de l'adherent</returns>
        public string GetPrenom()
        {
            return Prenom;
        }

        /// <summary>
        /// Obtient la date d'adhésion de l'adhérent
        /// </summary>
        /// <returns>la date d'adhésion</returns>
        public DateTime GetDateAdhesion()
        {
            return DateAdhesion;
        }
    }
}
