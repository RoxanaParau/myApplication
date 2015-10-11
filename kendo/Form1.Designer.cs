namespace kendo
{
    partial class Form1
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
            this.openExcelFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importaFisierExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importaFisierExcelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openExcelFile
            // 
            this.openExcelFile.FileName = "openExcelFileDialog";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importaFisierExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importaFisierExcelToolStripMenuItem
            // 
            this.importaFisierExcelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importaFisierExcelToolStripMenuItem1});
            this.importaFisierExcelToolStripMenuItem.Name = "importaFisierExcelToolStripMenuItem";
            this.importaFisierExcelToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.importaFisierExcelToolStripMenuItem.Text = "Menu";
            // 
            // importaFisierExcelToolStripMenuItem1
            // 
            this.importaFisierExcelToolStripMenuItem1.Name = "importaFisierExcelToolStripMenuItem1";
            this.importaFisierExcelToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.importaFisierExcelToolStripMenuItem1.Text = "Importa fisier Excel";
            this.importaFisierExcelToolStripMenuItem1.Click += new System.EventHandler(this.importaFisierExcelToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kendo.Properties.Resources.Beautiful_Martial_Arts_Wallpaper;
            this.ClientSize = new System.Drawing.Size(805, 641);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA PARTICIPANTI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openExcelFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importaFisierExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importaFisierExcelToolStripMenuItem1;
    }
}

