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
    public partial class Form1 : Form
    {
        private int tailleTableau;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tailleTableau = 10;
            txtTaille.Text = tailleTableau.ToString();

        }

        private void txtTaille_TextChanged(object sender, EventArgs e)
        {

        }

        /*static void TriSelectionPermutation(double[] tableau)
        {
            int i, iRech, iMin;
            int tmp;
            for (i = 0; i < N; i++)
            {
                for (iRech = iMin = i; iRech < N; iRech++)
                    if (tableau[iRech] < tableau[iMin])
                        iMin = iRech;

                if (iMin != i)
                {
                    tmp = (int) tableau[iMin];
                    tableau[iMin] = tableau[i];
                    tableau[i] = tmp;
                }
            }

        }*/

    }
}
