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
    
    public partial class FormDeleteDog : Form
    {
        SQL deleteSQL = new SQL();
        public FormDeleteDog()
        {
            InitializeComponent();
            comboBoxDeleteDog.DataSource = deleteSQL.GetDogTable();
            comboBoxDeleteDog.DisplayMember = "ID";
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Dog selectDog = (Dog)comboBoxDeleteDog.SelectedItem;
                deleteSQL.DeleteDog(selectDog);
                MessageBox.Show("The row is deleted");
            }
            catch
            {
                MessageBox.Show("You can't delete row, because it used in OwnerDog table. You can change IDDog in OwnerDog table and then delete your row in Dog table");
            }
            

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
