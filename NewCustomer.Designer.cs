namespace WinFormAllInOne
{
    partial class NewCustomerForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.rdbGenderMale = new System.Windows.Forms.RadioButton();
            this.rdbGenderFemale = new System.Windows.Forms.RadioButton();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.rdbGenderOther = new System.Windows.Forms.RadioButton();
            this.grbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(21, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(257, 9);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // rdbGenderMale
            // 
            this.rdbGenderMale.AutoSize = true;
            this.rdbGenderMale.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdbGenderMale.Location = new System.Drawing.Point(6, 19);
            this.rdbGenderMale.Name = "rdbGenderMale";
            this.rdbGenderMale.Size = new System.Drawing.Size(48, 17);
            this.rdbGenderMale.TabIndex = 2;
            this.rdbGenderMale.TabStop = true;
            this.rdbGenderMale.Text = "Male";
            this.rdbGenderMale.UseVisualStyleBackColor = true;
            // 
            // rdbGenderFemale
            // 
            this.rdbGenderFemale.AutoSize = true;
            this.rdbGenderFemale.Location = new System.Drawing.Point(60, 19);
            this.rdbGenderFemale.Name = "rdbGenderFemale";
            this.rdbGenderFemale.Size = new System.Drawing.Size(59, 17);
            this.rdbGenderFemale.TabIndex = 3;
            this.rdbGenderFemale.TabStop = true;
            this.rdbGenderFemale.Text = "Female";
            this.rdbGenderFemale.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(84, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(321, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.rdbGenderOther);
            this.grbGender.Controls.Add(this.rdbGenderMale);
            this.grbGender.Controls.Add(this.rdbGenderFemale);
            this.grbGender.Location = new System.Drawing.Point(24, 62);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(176, 41);
            this.grbGender.TabIndex = 8;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Gender";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(214, 121);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(101, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register now";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // rdbGenderOther
            // 
            this.rdbGenderOther.AutoSize = true;
            this.rdbGenderOther.Location = new System.Drawing.Point(125, 19);
            this.rdbGenderOther.Name = "rdbGenderOther";
            this.rdbGenderOther.Size = new System.Drawing.Size(51, 17);
            this.rdbGenderOther.TabIndex = 4;
            this.rdbGenderOther.TabStop = true;
            this.rdbGenderOther.Text = "Other";
            this.rdbGenderOther.UseVisualStyleBackColor = true;
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.grbGender);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "NewCustomerForm";
            this.Text = "Create new customer";
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.RadioButton rdbGenderMale;
        private System.Windows.Forms.RadioButton rdbGenderFemale;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.RadioButton rdbGenderOther;
    }
}

