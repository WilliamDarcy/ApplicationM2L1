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
    public partial class FormAjout : Form
    {
        private AdherentManagement AdhManagement;
        private List<Adherent> LesAdherents;

        public FormAjout(List<Adherent> lesAdherents)
        {
            InitializeComponent();
            LesAdherents = lesAdherents;
            AdhManagement = new AdherentManagement(LesAdherents);

        }
 

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            DateTime date = DateTime.Now;
            Adherent nouvelAdherent = new Adherent(LesAdherents.Count() + 1, nom, prenom, date);
            AdhManagement.AjoutAdherent(nouvelAdherent);
            this.Close();

        }
    }
}
