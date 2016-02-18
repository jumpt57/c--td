using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace tp1
{
    public partial class Form1 : Form
    {
        private static int compteur = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDateHeure.Text = DateTime.Now.ToString();
        }
            

        private void bntQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AfficherDateHeure()
        {
            if (rbntDate.Checked)
            {
                lblDateHeure.Text = DateTime.Now.ToShortDateString();
            }
            else if (rbtnHeure.Checked)
            {
                lblDateHeure.Text = DateTime.Now.ToLongDateString();
            }
            else
            {
                lblDateHeure.Text = DateTime.Now.ToString();
            }
        }

        private void RefreshDate()
        {
            while (1 == 1)
            {
                AfficherDateHeure();
                compteur++;
                Console.WriteLine("refresh " + compteur);
                Thread.Sleep(1000);
            }         
                           
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDate();           
        }
    }
}
