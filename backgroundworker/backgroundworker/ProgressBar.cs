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
    public partial class ProgressBar : Form
    {

        private double[] T;
        private bool Over, Cancel;

        public ProgressBar()
        {
            InitializeComponent();
        }

        public ProgressBar(double[] T)
        {
            InitializeComponent();
            this.T = T;
            this.Over = false;
            this.Cancel = false;
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = T.Length - 1;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Trier(e);
        }

        private void Trier(DoWorkEventArgs e)
        {
            int i, iRech, iMin;
            double tmp;
            int N = T.Length;
            for (i = 0; i < N; i++)
            {
                for (iRech = iMin = i; iRech < N; iRech++)
                {
                    if (T[iRech] < T[iMin])
                    {
                        iMin = iRech;
                    }                        
                }

                if (iMin != i)
                {
                    tmp = T[iMin];
                    T[iMin] = T[i];
                    T[i] = tmp;
                }

                backgroundWorker1.ReportProgress(i);

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Over = true;
            if (e.Cancelled)
            {
                btnAnnuler.Enabled = false;                      
            }
            else
            {               
                btnOk.Enabled = true;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();                
            }
            else
            {
                this.Cancel = true;
                this.Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        public double[] GetT()
        {
            return this.T;
        }

        public void SetT(double[] T)
        {
            this.T = T;
        }               

        public bool GetOver()
        {
            return this.Over;
        }

        public bool GetCancel()
        {
            return this.Cancel;
        }
    }
}
