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
        
        private List<ParticipantModel> participantsList = new List<ParticipantModel>(); 
        public CategoriesForm(DataGridView dgv)
        {
            InitializeComponent();
            try{
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                participantsList.Add(new ParticipantModel
                {
                    id =int.Parse( dgv.Rows[i].Cells["number"].Value.ToString()),
                    name = dgv.Rows[i].Cells["nume"].Value.ToString(),
                    sex = dgv.Rows[i].Cells["SEX"].Value.ToString(),
                    varsta = int.Parse(dgv.Rows[i].Cells["Ani"].Value.ToString())
                });
            }
            }catch(Exception e){
                    MessageBox.Show("O eroarea a intervenit.Va rugam verificati formatul fisierului excel.");
                }
            showCategories();
        }

        private void showCategories()
        {
            participantsList.OrderBy(p => p.sex).ThenBy(p => p.varsta);
            int categ = 1;
            for (int i = 0; i < participantsList.Count; i++)
            {
                participantsList[i].categorie = categ;
                if (i % 5 == 0)
                {
                    participantsList[i].categorie = categ;
                    categ++;
                }
            }
            dgvCategories.DataSource = participantsList;   

        }

    }
}
