namespace ApplicationM2L1
{
    partial class FormLister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewAdherents = new System.Windows.Forms.DataGridView();
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdherents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdherents
            // 
            this.dataGridViewAdherents.AllowUserToAddRows = false;
            this.dataGridViewAdherents.AllowUserToDeleteRows = false;
            this.dataGridViewAdherents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdherents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAdherents.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAdherents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdherents.Location = new System.Drawing.Point(121, 38);
            this.dataGridViewAdherents.Name = "dataGridViewAdherents";
            this.dataGridViewAdherents.ReadOnly = true;
            this.dataGridViewAdherents.Size = new System.Drawing.Size(416, 211);
            this.dataGridViewAdherents.TabIndex = 0;
             // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataSource = typeof(ApplicationM2L1.Metier.Adherent);
            // 
            // FormLister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 261);
            this.Controls.Add(this.dataGridViewAdherents);
            this.Name = "FormLister";
            this.Text = "Liste de tous les adhérents";
            this.Load += new System.EventHandler(this.FormLister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdherents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdherents;
        private System.Windows.Forms.BindingSource adherentBindingSource;
    }
}