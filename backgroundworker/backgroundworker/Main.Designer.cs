namespace backgroundworker
{
    partial class main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstValeursNonTriees = new System.Windows.Forms.ListView();
            this.lstValeursTriees = new System.Windows.Forms.ListView();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnInitialiser = new System.Windows.Forms.Button();
            this.btnTrier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(386, 12);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(100, 20);
            this.txtTaille.TabIndex = 0;
            this.txtTaille.TextChanged += new System.EventHandler(this.txtTaille_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Taille du tableau";
            // 
            // lstValeursNonTriees
            // 
            this.lstValeursNonTriees.Location = new System.Drawing.Point(12, 55);
            this.lstValeursNonTriees.Name = "lstValeursNonTriees";
            this.lstValeursNonTriees.Size = new System.Drawing.Size(190, 325);
            this.lstValeursNonTriees.TabIndex = 2;
            this.lstValeursNonTriees.UseCompatibleStateImageBehavior = false;
            this.lstValeursNonTriees.View = System.Windows.Forms.View.List;
            // 
            // lstValeursTriees
            // 
            this.lstValeursTriees.Location = new System.Drawing.Point(295, 55);
            this.lstValeursTriees.Name = "lstValeursTriees";
            this.lstValeursTriees.Size = new System.Drawing.Size(190, 325);
            this.lstValeursTriees.TabIndex = 3;
            this.lstValeursTriees.UseCompatibleStateImageBehavior = false;
            this.lstValeursTriees.View = System.Windows.Forms.View.List;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(411, 396);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnInitialiser
            // 
            this.btnInitialiser.Location = new System.Drawing.Point(212, 55);
            this.btnInitialiser.Name = "btnInitialiser";
            this.btnInitialiser.Size = new System.Drawing.Size(75, 23);
            this.btnInitialiser.TabIndex = 5;
            this.btnInitialiser.Text = "Initialiser";
            this.btnInitialiser.UseVisualStyleBackColor = true;
            this.btnInitialiser.Click += new System.EventHandler(this.btnInitialiser_Click);
            // 
            // btnTrier
            // 
            this.btnTrier.Location = new System.Drawing.Point(212, 84);
            this.btnTrier.Name = "btnTrier";
            this.btnTrier.Size = new System.Drawing.Size(75, 23);
            this.btnTrier.TabIndex = 6;
            this.btnTrier.Text = "Trier";
            this.btnTrier.UseVisualStyleBackColor = true;
            this.btnTrier.Click += new System.EventHandler(this.btnTrier_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 431);
            this.Controls.Add(this.btnTrier);
            this.Controls.Add(this.btnInitialiser);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lstValeursTriees);
            this.Controls.Add(this.lstValeursNonTriees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTaille);
            this.Name = "main";
            this.Text = "TriBulle";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstValeursNonTriees;
        private System.Windows.Forms.ListView lstValeursTriees;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnInitialiser;
        private System.Windows.Forms.Button btnTrier;
    }
}

