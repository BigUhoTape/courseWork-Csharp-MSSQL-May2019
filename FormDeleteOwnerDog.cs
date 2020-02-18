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


namespace CourseWork_Vostrikov
{
    public partial class FormDeleteOwnerDog : Form
    {
        SQL deleteSQL = new SQL();
        public FormDeleteOwnerDog()
        {
            InitializeComponent();
            comboBoxDeleteOwnerDog.DataSource = deleteSQL.GetOwnerDogTable();
            comboBoxDeleteOwnerDog.DisplayMember = "IDDog";
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                OwnerDog selectOwnerDog = (OwnerDog)comboBoxDeleteOwnerDog.SelectedItem;
                deleteSQL.DeleteOwnerDog(selectOwnerDog);
                MessageBox.Show("The row is deleted");
            }
            catch
            {
                MessageBox.Show("That ID Dog is already used");
            }
            
           
        }
    }
}
