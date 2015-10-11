namespace kendo
{
    partial class TableForm
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
            this.dgvParticipanti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSplitIntoCateg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipanti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParticipanti
            // 
            this.dgvParticipanti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipanti.Location = new System.Drawing.Point(50, 79);
            this.dgvParticipanti.Name = "dgvParticipanti";
            this.dgvParticipanti.Size = new System.Drawing.Size(726, 381);
            this.dgvParticipanti.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(291, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista participanti";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(649, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 39);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Salveaza datele in baza de date";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSplitIntoCateg
            // 
            this.btnSplitIntoCateg.Location = new System.Drawing.Point(538, 29);
            this.btnSplitIntoCateg.Name = "btnSplitIntoCateg";
            this.btnSplitIntoCateg.Size = new System.Drawing.Size(95, 44);
            this.btnSplitIntoCateg.TabIndex = 6;
            this.btnSplitIntoCateg.Text = "Imparte pe categorii";
            this.btnSplitIntoCateg.UseVisualStyleBackColor = true;
            this.btnSplitIntoCateg.Click += new System.EventHandler(this.btnSplitIntoCateg_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 494);
            this.Controls.Add(this.btnSplitIntoCateg);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvParticipanti);
            this.Name = "TableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TableForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipanti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvParticipanti;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSplitIntoCateg;
    }
}