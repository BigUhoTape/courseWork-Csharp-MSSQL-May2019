using CourseWork_Vostrikov.dbHelper;
using CourseWork_Vostrikov.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CourseWork_Vostrikov.Entities.Dog;

namespace CourseWork_Vostrikov
{
    public partial class FormUpdateOwnerDog : Form
    {
        SQL updateSQL = new SQL();
        public FormUpdateOwnerDog()
        {
            InitializeComponent();
            comboBox1.DataSource = updateSQL.GetOwnerDogTable();
            comboBox1.DisplayMember = "IDDog";
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            OwnerDog selectOwnerDog = (OwnerDog)comboBox1.SelectedItem;
            selectOwnerDog.IDDog = Convert.ToInt32(textBoxUpdateOwmerID.Text);
            updateSQL.Update();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OwnerDog selected = (OwnerDog)comboBox1.SelectedValue;
            textBoxUpdateOwmerID.Text = Convert.ToString(selected.IDOwner); 
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
