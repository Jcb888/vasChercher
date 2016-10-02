﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.VisualBasic.FileIO;
using NAudio.Wave;
using System.Management;

namespace vasChercher
{
   

    public partial class Form1 : Form
    {

        configObject paramApp;
        configObject co = new configObject();
        string appDataArterris = "";//c'est dans ce repertoire qu'on a les droits et qu'il convient d'écrire
        string appdata = "";//son ss rep.
        Parametres fp = new Parametres();
        static List<FileInfo> listeFichiers = new List<FileInfo>(); 


        public Form1()
        {
            InitializeComponent();
            appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            appDataArterris = Path.Combine(appdata, "JCSoft");
            fp.Tag = this;
            if (!Directory.Exists(appDataArterris))
                Directory.CreateDirectory(appDataArterris);

            //string strFilConfig = specificFolder + "\\config.xml";
            //labelPathEnCours.Text = ""; //init
            XmlSerializer xs = new XmlSerializer(typeof(configObject));//pour serialiser en XML la config (sauvegarde des paths src et dst)
            if (!File.Exists(appDataArterris + "\\config.xml"))//si le fichier n'existe pas on le cré avec init à "";
            {
                co.strSourcePath = "";
                co.strDestinationPath = "";
                co.strNomFichierSortie = "";
                co.effacerDest = true;
                using (StreamWriter wr = new StreamWriter(appDataArterris + "\\config.xml"))
                {
                    xs.Serialize(wr, co);
                }

            }

            //init des txtbox avec les params enregistres dans le xml
            using (StreamReader rd = new StreamReader(appDataArterris + "\\config.xml"))
            {
                co = xs.Deserialize(rd) as configObject;
                this.txtBoxDestinationPath.Text = co.strDestinationPath;
                //fp.pSource = co.strSourcePath;
                fp.txtBoxSourcePath.Text = co.strSourcePath;
                fp.textBoxNomFichierSortie.Text = co.strNomFichierSortie;
                fp.checkBoxEffacerDestination.Checked = co.effacerDest;
                //this.txtBoxDestinationPath.Text = ;
            }



        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fp.Show();
            
        }

        private void buttonExecuter_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if(fp.checkBoxEffacerDestination.Checked)
             effacerContenuRepertoireDestination();

            chercherFichiersDanspath(fp.txtBoxSourcePath.Text, this.txtBoxDestinationPath.Text, this.dateTimePickerAchercher.Value);
            string[] tab = trierLaListeRetournerTableau();
            EcrireLeFichierM3U(tab);
            System.Diagnostics.Process.Start("explorer.exe", this.txtBoxDestinationPath.Text);
            listeFichiers.Clear();
            tab = null;
            Cursor.Current = Cursors.Default;

        }

        private void effacerContenuRepertoireDestination()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(this.txtBoxDestinationPath.Text);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        private string[] trierLaListeRetournerTableau()
        {
            
            listeFichiers = listeFichiers.OrderBy((x) => x.Length).ToList();
            string [] s = new string [listeFichiers.Count];
            for (int i = 0; i < listeFichiers.Count; i++)
            {
                s[i] = listeFichiers[i].Name;
            }

            return s; 
        }

