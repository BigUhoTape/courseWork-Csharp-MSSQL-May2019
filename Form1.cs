using System;
using System.Drawing;
using System.Windows.Forms;
using CourseWork_Vostrikov.dbHelper;
using CourseWork_Vostrikov.Properties;

namespace CourseWork_Vostrikov
{
    public partial class Кинолог : Form
    {
        public int x=0;
        
        private SQL dbHelper = new SQL();

        
        public Кинолог()
        {
            InitializeComponent();
        }

        private void ButtonBreed_Click(object sender, EventArgs e)
        {
            x = 1;
            dataGridViewDataBase.DataSource = dbHelper.GetBreedTable();
            pictureBox1.BackgroundImage = null;
            pictureBox1.Image = Properties.Resources.icons8_мопс_961;
            dataGridViewDataBase.DataSource = dbHelper.updatingBreed();
        }

        private void ButtonOwners_Click(object sender, EventArgs e)
        {
            x = 2;
            dataGridViewDataBase.DataSource = dbHelper.GetOwnersTable();
            pictureBox1.BackgroundImage = null;
            pictureBox1.Image = Properties.Resources.iconOwner;
            dataGridViewDataBase.DataSource = dbHelper.updatingOwners();
        }

        private void ButtonDog_Click(object sender, EventArgs e)
        {
            x = 3;
            dataGridViewDataBase.DataSource = dbHelper.GetDogTable();
            pictureBox1.BackgroundImage = null;
            pictureBox1.Image = Properties.Resources.iconWolf;
            dataGridViewDataBase.DataSource = dbHelper.updatingDog();
        }

        private void ButtonOwnerDog_Click(object sender, EventArgs e)
        {
            x = 4;
            dataGridViewDataBase.DataSource = dbHelper.GetOwnerDogTable();
            pictureBox1.BackgroundImage = null;
            pictureBox1.Image = Properties.Resources.iconMini;
            dataGridViewDataBase.DataSource = dbHelper.updatingOwnerDog();
        }

        

        private void ButtonAdding_Click(object sender, EventArgs e)
        {
            if (x == 0)
                MessageBox.Show("At first, select table");
            if (x == 1)
            {
                FormAddBreed AddingBreed = new FormAddBreed();
                AddingBreed.Show();
            }
            if (x==2)
            {
                FormAddOwner AddingOwner = new FormAddOwner();
                AddingOwner.Show();
            }
            if (x==3)
            {
                FormAddDog AddingDog = new FormAddDog();
                AddingDog.Show();
            }
            if (x==4)
            {
                FormAddOwnerDog AddingOwnerDog = new FormAddOwnerDog();
                AddingOwnerDog.Show();
            }
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (x == 0)
                MessageBox.Show("At first, select table");
            if (x==1)
            {
                FormUpdateBreed UpdatingBreed = new FormUpdateBreed();
                UpdatingBreed.Show();
            }
            if (x==2)
            {
                FormUpdateOwner UpdatingOwner = new FormUpdateOwner();
                UpdatingOwner.Show();
            }
            if (x==3)
            {
                FormUpdateDog UpdatingDog = new FormUpdateDog();
                UpdatingDog.Show();
            }
            if (x==4)
            {
                FormUpdateOwnerDog UpdatingOwnerDog = new FormUpdateOwnerDog();
                UpdatingOwnerDog.Show();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (x == 0)
                MessageBox.Show("At first, select table");
            if (x==1)
            {
                FormDeleteBreed deleteBreed = new FormDeleteBreed();
                deleteBreed.Show();
            }
            if (x==2)
            {
                FormDeleteOwner deleteOwner = new FormDeleteOwner();
                deleteOwner.Show();
            }
            if (x==3)
            {
                FormDeleteDog deleteDog = new FormDeleteDog();
                deleteDog.Show();
            }
            if (x==4)
            {
                FormDeleteOwnerDog deleteOwnerDog = new FormDeleteOwnerDog();
                deleteOwnerDog.Show();
            }
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            if (x == 0)
                MessageBox.Show("At first, select table");
            if (x == 1)
            {
                dataGridViewDataBase.DataSource = dbHelper.updatingBreed();
            }
            if (x==2)
            {
                dataGridViewDataBase.DataSource = dbHelper.updatingOwners();
            }
            if (x == 3)
            {
                dataGridViewDataBase.DataSource = dbHelper.updatingDog();
            }
            if (x == 4)
            {
                dataGridViewDataBase.DataSource = dbHelper.updatingOwnerDog();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
