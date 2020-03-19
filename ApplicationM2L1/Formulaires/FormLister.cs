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
    public partial class FormLister : Form
    {
        private List<Adherent> LesAdherents;

        public FormLister(List<Adherent> lesAdherents)
        {
            InitializeComponent();
            LesAdherents = lesAdherents;

        }
      
        private void FormLister_Load(object sender, EventArgs e)
        {

            //dataGridViewAdherents.AutoGenerateColumns = true;
            //dataGridViewAdherents.AutoResizeColumns();

            //DataGridViewButtonColumn sup = new DataGridViewButtonColumn();
            //sup.Name = "supprimer";
            //sup.Text = "supprimer";
            //sup.UseColumnTextForButtonValue = true;
            //if (dataGridViewAdherents.Columns["sup"] == null)
            //{
            //    dataGridViewAdherents.Columns.Insert(4, sup);
            //}
            //Ne fonctionne qu'avec les propriétés get/set.
            BindingSource bs = new BindingSource();
            bs.DataSource = typeof(Adherent);
            foreach (var item in LesAdherents)
            {
                bs.Add(item);
            }
            
            dataGridViewAdherents.DataSource = bs;                                            
            dataGridViewAdherents.AutoGenerateColumns = true; // create columns automatically 
            dataGridViewAdherents.Columns["Id"].Visible = false;
            dataGridViewAdherents.AutoResizeColumns();
            dataGridViewAdherents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           


        }
        /// <summary>
        /// Gestion du click sur dans le contenu d'une cellule. Jamais appelé car le mode de sélection est fullRow. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewAdherents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                var content = dataGridViewAdherents[e.ColumnIndex, e.RowIndex];
            }
            
        }
        /// <summary>
        /// Gestion du click sur le header de la ligne (le petit triangle). 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewAdherents_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            var x = dataGridViewAdherents.Rows[e.RowIndex];
            MessageBox.Show("Header Click : Vous avez cliqué sur la ligne " + x.Index);
            
        }
        /// <summary>
        /// Gestion du click sur une cellule. On ne s'intèresse qu'à la ligne.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewAdherents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var x = dataGridViewAdherents.Rows[e.RowIndex];
            MessageBox.Show("Cell Click : Vous avez cliqué sur la ligne " + x.Index);
        }
    }
}
