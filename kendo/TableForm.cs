using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kendo
{
    public partial class TableForm : Form
    {
        private string Excel03ConString =
    "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

        private string Excel07ConString =
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

        private string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private string filePath = null;
        public TableForm()
        {
            InitializeComponent();
        }

        public TableForm(string fileName)
        {
            InitializeComponent();
            this.filePath = fileName;
            showTable();
        }
        private void showTable()
        {
            
            string extension = Path.GetExtension(filePath);
            string header = "YES";
            string conStr, sheetName;

            conStr = string.Empty;
            switch (extension)
            {

                case ".xls": //Excel 97-03
                    conStr = string.Format(Excel03ConString, filePath, header);
                    break;

                case ".xlsx": //Excel 07
                    conStr = string.Format(Excel07ConString, filePath, header);
                    break;
            }

            //Get the name of the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                    con.Close();
                }
            }

            //Read Data from the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {
                        DataTable dt = new DataTable();
                        cmd.CommandText = "SELECT * From [" + sheetName + "]";
                        cmd.Connection = con;
                        con.Open();
                        oda.SelectCommand = cmd;
                        oda.Fill(dt);
                        con.Close();

                        //Populate DataGridView.

                     dgvParticipanti.DataSource = dt;

                    

                    }
                }
            }
          
        }




        private void SaveDataToDB(DataGridView dgView)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        for (int i = 0; i < dgView.Rows.Count; i++)
                        {
                            if (dgView.Rows[i].Cells[0].Value != null &&
                                dgView.Rows[i].Cells[1].Value != null &&
                                dgView.Rows[i].Cells[2].Value != null &&
                                dgView.Rows[i].Cells[3].Value != null &&
                                dgView.Rows[i].Cells[4].Value != null &&
                                dgView.Rows[i].Cells[5].Value != null &&
                                dgView.Rows[i].Cells[6].Value != null &&
                                dgView.Rows[i].Cells[7].Value != null)
                            {
                                cmd.Parameters.AddWithValue(string.Format("@numar{0}", i.ToString()),
                                    int.Parse(string.IsNullOrEmpty(dgView.Rows[i].Cells[0].Value.ToString()) ? "0" : dgView.Rows[i].Cells[0].Value.ToString()));
                                cmd.Parameters.AddWithValue(string.Format("@nume_sportiv{0}", i.ToString()),
                                    dgView.Rows[i].Cells[1].Value);
                                cmd.Parameters.AddWithValue(string.Format("@sex{0}", i.ToString()),
                                    dgView.Rows[i].Cells[2].Value);
                                cmd.Parameters.AddWithValue(string.Format("@data_nasterii{0}", i.ToString()),
                                    dgView.Rows[i].Cells[3].Value);
                                cmd.Parameters.AddWithValue("@ani" + i.ToString(CultureInfo.InvariantCulture),
                                    dgView.Rows[i].Cells[4].Value);
                                cmd.Parameters.AddWithValue(string.Format("@categorie{0}", i.ToString()),
                                    dgView.Rows[i].Cells[5].Value);
                                cmd.Parameters.AddWithValue(string.Format("@experienta{0}", i.ToString()),
                                    dgView.Rows[i].Cells[6].Value);
                                cmd.Parameters.AddWithValue(string.Format("@observatii{0}", i.ToString()),
                                    dgView.Rows[i].Cells[7].Value);

                                cmd.CommandText =
                                    string.Format(
                                        "INSERT INTO participanti( nume_sportiv,sex,data_nasterii, ani,categorie,experienta, observatii ) VALUES (@nume_sportiv{0},@sex{0},@data_nasterii{0}, @ani{0},@categorie{0},@experienta{0}, @observatii{0}) ",
                                        i.ToString());

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                MessageBox.Show("Date salvate cu succes!", "Succes");
            }
            catch (Exception e)
            {
                MessageBox.Show("A aparut o eroare. Va rugam incercati din nou. " + e.Message, "Eroare");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDataToDB(dgvParticipanti);
        }

        private void btnSplitIntoCateg_Click(object sender, EventArgs e)
        {
            CategoriesForm categ = new CategoriesForm(dgvParticipanti);
            categ.Show();
        }
    }
}
