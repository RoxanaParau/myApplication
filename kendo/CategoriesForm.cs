using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kendo
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private DataGridView dgv = new DataGridView();

        public CategoriesForm(DataGridView dgv)
        {
            InitializeComponent();
            this.dgv = dgv;

            showCategories();
        }

        private void showCategories()
        {

            dgv.Sort(dgv.Columns["SEX"], ListSortDirection.Ascending);
            for (int i = 0; i < dgv.Columns.Count; i++)
            {

                dgvCategories.Columns.Add(new DataGridViewColumn(dgv.Columns[i].CellTemplate));
            }
            DgvCategoriesOnSortCompare();
            //  dgvCategories.Sort(dgvCategories.Columns["SEX"], ListSortDirection.Ascending);

        }

        private void DgvCategoriesOnSortCompare()
        {
            int j = 0;
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                for (int k = i + 1; k < dgv.Rows.Count; k++)
                {
                    var nr1 =(dgv.Rows[i].Cells["Ani"].Value!=null&& !string.IsNullOrEmpty( dgv.Rows[i].Cells["Ani"].Value.ToString() )) ? int.Parse(dgv.Rows[i].Cells["Ani"].Value.ToString()) : 0;
                    var nr2 =(dgv.Rows[k].Cells["Ani"].Value!=null&&!string.IsNullOrEmpty( dgv.Rows[k].Cells["Ani"].Value.ToString()))? int.Parse(dgv.Rows[k].Cells["Ani"].Value.ToString()) : 0;
                    if (nr1 > nr2)
                    {
                        var r2 = dgv.Rows[i];
                        var r1 = dgv.Rows[k];
                        int c = 0;
                        foreach (DataGridViewCell cell in r1.Cells)
                        {
                            dgvCategories.Rows.Add(new DataGridViewRow());

                            dgvCategories.Rows[j].Cells[c].Value = cell.Value;

                            c++;
                        }
                        j++;
                        c = 0;
                        foreach (DataGridViewCell cell in r2.Cells)
                        {
                            dgvCategories.Rows.Add(new DataGridViewRow());
                            dgvCategories.Rows[j].Cells[c].Value = cell.Value;
                            c++;
                        }
                        j++;

                    }
                    else
                    {
                        var r1 = dgv.Rows[i];
                        var r2 = dgv.Rows[k];
                        int c = 0;
                        foreach (DataGridViewCell cell in r1.Cells)
                        {
                            dgvCategories.Rows.Add(new DataGridViewRow());

                            dgvCategories.Rows[j].Cells[c].Value = cell.Value;

                            c++;
                        }
                        j++;
                        c = 0;
                        //foreach (DataGridViewCell cell in r2.Cells)
                        //{
                        //    dgvCategories.Rows.Add(new DataGridViewRow());

                        //    dgvCategories.Rows[j].Cells[c].Value = cell.Value;

                        //    c++;
                        //}
                        //  j++;
                    }
                }

            }
        }
    }
}
