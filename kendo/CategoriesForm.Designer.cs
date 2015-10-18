namespace kendo
{
    partial class CategoriesForm
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
            this.dgvFemaleCategories = new System.Windows.Forms.DataGridView();
            this.dgvMaleCategories = new System.Windows.Forms.DataGridView();
            this.btnCategoriesFemales = new System.Windows.Forms.Button();
            this.btnCategoriesMale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFemaleCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaleCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFemaleCategories
            // 
            this.dgvFemaleCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFemaleCategories.Location = new System.Drawing.Point(12, 12);
            this.dgvFemaleCategories.Name = "dgvFemaleCategories";
            this.dgvFemaleCategories.Size = new System.Drawing.Size(656, 172);
            this.dgvFemaleCategories.TabIndex = 0;
            // 
            // dgvMaleCategories
            // 
            this.dgvMaleCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaleCategories.Location = new System.Drawing.Point(12, 238);
            this.dgvMaleCategories.Name = "dgvMaleCategories";
            this.dgvMaleCategories.Size = new System.Drawing.Size(656, 163);
            this.dgvMaleCategories.TabIndex = 1;
            // 
            // btnCategoriesFemales
            // 
            this.btnCategoriesFemales.Location = new System.Drawing.Point(420, 191);
            this.btnCategoriesFemales.Name = "btnCategoriesFemales";
            this.btnCategoriesFemales.Size = new System.Drawing.Size(108, 41);
            this.btnCategoriesFemales.TabIndex = 2;
            this.btnCategoriesFemales.Text = "Categorii fete";
            this.btnCategoriesFemales.UseVisualStyleBackColor = true;
            // 
            // btnCategoriesMale
            // 
            this.btnCategoriesMale.Location = new System.Drawing.Point(420, 407);
            this.btnCategoriesMale.Name = "btnCategoriesMale";
            this.btnCategoriesMale.Size = new System.Drawing.Size(103, 41);
            this.btnCategoriesMale.TabIndex = 3;
            this.btnCategoriesMale.Text = "Categorii baieti";
            this.btnCategoriesMale.UseVisualStyleBackColor = true;
            this.btnCategoriesMale.Click += new System.EventHandler(this.btnCategoriesMale_Click);
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 451);
            this.Controls.Add(this.btnCategoriesMale);
            this.Controls.Add(this.btnCategoriesFemales);
            this.Controls.Add(this.dgvMaleCategories);
            this.Controls.Add(this.dgvFemaleCategories);
            this.Name = "CategoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CategoriesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFemaleCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaleCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFemaleCategories;
        private System.Windows.Forms.DataGridView dgvMaleCategories;
        private System.Windows.Forms.Button btnCategoriesFemales;
        private System.Windows.Forms.Button btnCategoriesMale;
    }
}