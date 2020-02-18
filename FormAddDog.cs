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
    public partial class FormAddDog : Form
    {
        SQL sql = new SQL();
        public FormAddDog()
        {
            InitializeComponent();
        }

        private void ButtonAddingDog_Click(object sender, EventArgs e)
        {

            int? x1, x2, x3;
            string x4, x5, x6;
            double x7;
            DateTime? x8;
            string nullBreed = textBoxIDBreed.Text,
                nullIDMother = textBoxIDMother.Text,
                nullIDFather = textBoxIDFather.Text,
                nullDateBorn = textBoxDateBorn.Text;

            int? nullBreed1 = (nullBreed == "" ? (int?) null : Convert.ToInt32(textBoxIDBreed.Text));
            int? nullIDMother1 = (nullIDMother == "" ? (int?)null : Convert.ToInt32(textBoxIDMother.Text));
            int? nullIDFather1 = (nullIDFather == "" ? (int?)null : Convert.ToInt32(textBoxIDFather.Text));
            DateTime? nullDateBorn1 = (nullDateBorn == ""? (DateTime?) null : Convert.ToDateTime(textBoxDateBorn.Text));

            
                Dog newdog = new Dog();
            if (textBoxDogName.Text != "")
            {
                if (textBoxColor.Text != "")
                {
                    if (textBoxGender.Text != "")
                    {
                        if (textBoxHeight.Text != "")
                        {
                            newdog.IDBreed = (nullBreed1);
                            newdog.DogName = textBoxDogName.Text;
                            newdog.Color = textBoxColor.Text;
                            newdog.Gender = textBoxGender.Text;
                            newdog.Height = Convert.ToDouble(textBoxHeight.Text);
                            newdog.DateBorn = nullDateBorn1;
                            newdog.IDMother = nullIDMother1;
                            newdog.IDFather = nullIDFather1;
                            sql.AddDog(newdog);



                            x1 = nullBreed1;
                            x2 = nullIDMother1;
                            x3 = nullIDFather1;



                            x4 = textBoxDogName.Text;
                            x5 = textBoxColor.Text;
                            x6 = textBoxGender.Text;

                            x7 = Convert.ToDouble(textBoxHeight.Text);

                            x8 = nullDateBorn1;

                            MessageBox.Show(
                                "You added new dog:\n" +
                                "IDBreed: " + x1 + "\n" +
                                "Dog name: " + x4 + "\n" +
                                "Color: " + x5 + "\n" +
                                "Gender: " + x6 + "\n" +
                                "Height: " + x7 + "\n" +
                                "Date born: " + x8 + "\n" +
                                "ID Mother: " + x2 + "\n" +
                                "ID Father: " + x3 + "\n"
                                );
                        }
                        else
                        {
                            MessageBox.Show("Enter height");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter gender");
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
            textBoxIDBreed.Clear();
            textBoxIDMother.Clear();
            textBoxIDFather.Clear();
            textBoxDogName.Clear();
            textBoxColor.Clear();
            textBoxGender.Clear();
            textBoxDateBorn.Clear();
            textBoxHeight.Clear();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
