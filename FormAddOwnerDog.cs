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
    
    public partial class FormAddOwnerDog : Form
    {
        SQL sql = new SQL();
        public FormAddOwnerDog()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            int x1, x2;
            OwnerDog ownerdog = new OwnerDog();
            if (textBoxIDDog.Text != "" && textBoxIDOwner.Text != "")
            {
                try
                {
                    ownerdog.IDDog = Convert.ToInt32(textBoxIDDog.Text);
                    ownerdog.IDOwner = Convert.ToInt32(textBoxIDOwner.Text);
                    sql.AddOwnerDog(ownerdog);

                    x1 = Convert.ToInt32(textBoxIDDog.Text);
                    x2 = Convert.ToInt32(textBoxIDOwner.Text);

                    MessageBox.Show(
                        "You added a new row (Owner - Dog):\n" +
                        "ID Dog: " + x1 + "\n" +
                        "ID Owner: " + x2 + "\n"
                        );
                }
                catch
                {
                    MessageBox.Show("This Dog already have owner or there is no such dog.");
                }
            }
            else
            {
                MessageBox.Show("Enter all fields");
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            textBoxIDDog.Clear();
            textBoxIDOwner.Clear();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
