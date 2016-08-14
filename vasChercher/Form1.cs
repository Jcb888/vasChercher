using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vasChercher
{
   

    public partial class Form1 : Form
    {

        Cparametres paramApp;



        public Form1()
        {
            InitializeComponent();

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("test 2");
        }

        private void buttonExecuter_Click(object sender, EventArgs e)
        {


            chercherFichiersDanspath(this.txtBoxSourcePath.Text);


        }

        protected void chercherFichiersDanspath(String sp)
        {
            string[] tabFiles = Directory.GetFiles(sp);

            foreach (String path in tabFiles)
            {
                if (File.Exists(path))
                {
                    // This path is a file
                    ProcessFile(path);
                }
                else if (Directory.Exists(path))
                {
                    // This path is a directory
                    ProcessDirectory(path);
                }
                else
                {
                    Console.WriteLine("{0} is not a valid file or directory.", path);
                }
            }
        }

        // Process all files in the directory passed in, recurse on any directories 
        // that are found, and process the files they contain.
        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        // Insert logic for processing found files here.
        public static void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}'.", path);
        }

        protected bool isDateEquals()
        {

            DateTime dt = dateTimePickerAchercher.Value;


            return true;
        }

        /// <summary>
        /// strucuture pour ranger dans la liste
        /// </summary>
        public class fileInfo
        {
            public fileInfo(String p, Int64 s, DateTime d)
            {
                path = p;
                size = s;
                date = d;
            }

            public String path;
            public Int64 size;
            public DateTime date;

        }

        public class Cparametres
        {
            public Cparametres()
            {

            }

            public String pathSource;
            public String pathDest;


        }


    }
}
