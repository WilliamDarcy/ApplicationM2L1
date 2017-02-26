using ApplicationM2L1.DAL;
using ApplicationM2L1.Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationM2L1
{
    public partial class FormSupprimer : Form
    {
        private AdherentManagement AdhManagement;
        private List<Adherent> LesAdherents;

        public FormSupprimer(List<Adherent> lesAdherents)
        {
            InitializeComponent();
            LesAdherents = lesAdherents;

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            string nomAdherent = listBoxSuppression.SelectedItem.ToString();
            for (int i = LesAdherents.Count()-1; i >= 0; i--)
            {
                if (LesAdherents[i].GetNom() == nomAdherent)
                {
                    AdhManagement.SupprimerAdherent(LesAdherents[i]);
                }
            }
            this.Close();
        }
        
        private void FormSupprimer_Load(object sender, EventArgs e)
        {
            AdhManagement = new AdherentManagement(LesAdherents);
            foreach (Adherent adh in LesAdherents)
            {
                listBoxSuppression.Items.Add(adh.GetNom());
            }
        }
    }
}
