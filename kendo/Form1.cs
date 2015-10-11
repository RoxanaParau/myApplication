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
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

       

        private void importaFisierExcelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openExcelFile.FileOk += openExcelFile_FileOk;
            openExcelFile.ShowDialog();
        }

        private void openExcelFile_FileOk(object sender, CancelEventArgs e)
        {
            TableForm table = new TableForm(openExcelFile.FileName);
            table.Show();
        }

     
    }
}

        
