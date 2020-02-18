namespace CourseWork_Vostrikov
{
    partial class FormUpdateDog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxUpdateDog = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUpdateDogBreed = new System.Windows.Forms.TextBox();
            this.textBoxUpdateDogName = new System.Windows.Forms.TextBox();
            this.textBoxUpdateDogColor = new System.Windows.Forms.TextBox();
            this.textBoxUpdateDogGender = new System.Windows.Forms.TextBox();
            this.textBoxUpdateDogHeight = new System.Windows.Forms.TextBox();
            this.textBoxUpdateDogDateborn = new System.Windows.Forms.TextBox();
            this.textBoxUpdateDogMotherID = new System.Windows.Forms.TextBox();
            this.textBoxUpdateDogFatherID = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxUpdateDog
            // 
            this.comboBoxUpdateDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboBoxUpdateDog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpdateDog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBoxUpdateDog.FormattingEnabled = true;
            this.comboBoxUpdateDog.Location = new System.Drawing.Point(82, 18);
            this.comboBoxUpdateDog.Name = "comboBoxUpdateDog";
            this.comboBoxUpdateDog.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUpdateDog.TabIndex = 0;
            this.comboBoxUpdateDog.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpdateDog_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chose ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Breed ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(18, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(18, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(18, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Height:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(18, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date born:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(18, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mother ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(18, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Father ID:";
            // 
            // textBoxUpdateDogBreed
            // 
            this.textBoxUpdateDogBreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textBoxUpdateDogBreed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxUpdateDogBreed.Location = new System.Drawing.Point(82, 46);
            this.textBoxUpdateDogBreed.Name = "textBoxUpdateDogBreed";
            this.textBoxUpdateDogBreed.Size = new System.Drawing.Size(121, 20);
            this.textBoxUpdateDogBreed.TabIndex = 10;
            // 
            // textBoxUpdateDogName
            // 
            this.textBoxUpdateDogName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textBoxUpdateDogName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxUpdateDogName.Location = new System.Drawing.Point(82, 72);
            this.textBoxUpdateDogName.Name = "textBoxUpdateDogName";
            this.textBoxUpdateDogName.Size = new System.Drawing.Size(121, 20);
            this.textBoxUpdateDogName.TabIndex = 11;
            // 
            // textBoxUpdateDogColor
            // 
            this.textBoxUpdateDogColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textBoxUpdateDogColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxUpdateDogColor.Location = new System.Drawing.Point(82, 98);
            this.textBoxUpdateDogColor.Name = "textBoxUpdateDogColor";
            this.textBoxUpdateDogColor.Size = new System.Drawing.Size(121, 20);
            this.textBoxUpdateDogColor.TabIndex = 12;
            // 
            // textBoxUpdateDogGender
            // 
            this.textBoxUpdateDogGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textBoxUpdateDogGender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxUpdateDogGender.Location = new System.Drawing.Point(82, 121);
            this.textBoxUpdateDogGender.Name = "textBoxUpdateDogGender";
            this.textBoxUpdateDogGender.Size = new System.Drawing.Size(121, 20);
            this.textBoxUpdateDogGender.TabIndex = 13;
            // 
            // textBoxUpdateDogHeight
            // 
            this.textBoxUpdateDogHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textBoxUpdateDogHeight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxUpdateDogHeight.Location = new System.Drawing.Point(82, 144);
            this.textBoxUpdateDogHeight.Name = "textBoxUpdateDogHeight";
            this.textBoxUpdateDogHeight.Size = new System.Drawing.Size(121, 20);
            this.textBoxUpdateDogHeight.TabIndex = 14;
            // 
            // textBoxUpdateDogDateborn
            // 
            this.textBoxUpdateDogDateborn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textBoxUpdateDogDateborn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxUpdateDogDateborn.Location = new System.Drawing.Point(82, 170);
            this.textBoxUpdateDogDateborn.Name = "textBoxUpdateDogDateborn";
            this.textBoxUpdateDogDateborn.Size = new System.Drawing.Size(121, 20);
            this.textBoxUpdateDogDateborn.TabIndex = 15;
            // 
            // textBoxUpdateDogMotherID
            // 
            this.textBoxUpdateDogMotherID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textBoxUpdateDogMotherID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxUpdateDogMotherID.Location = new System.Drawing.Point(82, 194);
            this.textBoxUpdateDogMotherID.Name = "textBoxUpdateDogMotherID";
            this.textBoxUpdateDogMotherID.Size = new System.Drawing.Size(121, 20);
            this.textBoxUpdateDogMotherID.TabIndex = 16;
            // 
            // textBoxUpdateDogFatherID
            // 
            this.textBoxUpdateDogFatherID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textBoxUpdateDogFatherID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxUpdateDogFatherID.Location = new System.Drawing.Point(82, 220);
            this.textBoxUpdateDogFatherID.Name = "textBoxUpdateDogFatherID";
            this.textBoxUpdateDogFatherID.Size = new System.Drawing.Size(121, 20);
            this.textBoxUpdateDogFatherID.TabIndex = 17;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUpdate.Location = new System.Drawing.Point(21, 243);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(60, 58);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancel.Location = new System.Drawing.Point(81, 243);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(62, 58);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.Location = new System.Drawing.Point(143, 243);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(60, 58);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // FormUpdateDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(223, 297);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxUpdateDogFatherID);
            this.Controls.Add(this.textBoxUpdateDogMotherID);
            this.Controls.Add(this.textBoxUpdateDogDateborn);
            this.Controls.Add(this.textBoxUpdateDogHeight);
            this.Controls.Add(this.textBoxUpdateDogGender);
            this.Controls.Add(this.textBoxUpdateDogColor);
            this.Controls.Add(this.textBoxUpdateDogName);
            this.Controls.Add(this.textBoxUpdateDogBreed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUpdateDog);
            this.Name = "FormUpdateDog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updating dog\'s data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUpdateDog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUpdateDogBreed;
        private System.Windows.Forms.TextBox textBoxUpdateDogName;
        private System.Windows.Forms.TextBox textBoxUpdateDogColor;
        private System.Windows.Forms.TextBox textBoxUpdateDogGender;
        private System.Windows.Forms.TextBox textBoxUpdateDogHeight;
        private System.Windows.Forms.TextBox textBoxUpdateDogDateborn;
        private System.Windows.Forms.TextBox textBoxUpdateDogMotherID;
        private System.Windows.Forms.TextBox textBoxUpdateDogFatherID;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExit;
    }
}