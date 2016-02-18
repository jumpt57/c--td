namespace tp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateHeure
            // 
            this.lblDateHeure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateHeure.Location = new System.Drawing.Point(172, 31);
            this.lblDateHeure.Name = "lblDateHeure";
            this.lblDateHeure.Size = new System.Drawing.Size(191, 21);
            this.lblDateHeure.TabIndex = 0;
            this.lblDateHeure.Text = "label1";
            this.lblDateHeure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDateHeure.Click += new System.EventHandler(this.label1_Click);
            // 
            // bntQuitter
            // 
            this.bntQuitter.Location = new System.Drawing.Point(441, 36);
            this.bntQuitter.Name = "bntQuitter";
            this.bntQuitter.Size = new System.Drawing.Size(75, 23);
            this.bntQuitter.TabIndex = 1;
            this.bntQuitter.Text = "Quitter";
            this.bntQuitter.UseVisualStyleBackColor = true;
            this.bntQuitter.Click += new System.EventHandler(this.bntQuitter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnHeure);
            this.groupBox1.Controls.Add(this.rbntDate);
            this.groupBox1.Controls.Add(this.rbtnDateHeure);
            this.groupBox1.Controls.Add(this.bntQuitter);
            this.groupBox1.Location = new System.Drawing.Point(3, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 63);
            this.groupBox1.TabIndex = 2;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 147);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDateHeure);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button1;
    }
}

