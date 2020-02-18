namespace CourseWork_Vostrikov
{
    partial class FormAddBreed
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
            this.labelAddBreed = new System.Windows.Forms.Label();
            this.textBoxAddBreed = new System.Windows.Forms.TextBox();
            this.buttonAddBreed = new System.Windows.Forms.Button();
            this.buttonCancelBreed = new System.Windows.Forms.Button();
            this.buttonExitBreed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddBreed
            // 
            this.labelAddBreed.AutoSize = true;
            this.labelAddBreed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAddBreed.Location = new System.Drawing.Point(12, 21);
            this.labelAddBreed.Name = "labelAddBreed";
            this.labelAddBreed.Size = new System.Drawing.Size(88, 13);
            this.labelAddBreed.TabIndex = 0;
            this.labelAddBreed.Text = "Enter new breed:";
            // 
            // textBoxAddBreed
            // 
            this.textBoxAddBreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textBoxAddBreed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxAddBreed.Location = new System.Drawing.Point(106, 18);
            this.textBoxAddBreed.Name = "textBoxAddBreed";
            this.textBoxAddBreed.Size = new System.Drawing.Size(140, 20);
            this.textBoxAddBreed.TabIndex = 1;
            // 
            // buttonAddBreed
            // 
            this.buttonAddBreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonAddBreed.FlatAppearance.BorderSize = 0;
            this.buttonAddBreed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBreed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddBreed.Location = new System.Drawing.Point(15, 48);
            this.buttonAddBreed.Name = "buttonAddBreed";
            this.buttonAddBreed.Size = new System.Drawing.Size(77, 51);
            this.buttonAddBreed.TabIndex = 2;
            this.buttonAddBreed.Text = "Add";
            this.buttonAddBreed.UseVisualStyleBackColor = false;
            this.buttonAddBreed.Click += new System.EventHandler(this.ButtonAddBreed_Click);
            // 
            // buttonCancelBreed
            // 
            this.buttonCancelBreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonCancelBreed.FlatAppearance.BorderSize = 0;
            this.buttonCancelBreed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelBreed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancelBreed.Location = new System.Drawing.Point(92, 48);
            this.buttonCancelBreed.Name = "buttonCancelBreed";
            this.buttonCancelBreed.Size = new System.Drawing.Size(77, 51);
            this.buttonCancelBreed.TabIndex = 3;
            this.buttonCancelBreed.Text = "Cancel";
            this.buttonCancelBreed.UseVisualStyleBackColor = false;
            this.buttonCancelBreed.Click += new System.EventHandler(this.ButtonCancelBreed_Click);
            // 
            // buttonExitBreed
            // 
            this.buttonExitBreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonExitBreed.FlatAppearance.BorderSize = 0;
            this.buttonExitBreed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitBreed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExitBreed.Location = new System.Drawing.Point(169, 48);
            this.buttonExitBreed.Name = "buttonExitBreed";
            this.buttonExitBreed.Size = new System.Drawing.Size(77, 51);
            this.buttonExitBreed.TabIndex = 4;
            this.buttonExitBreed.Text = "Exit";
            this.buttonExitBreed.UseVisualStyleBackColor = false;
            this.buttonExitBreed.Click += new System.EventHandler(this.ButtonExitBreed_Click);
            // 
            // FormAddBreed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(265, 98);
            this.Controls.Add(this.buttonExitBreed);
            this.Controls.Add(this.buttonCancelBreed);
            this.Controls.Add(this.buttonAddBreed);
            this.Controls.Add(this.textBoxAddBreed);
            this.Controls.Add(this.labelAddBreed);
            this.Name = "FormAddBreed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add dog breed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddBreed;
        private System.Windows.Forms.TextBox textBoxAddBreed;
        private System.Windows.Forms.Button buttonCancelBreed;
        private System.Windows.Forms.Button buttonExitBreed;
        public System.Windows.Forms.Button buttonAddBreed;
    }
}