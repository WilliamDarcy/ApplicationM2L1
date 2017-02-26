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
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "ADD";
            col.Name = "MyButton";
           
            DataTable table = new DataTable();
            table.Columns.Add("Nom", typeof(string));
            table.Columns.Add("Prenom", typeof(string));
            table.Columns.Add("Date adhésion", typeof(DateTime));
            table.Columns.Add("Supprimer", typeof(Button));
           

            var i = 0;
            foreach (var unAdherent in LesAdherents)
            {
          
                table.Rows.Add(unAdherent.GetNom(), unAdherent.GetPrenom(), unAdherent.GetDateAdhesion().ToLongDateString());
             
            }
            dataGridViewAdherents.DataSource = table;
            dataGridViewAdherents.AutoResizeColumns();

            DataGridViewButtonColumn sup = new DataGridViewButtonColumn();
            sup.Name = "supprimer";
            sup.Text = "supprimer";
            sup.UseColumnTextForButtonValue = true;
            if (dataGridViewAdherents.Columns["sup"] == null)
            {
                dataGridViewAdherents.Columns.Insert(4,sup);
            }
            //Ne fonctionne qu'avec les propriétés.
            //BindingSource bs = new BindingSource();
            //bs.DataSource = typeof(Adherent);
            //foreach (var item in LesAdherents)
            //{
            //    bs.Add(item);
            //}

            //dataGridViewAdherents.DataSource = bs;                                            //**
            //dataGridViewAdherents.AutoGenerateColumns = true; // create columns automatically //**
            //dataGridViewAdherents.AutoResizeColumns();


        }

      
    }
}
