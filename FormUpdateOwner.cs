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
    public partial class FormUpdateOwner : Form
    {
        public string x4;
        SQL updateSQL = new SQL();
        
        public FormUpdateOwner()
        {
            InitializeComponent();
            comboBoxUpdateOwner.DataSource = updateSQL.GetOwnersTable();
            comboBoxUpdateOwner.DisplayMember = "ID";

        }



        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxUpdateOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            Owners selected = (Owners) comboBoxUpdateOwner.SelectedValue;
            textBoxUpdateOwner.Text = selected.OwnerName;
            textBoxUpdateOwnerAdress.Text = selected.Adress;
            textBoxUpdateOwnerPhonenumber.Text = selected.PhoneNumber;
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string x1, x2, x3;
            if (textBoxUpdateOwner.Text != "")
            {
                Owners selectedOwners = (Owners)comboBoxUpdateOwner.SelectedItem;
                selectedOwners.OwnerName = textBoxUpdateOwner.Text;
                selectedOwners.Adress = textBoxUpdateOwnerAdress.Text;
                selectedOwners.PhoneNumber = textBoxUpdateOwnerPhonenumber.Text;
                updateSQL.Update();
                x1 = textBoxUpdateOwner.Text;
                x2 = textBoxUpdateOwnerAdress.Text;
                x3 = textBoxUpdateOwnerPhonenumber.Text;

                MessageBox.Show("You have made changes to the owner with ID - " + x4 + "\n" +
                                "Name: " + x1 + "\n" +
                                "Adress: " + x2 + "\n" +
                                "Phonenumber: " + x3
                                );
            }
            else
            {
                MessageBox.Show("Name must not be empty");
            }
        }

        
    }
}
