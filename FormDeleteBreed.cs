﻿using CourseWork_Vostrikov.dbHelper;
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
    public partial class FormDeleteBreed : Form
    {
        SQL deleteSQL = new SQL();
        public FormDeleteBreed()
        {
            InitializeComponent();
            comboBoxDelete.DataSource = deleteSQL.GetBreedTable();
            comboBoxDelete.DisplayMember = "ID";
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Breed selectBreed = (Breed)comboBoxDelete.SelectedItem;
                deleteSQL.DeleteBreed(selectBreed);
                MessageBox.Show("The row is deleted");
            }
            catch
            {
                MessageBox.Show("You can't delete row,because it used in Dog table. You can only change IDBreed in Dog table and then delete your row in Breed table");
            }
            


        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
