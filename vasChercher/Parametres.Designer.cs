namespace vasChercher
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
            this.txtBoxSourcePath = new System.Windows.Forms.TextBox();
            this.buttonSourcePath = new System.Windows.Forms.Button();
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
            // Parametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 262);
            this.Controls.Add(this.buttonSourcePath);
            this.Controls.Add(this.txtBoxSourcePath);
            this.Name = "Parametres";
            this.Text = "Parametres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Parametres_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtBoxSourcePath;
        private System.Windows.Forms.Button buttonSourcePath;
    }
}