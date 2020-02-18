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
    public partial class FormDeleteOwner : Form
    {
        SQL deleteSQL = new SQL();
        public FormDeleteOwner()
        {
            InitializeComponent();
            comboBoxDeleteOwner.DataSource = deleteSQL.GetOwnersTable();
            comboBoxDeleteOwner.DisplayMember = "ID";

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Owners selectOwner = (Owners)comboBoxDeleteOwner.SelectedItem;
                deleteSQL.DeleteOwner(selectOwner);
                MessageBox.Show("The row is deleted");
            }
            catch
            {
                MessageBox.Show("You can't delete row, because it used in OwnerDog table. You can change IDOwner in OwnerDog table and then delete your row in Owner table");
            }
            
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