        private void EcrireLeFichierM3U(params string [] s)
        {
           
            if (fp.textBoxNomFichierSortie.Text == String.Empty)
            {

                try
                {//nom de fichier m3u par defaut
                    System.IO.File.WriteAllText(@"C:\Users\jc\Desktop\Podcasts\Jour\0jour.m3u", string.Join("\n", s), Encoding.GetEncoding("ISO-8859-1"));
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.StackTrace.ToString());
                }

            }
            else
            {
                try
                {//nom de fichier m3u parametre dans les options
                    System.IO.File.WriteAllText(@"C:\Users\jc\Desktop\Podcasts\Jour\" + fp.textBoxNomFichierSortie.Text, string.Join("\n", s), Encoding.GetEncoding("ISO-8859-1"));
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.StackTrace.ToString());

                }
                
            }
        }

        protected void chercherFichiersDanspath(String sp, string destPath, DateTime dt)
        {
            string[] tabFiles = Directory.GetFileSystemEntries(sp);

            foreach (String path in tabFiles)
            {
                if (File.Exists(path))
                {
                    // This path is a file
                    ProcessFile(path,sp, destPath, dt);

                }
                else if (Directory.Exists(path))
                {
                    // This path is a directory
                    ProcessDirectory(path, destPath, dt);
                }
                else
                {
                    Console.WriteLine("{0} is not a valid file or directory.", path);
                }
            }
        }

        // Process all files in the directory passed in, recurse on any directories 
        // that are found, and process the files they contain.
        public static void ProcessDirectory(string targetDirectory, string destinationPath, DateTime dtToFind)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName, targetDirectory, destinationPath, dtToFind);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory,destinationPath, dtToFind);
        }

        // Insert logic for processing found files here.
        public static void ProcessFile(string path, string targetDirectory ,string destPath,  DateTime dtToFind)
        {

            if (isDateEquals(path, dtToFind))
            {
                FileInfo fi = new FileInfo(path);

                listeFichiers.Add(fi);
                //string destinationFile = ;
                // Console.WriteLine("Processed file '{0}'.", path);
                try
                {
                    FileSystem.CopyFile(path, destPath + "\\" + Path.GetFileName(path), UIOption.AllDialogs);
                }
                catch (System.OperationCanceledException oce)
                {
                    MessageBox.Show("Opération annulée par l'utilisateur " + oce.StackTrace);
                }
                catch (PathTooLongException ptle)
                {
                    MessageBox.Show("Le chemin vers le répertoir est trop long " + ptle.StackTrace);
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("Le chemin vers le répertoir n'existe pas ");
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Il manque un chemin ");
                }
                catch (IOException)
                {
                    MessageBox.Show("Erreur lecture écriture");
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Accés fichier refusé par le system");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur lors de la copie: " + e.StackTrace.ToString());
                }


            }
        }

        static protected bool isDateEquals(String path, DateTime dtToFind)
        {
            DateTime dtFile = File.GetCreationTime(path).Date;

            if (dtFile.Date == dtToFind.Date)
            {
                return true;
            }
                             
            else
            return false;
        }

           

        private void buttonSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                co.strDestinationPath = fbd.SelectedPath.ToString();
                this.txtBoxDestinationPath.Text = co.strDestinationPath;
                //this.creatXML();
            }
        }

        /// <summary>
        /// Pour sérialiser (parser) l'objet contenant strSourcePath et strDestinationPath dans le fichier config.xml 
        /// </summary>
        public void creatXML()
        {
            //string repAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //string AppdataArterris = Path.Combine(repAppData, "Arterris");

            if (!verifierSource())
                return;

            if (!verifierDest())
                return;


            try
            {
                co.strSourcePath = fp.txtBoxSourcePath.Text;
                co.strDestinationPath = this.txtBoxDestinationPath.Text;
                co.strNomFichierSortie = fp.textBoxNomFichierSortie.Text;
                co.effacerDest = fp.checkBoxEffacerDestination.Checked;
                XmlSerializer xs = new XmlSerializer(typeof(configObject));
                using (StreamWriter wr = new StreamWriter(appDataArterris + "\\config.xml"))
                {
                    xs.Serialize(wr, co);
                }

                //MessageBox.Show("Enregitrement des paramétres bien effectué \n\r" + "Source: " + co.strSourcePath + "\n\r" + "Destination: " + co.strDestinationPath);

            }
            catch (Exception e)
            {

                MessageBox.Show("Erreur lors de la sauvegarde des paramètres: " + e.StackTrace.ToString());
            }

        }

        //return true si le path source existe false sinon
        private bool verifierSource()
        {

            if (!Directory.Exists(fp.txtBoxSourcePath.Text))
            {
                MessageBox.Show("Le répertoire source n'existe pas.");
                return false;
            }

            return true;
        }

        //return true si le path destination existe false sinon
        private bool verifierDest()
        {

            if (!Directory.Exists(txtBoxDestinationPath.Text))
            {
                MessageBox.Show("Le répertoire destination n'existe pas");
                return false;
            }
            return true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = DialogResult.Ignore;

            if (!this.verifierSource())
                ret = MessageBox.Show("Le répertoire source n'existe pas voulez vous quitter et abandonner les modifications  (OK) ou modifier (Annuler). ", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (!this.verifierDest())
                ret = MessageBox.Show("Le répertoire destination n'existe pas voulez vous quitter et abandonner les modifications  (OK) ou modifier  (Annuler). ", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            if (ret == DialogResult.Ignore)
            {

                this.creatXML();
            }
            if (ret == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void splitMP3()
        {
            string strMP3Folder = "<YOUR FOLDER PATH>";
            string strMP3SourceFilename = "<YOUR SOURCE MP3 FILENAMe>";
            string strMP3OutputFilename = "<YOUR OUTPUT MP3 FILENAME>";

            using (Mp3FileReader reader = new Mp3FileReader(strMP3Folder + strMP3SourceFilename))
            {
                int count = 1;
                Mp3Frame mp3Frame = reader.ReadNextFrame();
                System.IO.FileStream _fs = new System.IO.FileStream(strMP3Folder + strMP3OutputFilename, System.IO.FileMode.Create, System.IO.FileAccess.Write);

                while (mp3Frame != null)
                {
                    if (count > 500) //retrieve a sample of 500 frames
                        return;

                    _fs.Write(mp3Frame.RawData, 0, mp3Frame.RawData.Length);
                    count = count + 1;
                    mp3Frame = reader.ReadNextFrame();
                }

                _fs.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //remplacer par liste déroulante.
            System.Windows.Forms.OpenFileDialog dls = new System.Windows.Forms.OpenFileDialog();
            dls.CustomPlaces.Clear();
            foreach (DriveInfo Drive in DriveInfo.GetDrives())
            {
                if (Drive.DriveType == DriveType.Removable)
                {
                    dls.CustomPlaces.Add(Drive.Name);
                }
                
            }
            dls.ShowDialog();
        }



    }//Fin Classe

    public class configObject
    {
        public configObject()
        {

        }

        public String strSourcePath;
        public String strDestinationPath;
        public String strNomFichierSortie;
        public bool effacerDest;


    }

}//fin NSpace
