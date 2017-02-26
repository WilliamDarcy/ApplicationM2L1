using ApplicationM2L1.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationM2L1.DAL
{
    public class AdherentManagement
    {
        List<Adherent> LesAdherents;
        
        
        /// <summary>
        /// Constructeur
        /// </summary>
        public AdherentManagement(List<Adherent> lesAdherents )
        {
            LesAdherents = lesAdherents;
        }

        /// <summary>
        /// Ajout d'un adhérent dans la liste
        /// </summary>
        /// <param name="unAdherent">l'adhérent à ajouter</param>
        public void AjoutAdherent(Adherent unAdherent)
        {
            LesAdherents.Add(unAdherent);
        }
        
        
        /// <summary>
        /// Supprimer un adhérents de la liste
        /// </summary>
        /// <param name="unAdherent">l'adhérent à supprimer</param>
        public void SupprimerAdherent(Adherent unAdherent)
        {
            LesAdherents.Remove(unAdherent);
        }


        /// <summary>
        /// obtient la liste de tous les adhérents
        /// </summary>
        /// <returns>la liste des adhérents</returns>
        public List<Adherent> GetLesAdherents()
        {
            return LesAdherents;
        }


    }
}
