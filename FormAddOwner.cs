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
    public partial class FormAddOwner : Form
    {
        SQL sql = new SQL();
        public FormAddOwner()
        {
            InitializeComponent();
        }

        private void ButtonAddOwner_Click(object sender, EventArgs e)
        {
            string x, y, z;
            Owners ownername = new Owners();

            if (textBoxOwnerName.Text != "")
            {
                ownername.OwnerName = textBoxOwnerName.Text;
                ownername.Adress = textBoxAdress.Text;
                ownername.PhoneNumber = textBoxPhonenumber.Text;
                sql.AddOwner(ownername);
                x = textBoxOwnerName.Text;
                y = textBoxAdress.Text;
                z = textBoxPhonenumber.Text;

                MessageBox.Show("You added new owner:\n" +
                "Name: " + x + "\n" +
                "Adress: " + y + "\n" +
                "Phonenumber: " + z);

            }
            else
            {
                MessageBox.Show("Enter owner name");
            }
            

            
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            textBoxOwnerName.Clear();
            textBoxAdress.Clear();
            textBoxPhonenumber.Clear();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
