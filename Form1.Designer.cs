namespace CourseWork_Vostrikov
{
    partial class Кинолог
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Кинолог));
            this.panelDataBase = new System.Windows.Forms.Panel();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdding = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOwnerDog = new System.Windows.Forms.Button();
            this.buttonDog = new System.Windows.Forms.Button();
            this.buttonOwners = new System.Windows.Forms.Button();
            this.buttonBreed = new System.Windows.Forms.Button();
            this.dataGridViewDataBase = new System.Windows.Forms.DataGridView();
            this.panelDataBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDataBase
            // 
            this.panelDataBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelDataBase.Controls.Add(this.buttonSelect);
            this.panelDataBase.Controls.Add(this.buttonDelete);
            this.panelDataBase.Controls.Add(this.buttonUpdate);
            this.panelDataBase.Controls.Add(this.buttonAdding);
            this.panelDataBase.Controls.Add(this.pictureBox1);
            this.panelDataBase.Controls.Add(this.buttonExit);
            this.panelDataBase.Controls.Add(this.buttonOwnerDog);
            this.panelDataBase.Controls.Add(this.buttonDog);
            this.panelDataBase.Controls.Add(this.buttonOwners);
            this.panelDataBase.Controls.Add(this.buttonBreed);
            this.panelDataBase.Controls.Add(this.dataGridViewDataBase);
            this.panelDataBase.Location = new System.Drawing.Point(0, 0);
            this.panelDataBase.Name = "panelDataBase";
            this.panelDataBase.Size = new System.Drawing.Size(905, 437);
            this.panelDataBase.TabIndex = 0;
            // 
            // buttonSelect
            // 
            this.buttonSelect.FlatAppearance.BorderSize = 0;
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSelect.Location = new System.Drawing.Point(-2, 297);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(167, 64);
            this.buttonSelect.TabIndex = 10;
            this.buttonSelect.Text = "Update";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(-2, 233);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(167, 64);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUpdate.Location = new System.Drawing.Point(-2, 169);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(167, 64);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Change";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdding
            // 
            this.buttonAdding.FlatAppearance.BorderSize = 0;
            this.buttonAdding.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonAdding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdding.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdding.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdding.Location = new System.Drawing.Point(-2, 105);
            this.buttonAdding.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdding.Name = "buttonAdding";
            this.buttonAdding.Size = new System.Drawing.Size(167, 64);
            this.buttonAdding.TabIndex = 7;
            this.buttonAdding.Text = "Adding";
            this.buttonAdding.UseVisualStyleBackColor = false;
            this.buttonAdding.Click += new System.EventHandler(this.ButtonAdding_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CourseWork_Vostrikov.Properties.Resources.icons8_картотека_96;
            this.pictureBox1.Location = new System.Drawing.Point(33, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 95);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.Location = new System.Drawing.Point(3, 384);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(162, 50);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonOwnerDog
            // 
            this.buttonOwnerDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonOwnerDog.FlatAppearance.BorderSize = 0;
            this.buttonOwnerDog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOwnerDog.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOwnerDog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOwnerDog.Location = new System.Drawing.Point(635, 0);
            this.buttonOwnerDog.Name = "buttonOwnerDog";
            this.buttonOwnerDog.Size = new System.Drawing.Size(162, 102);
            this.buttonOwnerDog.TabIndex = 4;
            this.buttonOwnerDog.Text = "Owner-Dog";
            this.buttonOwnerDog.UseVisualStyleBackColor = false;
            this.buttonOwnerDog.Click += new System.EventHandler(this.ButtonOwnerDog_Click);
            // 
            // buttonDog
            // 
            this.buttonDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonDog.FlatAppearance.BorderSize = 0;
            this.buttonDog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDog.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDog.Location = new System.Drawing.Point(476, 0);
            this.buttonDog.Name = "buttonDog";
            this.buttonDog.Size = new System.Drawing.Size(162, 102);
            this.buttonDog.TabIndex = 3;
            this.buttonDog.Text = "Dogs";
            this.buttonDog.UseVisualStyleBackColor = false;
            this.buttonDog.Click += new System.EventHandler(this.ButtonDog_Click);
            // 
            // buttonOwners
            // 
            this.buttonOwners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonOwners.FlatAppearance.BorderSize = 0;
            this.buttonOwners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOwners.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOwners.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOwners.Location = new System.Drawing.Point(320, 0);
            this.buttonOwners.Name = "buttonOwners";
            this.buttonOwners.Size = new System.Drawing.Size(162, 102);
            this.buttonOwners.TabIndex = 2;
            this.buttonOwners.Text = "Owners";
            this.buttonOwners.UseVisualStyleBackColor = false;
            this.buttonOwners.Click += new System.EventHandler(this.ButtonOwners_Click);
            // 
            // buttonBreed
            // 
            this.buttonBreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonBreed.FlatAppearance.BorderSize = 0;
            this.buttonBreed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBreed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBreed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBreed.Location = new System.Drawing.Point(165, 0);
            this.buttonBreed.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBreed.Name = "buttonBreed";
            this.buttonBreed.Size = new System.Drawing.Size(162, 102);
            this.buttonBreed.TabIndex = 1;
            this.buttonBreed.Text = "Breed";
            this.buttonBreed.UseVisualStyleBackColor = false;
            this.buttonBreed.Click += new System.EventHandler(this.ButtonBreed_Click);
            // 
            // dataGridViewDataBase
            // 
            this.dataGridViewDataBase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dataGridViewDataBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDataBase.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDataBase.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dataGridViewDataBase.Location = new System.Drawing.Point(165, 105);
            this.dataGridViewDataBase.Name = "dataGridViewDataBase";
            this.dataGridViewDataBase.Size = new System.Drawing.Size(738, 329);
            this.dataGridViewDataBase.TabIndex = 0;
            // 
            // Кинолог
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(905, 435);
            this.Controls.Add(this.panelDataBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(921, 473);
            this.MinimumSize = new System.Drawing.Size(921, 473);
            this.Name = "Кинолог";
            this.Text = "Клуб собаководов «Кинолог»";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.panelDataBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDataBase;
        private System.Windows.Forms.Button buttonBreed;
        private System.Windows.Forms.Button buttonOwners;
        private System.Windows.Forms.Button buttonDog;
        private System.Windows.Forms.Button buttonOwnerDog;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdding;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSelect;
        public System.Windows.Forms.DataGridView dataGridViewDataBase;
    }
}

