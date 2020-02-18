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
    public partial class FormUpdateBreed : Form
    {
        SQL updateSQL = new SQL();
        public FormUpdateBreed()
        {
            InitializeComponent();
            comboBoxUpdateBreed.DataSource = updateSQL.GetBreedTable();
            comboBoxUpdateBreed.DisplayMember = "ID";

        }

        private void buttonUpdateBreed_Click(object sender, EventArgs e)
        {
            string x;
            if (textBoxUpdateBreed.Text != "")
            {
                Breed selectedBreed = (Breed)comboBoxUpdateBreed.SelectedItem;
                selectedBreed.BreedName = textBoxUpdateBreed.Text;
                updateSQL.Update();
                x = textBoxUpdateBreed.Text;
                MessageBox.Show("You have made changes: \n" +
                    "Breed name - " + x);
            }
            else
            {
                MessageBox.Show("Field is empty");
            }

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxUpdateBreed_SelectedIndexChanged(object sender, EventArgs e)
        {
            Breed selected = (Breed) comboBoxUpdateBreed.SelectedValue;
            textBoxUpdateBreed.Text = selected.BreedName;
        }
    }
}
