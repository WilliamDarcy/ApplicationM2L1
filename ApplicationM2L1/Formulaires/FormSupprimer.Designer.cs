namespace ApplicationM2L1
{
    partial class FormSupprimer
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
            this.listBoxSuppression = new System.Windows.Forms.ListBox();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSuppression
            // 
            this.listBoxSuppression.FormattingEnabled = true;
            this.listBoxSuppression.Location = new System.Drawing.Point(285, 38);
            this.listBoxSuppression.Name = "listBoxSuppression";
            this.listBoxSuppression.Size = new System.Drawing.Size(164, 108);
            this.listBoxSuppression.TabIndex = 0;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(374, 169);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 1;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // FormSupprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 261);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.listBoxSuppression);
            this.Name = "FormSupprimer";
            this.Text = "Supprimer un adhérent";
            this.Load += new System.EventHandler(this.FormSupprimer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSuppression;
        private System.Windows.Forms.Button buttonSupprimer;
    }
}