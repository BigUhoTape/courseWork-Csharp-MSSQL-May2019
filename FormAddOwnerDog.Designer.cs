namespace CourseWork_Vostrikov
{
    partial class FormAddOwnerDog
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
            this.labelIDOwner = new System.Windows.Forms.Label();
            this.labelIDDOG = new System.Windows.Forms.Label();
            this.textBoxIDOwner = new System.Windows.Forms.TextBox();
            this.textBoxIDDog = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIDOwner
            // 
            this.labelIDOwner.AutoSize = true;
            this.labelIDOwner.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelIDOwner.Location = new System.Drawing.Point(16, 49);
            this.labelIDOwner.Name = "labelIDOwner";
            this.labelIDOwner.Size = new System.Drawing.Size(52, 13);
            this.labelIDOwner.TabIndex = 0;
            this.labelIDOwner.Text = "ID Owner";
            // 
            // labelIDDOG
            // 
            this.labelIDDOG.AutoSize = true;
            this.labelIDDOG.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelIDDOG.Location = new System.Drawing.Point(16, 22);
            this.labelIDDOG.Name = "labelIDDOG";
            this.labelIDDOG.Size = new System.Drawing.Size(41, 13);
            this.labelIDDOG.TabIndex = 0;
            this.labelIDDOG.Text = "ID Dog";
            // 
            // textBoxIDOwner
            // 
            this.textBoxIDOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textBoxIDOwner.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxIDOwner.Location = new System.Drawing.Point(83, 46);
            this.textBoxIDOwner.Name = "textBoxIDOwner";
            this.textBoxIDOwner.Size = new System.Drawing.Size(121, 20);
            this.textBoxIDOwner.TabIndex = 1;
            // 
            // textBoxIDDog
            // 
            this.textBoxIDDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textBoxIDDog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxIDDog.Location = new System.Drawing.Point(83, 19);
            this.textBoxIDDog.Name = "textBoxIDDog";
            this.textBoxIDDog.Size = new System.Drawing.Size(121, 20);
            this.textBoxIDDog.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(19, 72);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(62, 53);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancel.Location = new System.Drawing.Point(81, 72);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(61, 53);
            this.buttonCancel.TabIndex = 2;
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
            this.buttonExit.Location = new System.Drawing.Point(142, 72);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(62, 53);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // FormAddOwnerDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(220, 123);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxIDDog);
            this.Controls.Add(this.textBoxIDOwner);
            this.Controls.Add(this.labelIDDOG);
            this.Controls.Add(this.labelIDOwner);
            this.Name = "FormAddOwnerDog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding Owner and Dog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIDOwner;
        private System.Windows.Forms.Label labelIDDOG;
        private System.Windows.Forms.TextBox textBoxIDOwner;
        private System.Windows.Forms.TextBox textBoxIDDog;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExit;
    }
}