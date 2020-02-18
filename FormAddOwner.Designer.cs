namespace CourseWork_Vostrikov
{
    partial class FormAddOwner
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
            this.labelOwnerName = new System.Windows.Forms.Label();
            this.labelOwnerAdress = new System.Windows.Forms.Label();
            this.labelPhonenumber = new System.Windows.Forms.Label();
            this.textBoxPhonenumber = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxOwnerName = new System.Windows.Forms.TextBox();
            this.buttonAddOwner = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOwnerName
            // 
            this.labelOwnerName.AutoSize = true;
            this.labelOwnerName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOwnerName.Location = new System.Drawing.Point(15, 19);
            this.labelOwnerName.Name = "labelOwnerName";
            this.labelOwnerName.Size = new System.Drawing.Size(35, 13);
            this.labelOwnerName.TabIndex = 0;
            this.labelOwnerName.Text = "Name";
            // 
            // labelOwnerAdress
            // 
            this.labelOwnerAdress.AutoSize = true;
            this.labelOwnerAdress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOwnerAdress.Location = new System.Drawing.Point(15, 48);
            this.labelOwnerAdress.Name = "labelOwnerAdress";
            this.labelOwnerAdress.Size = new System.Drawing.Size(39, 13);
            this.labelOwnerAdress.TabIndex = 1;
            this.labelOwnerAdress.Text = "Adress";
            // 
            // labelPhonenumber
            // 
            this.labelPhonenumber.AutoSize = true;
            this.labelPhonenumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPhonenumber.Location = new System.Drawing.Point(15, 77);
            this.labelPhonenumber.Name = "labelPhonenumber";
            this.labelPhonenumber.Size = new System.Drawing.Size(73, 13);
            this.labelPhonenumber.TabIndex = 2;
            this.labelPhonenumber.Text = "Phonenumber";
            // 
            // textBoxPhonenumber
            // 
            this.textBoxPhonenumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textBoxPhonenumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxPhonenumber.Location = new System.Drawing.Point(94, 74);
            this.textBoxPhonenumber.Name = "textBoxPhonenumber";
            this.textBoxPhonenumber.Size = new System.Drawing.Size(187, 20);
            this.textBoxPhonenumber.TabIndex = 3;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textBoxAdress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxAdress.Location = new System.Drawing.Point(94, 45);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(187, 20);
            this.textBoxAdress.TabIndex = 4;
            // 
            // textBoxOwnerName
            // 
            this.textBoxOwnerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textBoxOwnerName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxOwnerName.Location = new System.Drawing.Point(94, 16);
            this.textBoxOwnerName.Name = "textBoxOwnerName";
            this.textBoxOwnerName.Size = new System.Drawing.Size(187, 20);
            this.textBoxOwnerName.TabIndex = 5;
            // 
            // buttonAddOwner
            // 
            this.buttonAddOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonAddOwner.FlatAppearance.BorderSize = 0;
            this.buttonAddOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddOwner.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddOwner.Location = new System.Drawing.Point(18, 99);
            this.buttonAddOwner.Name = "buttonAddOwner";
            this.buttonAddOwner.Size = new System.Drawing.Size(88, 53);
            this.buttonAddOwner.TabIndex = 6;
            this.buttonAddOwner.Text = "Add";
            this.buttonAddOwner.UseVisualStyleBackColor = false;
            this.buttonAddOwner.Click += new System.EventHandler(this.ButtonAddOwner_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancel.Location = new System.Drawing.Point(106, 99);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 53);
            this.buttonCancel.TabIndex = 7;
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
            this.buttonExit.Location = new System.Drawing.Point(193, 99);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(88, 53);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // FormAddOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(300, 151);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddOwner);
            this.Controls.Add(this.textBoxOwnerName);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxPhonenumber);
            this.Controls.Add(this.labelPhonenumber);
            this.Controls.Add(this.labelOwnerAdress);
            this.Controls.Add(this.labelOwnerName);
            this.Name = "FormAddOwner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new owner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOwnerName;
        private System.Windows.Forms.Label labelOwnerAdress;
        private System.Windows.Forms.Label labelPhonenumber;
        private System.Windows.Forms.TextBox textBoxPhonenumber;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxOwnerName;
        private System.Windows.Forms.Button buttonAddOwner;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExit;
    }
}