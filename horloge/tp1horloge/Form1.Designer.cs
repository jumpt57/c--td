namespace tp1horloge
{
    partial class Form1
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
            this.lblDateHeure = new System.Windows.Forms.Label();
            this.bntQuitter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnHeure = new System.Windows.Forms.RadioButton();
            this.rbntDate = new System.Windows.Forms.RadioButton();
            this.rbtnDateHeure = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateHeure
            // 
            this.lblDateHeure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateHeure.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateHeure.Location = new System.Drawing.Point(128, 23);
            this.lblDateHeure.Name = "lblDateHeure";
            this.lblDateHeure.Size = new System.Drawing.Size(297, 48);
            this.lblDateHeure.TabIndex = 4;
            this.lblDateHeure.Text = "label1";
            this.lblDateHeure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntQuitter
            // 
            this.bntQuitter.Location = new System.Drawing.Point(441, 36);
            this.bntQuitter.Name = "bntQuitter";
            this.bntQuitter.Size = new System.Drawing.Size(75, 23);
            this.bntQuitter.TabIndex = 1;
            this.bntQuitter.Text = "Quitter";
            this.bntQuitter.UseVisualStyleBackColor = true;
            this.bntQuitter.Click += new System.EventHandler(this.bntQuitter_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnHeure);
            this.groupBox1.Controls.Add(this.rbntDate);
            this.groupBox1.Controls.Add(this.rbtnDateHeure);
            this.groupBox1.Controls.Add(this.bntQuitter);
            this.groupBox1.Location = new System.Drawing.Point(19, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 63);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rbtnHeure
            // 
            this.rbtnHeure.AutoSize = true;
            this.rbtnHeure.Location = new System.Drawing.Point(439, 11);
            this.rbtnHeure.Name = "rbtnHeure";
            this.rbtnHeure.Size = new System.Drawing.Size(52, 17);
            this.rbtnHeure.TabIndex = 4;
            this.rbtnHeure.TabStop = true;
            this.rbtnHeure.Text = "heure";
            this.rbtnHeure.UseVisualStyleBackColor = true;
            // 
            // rbntDate
            // 
            this.rbntDate.AutoSize = true;
            this.rbntDate.Location = new System.Drawing.Point(241, 11);
            this.rbntDate.Name = "rbntDate";
            this.rbntDate.Size = new System.Drawing.Size(46, 17);
            this.rbntDate.TabIndex = 3;
            this.rbntDate.TabStop = true;
            this.rbntDate.Text = "date";
            this.rbntDate.UseVisualStyleBackColor = true;
            // 
            // rbtnDateHeure
            // 
            this.rbtnDateHeure.AutoSize = true;
            this.rbtnDateHeure.Location = new System.Drawing.Point(6, 11);
            this.rbtnDateHeure.Name = "rbtnDateHeure";
            this.rbtnDateHeure.Size = new System.Drawing.Size(88, 17);
            this.rbtnDateHeure.TabIndex = 2;
            this.rbtnDateHeure.TabStop = true;
            this.rbtnDateHeure.Text = "date et heure";
            this.rbtnDateHeure.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(560, 141);
            this.Controls.Add(this.lblDateHeure);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDateHeure;
        private System.Windows.Forms.Button bntQuitter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnHeure;
        private System.Windows.Forms.RadioButton rbntDate;
        private System.Windows.Forms.RadioButton rbtnDateHeure;
    }
}

