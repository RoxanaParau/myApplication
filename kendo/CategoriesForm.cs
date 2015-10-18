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
        List<ParticipantModel> maleList = new List<ParticipantModel>();
        List<ParticipantModel> femaleList = new List<ParticipantModel>();
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private List<ParticipantModel> participantsList = new List<ParticipantModel>();
        public CategoriesForm(DataGridView dgv)
        {
            InitializeComponent();
            try
            {
                for (int i = 0; i < dgv.Rows.Count - 1; i++)
                {

                    if (dgv.Rows[i].Cells[4].Value.ToString() != "" && dgv.Rows[i].Cells[4] != null)
                    {
                        participantsList.Add(new ParticipantModel
                        {
                            id = int.Parse(dgv.Rows[i].Cells[0].Value.ToString()),
                            name = dgv.Rows[i].Cells[1].Value.ToString(),
                            sex = dgv.Rows[i].Cells[2].Value.ToString(),
                            varsta = int.Parse(dgv.Rows[i].Cells[4].Value.ToString()),
                            kg = int.Parse(dgv.Rows[i].Cells[5].Value.ToString()),
                            experienta = dgv.Rows[i].Cells[6].Value.ToString()
                        });
                    }
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("O eroarea a intervenit.Va rugam verificati formatul fisierului excel.");
            }
            showCategories();
        }

        private void showCategories()
        {
            maleList = participantsList.OrderBy(p => p.sex).Where(p => p.sex == "M").ToList();
            femaleList = participantsList.OrderBy(p => p.sex).Where(p => p.sex == "F").ToList();
            maleList = maleList.OrderBy(p => p.varsta).ToList();
            femaleList = femaleList.OrderBy(p => p.varsta).ToList();
            foreach (ParticipantModel part in maleList)
            {
                if (part.kg <= 25 && part.experienta == "incepator" && part.varsta <= 7)
                {
                    part.categorie = "6-7 ANI -25 KG";
                }
                else if (part.kg > 25 && part.kg <= 30 && part.varsta <= 7)
                {
                    part.categorie = "6-7 ANI -30 KG";
                }
                else if (part.varsta == 7 && part.kg > 30 && part.kg <= 36)
                {
                    part.categorie = "7 ANI - 36 KG";
                }
                else if ((part.varsta == 8 || part.varsta == 9) && part.kg <= 27)
                {
                    part.categorie = "8-9 ANI - 27 KG";
                }
                else if ((part.varsta == 8 || part.varsta == 9) && part.kg > 27 && part.kg < 30)
                {
                    part.categorie = "8-9 ANI - 30 KG";
                }
                else if ((part.varsta == 8 || part.varsta == 9) && part.kg < 35 && part.kg > 30)
                {
                    part.categorie = "8-9 ANI - 35 KG";
                }
                else if ((part.varsta == 8 || part.varsta == 9) && part.kg <= 35 && part.kg >= 40)
                {
                    part.categorie = "8-9 ANI - 40 KG";
                }
                else if (part.varsta <= 12 && part.varsta >= 10 && part.kg < 35)
                {
                    part.categorie = "10-12 ANI -35 KG";
                }
                else if ((part.varsta == 10 || part.varsta == 11) && part.kg <= 45 && part.kg > 35)
                {
                    part.categorie = "10-11 ANI -45 KG";
                }
                else if ((part.varsta == 9 || part.varsta == 10) && part.kg > 45 && part.kg < 56)
                {
                    part.categorie = "9-10 ANI -56 KG";

                }
                else if ((part.varsta == 10 || part.varsta == 11) && part.kg > 56 && part.kg <= 60)
                {
                    part.categorie = "10-11 ANI -60 KG";
                }
                else if ((part.varsta == 12 || part.varsta == 13) && part.kg <= 37)
                {
                    part.categorie = "12-13 ANI -37 KG";
                }
                else if ((part.varsta == 12 || part.varsta == 13) && part.kg > 37 && part.kg <= 45)
                {
                    part.categorie = "12-13 ANI -45 KG";

                }
                else if ((part.varsta == 14 || part.varsta == 15) && part.kg <= 52)
                {
                    part.categorie = "14-15 ANI -52 KG";
                }
                else if (part.varsta == 15 && part.kg <= 65)
                {
                    part.categorie = "15 ANI -65 KG";
                }
                else if (part.varsta == 16 && part.kg <= 72)
                {
                    part.categorie = "16 ANI - 72 KG";
                }
                else if (part.varsta == 17 && part.kg <= 81)
                {
                    part.categorie = "17 ANI -81 KG";
                }
                else if (part.varsta > 18 && part.kg <= 65)
                {
                    part.categorie = "SENIORI - 65 KG";
                }
                else if (part.varsta >= 17 && part.kg <= 80 && part.kg > 75)
                {
                    part.categorie = "SUPER CATEGORIE - 80 KG";
                }
                else if (part.varsta >= 17 && part.kg < 75)
                {
                    part.categorie = "SUPER MECI SENIORI -75 KG";
                }
            }
            dgvFemaleCategories.DataSource = femaleList;
            dgvMaleCategories.DataSource = maleList;

        }

        private void btnCategoriesMale_Click(object sender, EventArgs e)
        {
            Categorii_baieti form = new Categorii_baieti(maleList);
            form.Show();
        }

    }
}
