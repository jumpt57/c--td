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

namespace tp1horloge
{
    public partial class Form1 : Form
    {

        private Thread leThread;      
        private static int compteur = 0;

        public Form1()
        {
            InitializeComponent();           
        }

        private void Go()
        {
            while (true)
            {
                Thread.Sleep(1000);
                AfficherDateHeure();
                System.Console.WriteLine("refresh " + compteur++);
            }
            
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {

            rbtnDateHeure.Select();
            lblDateHeure.Text = DateTime.Now.ToString();
             leThread = new Thread(new ThreadStart(Go));
            leThread.Start();

            System.Console.WriteLine("go");
        }

        private void AfficherDateHeure()
        {
            if (rbntDate.Checked)
            {
                this.SetDateHeure(DateTime.Now.ToShortDateString());
            }
            else if (rbtnHeure.Checked)
            {                
                this.SetDateHeure(DateTime.Now.ToLongDateString());                
            }
            else
            {
                this.SetDateHeure(DateTime.Now.ToString());                
            }
        }

        delegate void SetTextCallback(string text);

        private void SetDateHeure(String text)
        {
            if (this.lblDateHeure.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetDateHeure);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lblDateHeure.Text = text;
            }
        }

        private void backgroundWorkerDateHeure_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.lblDateHeure.Text = DateTime.Now.ToString();
        }

        private void backgroundWorkerDate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.lblDateHeure.Text = DateTime.Now.ToShortDateString();
        }

        private void backgroundWorkerHeure_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.lblDateHeure.Text = DateTime.Now.ToLongDateString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Closing");
            leThread.Abort();
            leThread.Join();
        }

        private void bntQuitter_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
