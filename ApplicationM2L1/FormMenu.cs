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
    public partial class FormMenu : Form
    {
        private List<Adherent> LesAdherents;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void listerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLister fl = new FormLister(LesAdherents);
            fl.ShowDialog();
 
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjout fa = new FormAjout(LesAdherents);
            fa.ShowDialog();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupprimer fs = new FormSupprimer(LesAdherents);
            fs.ShowDialog();

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            LesAdherents = CreationAdherents.CreationListe();
        }
    }
}
