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
    public partial class FormAddBreed : Form
    {
        SQL sql = new SQL();
        public FormAddBreed()
        {
            InitializeComponent();
        }

        private void ButtonAddBreed_Click(object sender, EventArgs e)
        {
            string y;
            if (textBoxAddBreed.Text!="")
            {
                Breed breed = new Breed();
                breed.BreedName = textBoxAddBreed.Text;
                sql.AddBreed(breed);
                y = this.textBoxAddBreed.Text;
                MessageBox.Show("You added breed: " + y);
            }
            else
            {
                MessageBox.Show("Please, enter Breed Name");
            }
        }

        private void ButtonCancelBreed_Click(object sender, EventArgs e)
        {
            textBoxAddBreed.Clear();
        }

        private void ButtonExitBreed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
