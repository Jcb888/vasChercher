namespace vasChercher
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxDestinationPath = new System.Windows.Forms.TextBox();
            this.buttonSource = new System.Windows.Forms.Button();
            this.buttonExecuter = new System.Windows.Forms.Button();
            this.dateTimePickerAchercher = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxDestinationPath
            // 
            this.txtBoxDestinationPath.Location = new System.Drawing.Point(13, 64);
            this.txtBoxDestinationPath.Name = "txtBoxDestinationPath";
            this.txtBoxDestinationPath.Size = new System.Drawing.Size(336, 20);
            this.txtBoxDestinationPath.TabIndex = 0;
            // 
            // buttonSource
            // 
            this.buttonSource.Location = new System.Drawing.Point(366, 60);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(75, 23);
            this.buttonSource.TabIndex = 2;
            this.buttonSource.Text = "...";
            this.buttonSource.UseVisualStyleBackColor = true;
            this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
            // 
            // buttonExecuter
            // 
            this.buttonExecuter.Location = new System.Drawing.Point(13, 148);
            this.buttonExecuter.Name = "buttonExecuter";
            this.buttonExecuter.Size = new System.Drawing.Size(75, 39);
            this.buttonExecuter.TabIndex = 4;
            this.buttonExecuter.Text = "button1";
            this.buttonExecuter.UseVisualStyleBackColor = true;
            this.buttonExecuter.Click += new System.EventHandler(this.buttonExecuter_Click);
            // 
            // dateTimePickerAchercher
            // 
            this.dateTimePickerAchercher.Location = new System.Drawing.Point(103, 28);
            this.dateTimePickerAchercher.Name = "dateTimePickerAchercher";
            this.dateTimePickerAchercher.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAchercher.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 249);
            this.Controls.Add(this.dateTimePickerAchercher);
            this.Controls.Add(this.buttonExecuter);
            this.Controls.Add(this.buttonSource);
            this.Controls.Add(this.txtBoxDestinationPath);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "vasChercher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDestinationPath;
        private System.Windows.Forms.Button buttonSource;
        private System.Windows.Forms.Button buttonExecuter;
        private System.Windows.Forms.DateTimePicker dateTimePickerAchercher;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}

