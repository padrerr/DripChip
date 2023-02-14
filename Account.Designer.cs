namespace DripChip
{
    partial class Account
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
            this.Passbox = new System.Windows.Forms.TextBox();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.Lastname_box = new System.Windows.Forms.TextBox();
            this.ChangerButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Passbox
            // 
            this.Passbox.Enabled = false;
            this.Passbox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passbox.Location = new System.Drawing.Point(293, 175);
            this.Passbox.Multiline = true;
            this.Passbox.Name = "Passbox";
            this.Passbox.PasswordChar = '*';
            this.Passbox.Size = new System.Drawing.Size(290, 33);
            this.Passbox.TabIndex = 16;
            // 
            // MailBox
            // 
            this.MailBox.Enabled = false;
            this.MailBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MailBox.Location = new System.Drawing.Point(293, 133);
            this.MailBox.Multiline = true;
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(290, 36);
            this.MailBox.TabIndex = 15;
            this.MailBox.TextChanged += new System.EventHandler(this.MailBox_TextChanged);
            // 
            // Namebox
            // 
            this.Namebox.Enabled = false;
            this.Namebox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Namebox.Location = new System.Drawing.Point(293, 48);
            this.Namebox.Multiline = true;
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(290, 36);
            this.Namebox.TabIndex = 14;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(187, 182);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(81, 26);
            this.Password.TabIndex = 13;
            this.Password.Text = "Пароль";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(169, 101);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(94, 26);
            this.LastName.TabIndex = 12;
            this.LastName.Text = "Фамилия";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(12, 143);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(251, 26);
            this.Email.TabIndex = 11;
            this.Email.Text = "Адрес электронной почты";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.Location = new System.Drawing.Point(213, 58);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(50, 26);
            this.FirstName.TabIndex = 10;
            this.FirstName.Text = "Имя";
            // 
            // Lastname_box
            // 
            this.Lastname_box.Enabled = false;
            this.Lastname_box.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lastname_box.Location = new System.Drawing.Point(293, 90);
            this.Lastname_box.Multiline = true;
            this.Lastname_box.Name = "Lastname_box";
            this.Lastname_box.Size = new System.Drawing.Size(290, 37);
            this.Lastname_box.TabIndex = 9;
            // 
            // ChangerButton
            // 
            this.ChangerButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangerButton.Location = new System.Drawing.Point(293, 239);
            this.ChangerButton.Name = "ChangerButton";
            this.ChangerButton.Size = new System.Drawing.Size(141, 76);
            this.ChangerButton.TabIndex = 17;
            this.ChangerButton.Text = "Изменить данные";
            this.ChangerButton.UseVisualStyleBackColor = true;
            this.ChangerButton.Click += new System.EventHandler(this.ChangerButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmButton.Location = new System.Drawing.Point(465, 239);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(147, 76);
            this.ConfirmButton.TabIndex = 18;
            this.ConfirmButton.Text = "Подтвердить изменения?";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Visible = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAccountButton.Location = new System.Drawing.Point(12, 362);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(141, 76);
            this.DeleteAccountButton.TabIndex = 19;
            this.DeleteAccountButton.Text = "Удалить аккаунт";
            this.DeleteAccountButton.UseVisualStyleBackColor = true;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteAccountButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(589, 189);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 19);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Показать пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(647, 378);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(141, 60);
            this.Back.TabIndex = 21;
            this.Back.Text = "Вернуться в главное меню";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.DeleteAccountButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ChangerButton);
            this.Controls.Add(this.Passbox);
            this.Controls.Add(this.MailBox);
            this.Controls.Add(this.Namebox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Lastname_box);
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Passbox;
        public System.Windows.Forms.TextBox MailBox;
        public System.Windows.Forms.TextBox Namebox;
        public System.Windows.Forms.Label Password;
        public System.Windows.Forms.Label LastName;
        public System.Windows.Forms.Label Email;
        public System.Windows.Forms.Label FirstName;
        public System.Windows.Forms.TextBox Lastname_box;
        public System.Windows.Forms.Button ChangerButton;
        public System.Windows.Forms.Button ConfirmButton;
        public System.Windows.Forms.Button DeleteAccountButton;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.Button Back;
    }
}