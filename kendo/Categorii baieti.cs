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
    public partial class Categorii_baieti : Form
    {
        private List<ParticipantModel> list = new List<ParticipantModel>(); 
        public Categorii_baieti()
        {
            InitializeComponent();
        }

        public Categorii_baieti(List<ParticipantModel> list )
        {
            InitializeComponent();
            this.list = list;
            var list1 = this.list.Where(p => p.categorie == "6-7 ANI -25 KG").ToList();
            dgv6_7ani25kg.DataSource = list1;
            var list2 = this.list.Where(p => p.categorie == "6-7 ANI -30 KG").ToList();
            dgv6_7an30ani.DataSource = list2;
            var list3 = this.list.Where(p => p.categorie == "7 ANI - 36 KG").ToList();
            dgv7ani36kg.DataSource = list3;
        }
    }
}
