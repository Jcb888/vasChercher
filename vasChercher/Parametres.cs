using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vasChercher
{
    public partial class Parametres : Form
    {
        //public String pSource = "";

        public Parametres()
        {
            InitializeComponent();
        }

        
        private void Parametres_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.

        }

        private void buttonSourcePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string[] files = System.IO.Directory.GetFiles(fbd.SelectedPath);
                //co.strSourcePath = fbd.SelectedPath.ToString();
                //txtBoxSourcePath.Text = co.strSourcePath;
                txtBoxSourcePath.Text = fbd.SelectedPath.ToString();
                //this.creatXML();
            }
        }
    }
}
