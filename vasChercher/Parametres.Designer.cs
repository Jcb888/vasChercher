﻿namespace vasChercher
{
    partial class Parametres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parametres));
            this.txtBoxSourcePath = new System.Windows.Forms.TextBox();
            this.buttonSourcePath = new System.Windows.Forms.Button();
            this.textBoxNomFichierSortie = new System.Windows.Forms.TextBox();
            this.labelNomFichierSortie = new System.Windows.Forms.Label();
            this.checkBoxEffacerDestination = new System.Windows.Forms.CheckBox();
            this.textBoxNbParts = new System.Windows.Forms.TextBox();
            this.checkBoxSplitter = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMinSizeForSplit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxSourcePath
            // 
            this.txtBoxSourcePath.Location = new System.Drawing.Point(12, 36);
            this.txtBoxSourcePath.Name = "txtBoxSourcePath";
            this.txtBoxSourcePath.Size = new System.Drawing.Size(336, 20);
            this.txtBoxSourcePath.TabIndex = 2;
            // 
            // buttonSourcePath
            // 
            this.buttonSourcePath.Location = new System.Drawing.Point(374, 32);
            this.buttonSourcePath.Name = "buttonSourcePath";
            this.buttonSourcePath.Size = new System.Drawing.Size(75, 23);
            this.buttonSourcePath.TabIndex = 3;
            this.buttonSourcePath.Text = "...";
            this.buttonSourcePath.UseVisualStyleBackColor = true;
            this.buttonSourcePath.Click += new System.EventHandler(this.buttonSourcePath_Click);
            // 
            // textBoxNomFichierSortie
            // 
            this.textBoxNomFichierSortie.Location = new System.Drawing.Point(13, 92);
            this.textBoxNomFichierSortie.Name = "textBoxNomFichierSortie";
            this.textBoxNomFichierSortie.Size = new System.Drawing.Size(335, 20);
            this.textBoxNomFichierSortie.TabIndex = 4;
            // 
            // labelNomFichierSortie
            // 
            this.labelNomFichierSortie.AutoSize = true;
            this.labelNomFichierSortie.Location = new System.Drawing.Point(12, 73);
            this.labelNomFichierSortie.Name = "labelNomFichierSortie";
            this.labelNomFichierSortie.Size = new System.Drawing.Size(96, 13);
            this.labelNomFichierSortie.TabIndex = 5;
            this.labelNomFichierSortie.Text = "Nom du ficher m3u";
            // 
            // checkBoxEffacerDestination
            // 
            this.checkBoxEffacerDestination.AutoSize = true;
            this.checkBoxEffacerDestination.Location = new System.Drawing.Point(16, 141);
            this.checkBoxEffacerDestination.Name = "checkBoxEffacerDestination";
            this.checkBoxEffacerDestination.Size = new System.Drawing.Size(114, 17);
            this.checkBoxEffacerDestination.TabIndex = 6;
            this.checkBoxEffacerDestination.Text = "Effacer destination";
            this.checkBoxEffacerDestination.UseVisualStyleBackColor = true;
            // 
            // textBoxNbParts
            // 
            this.textBoxNbParts.Location = new System.Drawing.Point(95, 174);
            this.textBoxNbParts.Name = "textBoxNbParts";
            this.textBoxNbParts.Size = new System.Drawing.Size(42, 20);
            this.textBoxNbParts.TabIndex = 7;
            // 
            // checkBoxSplitter
            // 
            this.checkBoxSplitter.AutoSize = true;
            this.checkBoxSplitter.Location = new System.Drawing.Point(16, 177);
            this.checkBoxSplitter.Name = "checkBoxSplitter";
            this.checkBoxSplitter.Size = new System.Drawing.Size(73, 17);
            this.checkBoxSplitter.TabIndex = 8;
            this.checkBoxSplitter.Text = "Splitter en";
            this.checkBoxSplitter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "morceaux les fichiers supérieurs à";
            // 
            // textBoxMinSizeForSplit
            // 
            this.textBoxMinSizeForSplit.Location = new System.Drawing.Point(315, 175);
            this.textBoxMinSizeForSplit.Name = "textBoxMinSizeForSplit";
            this.textBoxMinSizeForSplit.Size = new System.Drawing.Size(67, 20);
            this.textBoxMinSizeForSplit.TabIndex = 10;
            this.textBoxMinSizeForSplit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "et contenants le texte :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(134, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 20);
            this.textBox3.TabIndex = 13;
            // 
            // Parametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 257);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMinSizeForSplit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxSplitter);
            this.Controls.Add(this.textBoxNbParts);
            this.Controls.Add(this.checkBoxEffacerDestination);
            this.Controls.Add(this.labelNomFichierSortie);
            this.Controls.Add(this.textBoxNomFichierSortie);
            this.Controls.Add(this.buttonSourcePath);
            this.Controls.Add(this.txtBoxSourcePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Parametres";
            this.Text = "Parametres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Parametres_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtBoxSourcePath;
        private System.Windows.Forms.Button buttonSourcePath;
        public System.Windows.Forms.TextBox textBoxNomFichierSortie;
        private System.Windows.Forms.Label labelNomFichierSortie;
        public System.Windows.Forms.CheckBox checkBoxEffacerDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBoxMinSizeForSplit;
        public System.Windows.Forms.TextBox textBoxNbParts;
        public System.Windows.Forms.CheckBox checkBoxSplitter;
    }
}