using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backgroundworker
{
    public partial class main : Form
    {
        private int tailleTableau;
        private double[] T;

        public main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tailleTableau = 10;
            txtTaille.Text = tailleTableau.ToString();
        }

        private void txtTaille_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tailleTableau = Int32.Parse(txtTaille.Text);
            }
            catch (Exception)
            {
                tailleTableau = 10;                
            }
            txtTaille.Text = tailleTableau.ToString();
        }

        private void btnInitialiser_Click(object sender, EventArgs e)
        {
            T = new double[tailleTableau];
            Initialiser(T);
            Afficher(T, lstValeursNonTriees);
        }        

        private void Initialiser(double[] T)
        {
            lstValeursNonTriees.Clear();
            lstValeursTriees.Clear();
            Random r = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < T.Length; i++)
            {
                T[i] = r.NextDouble() * 10;
            }
        }

        private void Afficher(double[] tableau, ListView lstValeursNonTriees)
        {
            lstValeursNonTriees.Clear();
            lstValeursTriees.Clear();
            foreach (double value in tableau)
            {
                lstValeursNonTriees.Items.Add(new ListViewItem(Convert.ToString(value)));
            }
        }

        private void btnTrier_Click(object sender, EventArgs e)
        {
            ProgressBar ProgressBar = new ProgressBar(T);
            ProgressBar.ShowDialog();
            while (!ProgressBar.GetOver())
            {
                continue;
            }
            if (!ProgressBar.GetCancel())
            {
                Afficher(ProgressBar.GetT(), lstValeursTriees);
            }
            else
            {
                lstValeursTriees.Clear();
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
