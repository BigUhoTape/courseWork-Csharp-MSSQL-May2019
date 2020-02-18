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
    
    public partial class FormUpdateDog : Form
    {
        SQL updateSQL = new SQL();
        public FormUpdateDog()
        {
            InitializeComponent();
            comboBoxUpdateDog.DataSource = updateSQL.GetDogTable();
            comboBoxUpdateDog.DisplayMember = "ID";
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            int? x1, x2, x3;
            double x4;
            string x5, x6, x7;
            DateTime? x8;

            string nullBreed = textBoxUpdateDogBreed.Text,
                    nullIDMother = textBoxUpdateDogMotherID.Text,
            nullIDFather = textBoxUpdateDogFatherID.Text;

            string nullDateBorn = textBoxUpdateDogDateborn.Text;


            int? nullBreed1 = (nullBreed == "" ? (int?)null : Convert.ToInt32(textBoxUpdateDogBreed.Text));
            int? nullIDMother1 = (nullIDMother == "" ? (int?)null : Convert.ToInt32(textBoxUpdateDogMotherID.Text));
            int? nullIDFather1 = (nullIDFather == "" ? (int?)null : Convert.ToInt32(textBoxUpdateDogFatherID.Text));
            DateTime? nullDateBorn1 = (nullDateBorn == "" ? (DateTime?) null : Convert.ToDateTime(textBoxUpdateDogDateborn.Text));

            if (textBoxUpdateDogName.Text != "")
            {
                if (textBoxUpdateDogColor.Text != "")
                {
                    if (textBoxUpdateDogGender.Text != "")
                    {
                        if (textBoxUpdateDogHeight.Text != "")
                        {
                            Dog selectDog = (Dog)comboBoxUpdateDog.SelectedItem;
                            selectDog.IDBreed = nullBreed1;
                            selectDog.DogName = textBoxUpdateDogName.Text;
                            selectDog.Color = textBoxUpdateDogColor.Text;
                            selectDog.Gender = textBoxUpdateDogGender.Text;
                            selectDog.Height = Convert.ToDouble(textBoxUpdateDogHeight.Text);
                            selectDog.DateBorn = nullDateBorn1;
                            selectDog.IDMother = nullIDMother1;
                            selectDog.IDFather = nullIDFather1;
                            updateSQL.Update();
                            x1 = nullBreed1;
                            x2 = nullIDMother1;
                            x3 = nullIDFather1;
                            x4 = Convert.ToDouble(textBoxUpdateDogHeight.Text);
                            x5 = textBoxUpdateDogName.Text;
                            x6 = textBoxUpdateDogColor.Text;
                            x7 = textBoxUpdateDogGender.Text;
                            x8 = nullDateBorn1;

                            MessageBox.Show("You have made changes to the Dog with ID - \n" +
                                            "Breed ID: " + x1 + "\n" +
                                            "Name: " + x5 + "\n" +
                                            "Color: " + x6 + "\n" +
                                            "Gender: " + x4 + "\n" +
                                            "Breed ID: " + x1 + "\n" +
                                            "Date born: " + x8 + "\n" +
                                            "Mother ID: " + x2 + "\n" +
                                            "Father ID: " + x3
                                );
                        }
                        else
                        {
                            MessageBox.Show("Enter Dog height");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Dog gender");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Dog color");
                }
            }
            else
            {
                MessageBox.Show("Enter Dog name");
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            textBoxUpdateDogBreed.Clear();
            textBoxUpdateDogName.Clear();
            textBoxUpdateDogColor.Clear();
            textBoxUpdateDogGender.Clear();
            textBoxUpdateDogDateborn.Clear();
            textBoxUpdateDogFatherID.Clear();
            textBoxUpdateDogMotherID.Clear();
            textBoxUpdateDogHeight.Clear();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxUpdateDog_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dog selected  = (Dog) comboBoxUpdateDog.SelectedValue;
            textBoxUpdateDogBreed.Text = Convert.ToString(selected.IDBreed);
            textBoxUpdateDogColor.Text = selected.Color;
            textBoxUpdateDogDateborn.Text = Convert.ToString(selected.DateBorn);
            textBoxUpdateDogFatherID.Text = Convert.ToString(selected.IDFather);
            textBoxUpdateDogGender.Text = selected.Gender;
            textBoxUpdateDogHeight.Text = Convert.ToString(selected.Height);
            textBoxUpdateDogMotherID.Text = Convert.ToString(selected.IDMother);
            textBoxUpdateDogName.Text = selected.DogName;
        }
    }
}
