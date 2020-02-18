namespace CourseWork_Vostrikov
{
    partial class FormUpdateBreed
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
            this.comboBoxUpdateBreed = new System.Windows.Forms.ComboBox();
            this.labelUpdateBreed = new System.Windows.Forms.Label();
            this.textBoxUpdateBreed = new System.Windows.Forms.TextBox();
            this.buttonUpdateBreed = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxUpdateBreed
            // 
            this.comboBoxUpdateBreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboBoxUpdateBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpdateBreed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBoxUpdateBreed.FormattingEnabled = true;
            this.comboBoxUpdateBreed.Location = new System.Drawing.Point(12, 12);
            this.comboBoxUpdateBreed.Name = "comboBoxUpdateBreed";
            this.comboBoxUpdateBreed.Size = new System.Drawing.Size(212, 21);
            this.comboBoxUpdateBreed.TabIndex = 0;
            this.comboBoxUpdateBreed.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpdateBreed_SelectedIndexChanged);
            // 
            // labelUpdateBreed
            // 
            this.labelUpdateBreed.AutoSize = true;
            this.labelUpdateBreed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUpdateBreed.Location = new System.Drawing.Point(9, 46);
            this.labelUpdateBreed.Name = "labelUpdateBreed";
            this.labelUpdateBreed.Size = new System.Drawing.Size(91, 13);
            this.labelUpdateBreed.TabIndex = 1;
            this.labelUpdateBreed.Text = "New breed name:";
            // 
            // textBoxUpdateBreed
            // 
            this.textBoxUpdateBreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textBoxUpdateBreed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxUpdateBreed.Location = new System.Drawing.Point(106, 43);
            this.textBoxUpdateBreed.Name = "textBoxUpdateBreed";
            this.textBoxUpdateBreed.Size = new System.Drawing.Size(118, 20);
            this.textBoxUpdateBreed.TabIndex = 2;
            // 
            // buttonUpdateBreed
            // 
            this.buttonUpdateBreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonUpdateBreed.FlatAppearance.BorderSize = 0;
            this.buttonUpdateBreed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateBreed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUpdateBreed.Location = new System.Drawing.Point(12, 66);
            this.buttonUpdateBreed.Name = "buttonUpdateBreed";
            this.buttonUpdateBreed.Size = new System.Drawing.Size(106, 65);
            this.buttonUpdateBreed.TabIndex = 3;
            this.buttonUpdateBreed.Text = "Update";
            this.buttonUpdateBreed.UseVisualStyleBackColor = false;
            this.buttonUpdateBreed.Click += new System.EventHandler(this.buttonUpdateBreed_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.Location = new System.Drawing.Point(118, 65);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(106, 65);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // FormUpdateBreed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(238, 126);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUpdateBreed);
            this.Controls.Add(this.textBoxUpdateBreed);
            this.Controls.Add(this.labelUpdateBreed);
            this.Controls.Add(this.comboBoxUpdateBreed);
            this.Name = "FormUpdateBreed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update breed name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUpdateBreed;
        private System.Windows.Forms.Label labelUpdateBreed;
        private System.Windows.Forms.TextBox textBoxUpdateBreed;
        private System.Windows.Forms.Button buttonUpdateBreed;
        private System.Windows.Forms.Button buttonExit;
    }
}