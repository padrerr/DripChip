namespace DripChip
{
    partial class Register
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
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastNameBox
            // 
            this.LastNameBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameBox.Location = new System.Drawing.Point(338, 165);
            this.LastNameBox.Multiline = true;
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(290, 37);
            this.LastNameBox.TabIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.Location = new System.Drawing.Point(258, 133);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(50, 26);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "Имя";
            // 
            // Registerbutton
            // 
            this.Registerbutton.BackColor = System.Drawing.Color.White;
            this.Registerbutton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registerbutton.Location = new System.Drawing.Point(338, 308);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(290, 42);
            this.Registerbutton.TabIndex = 2;
            this.Registerbutton.Text = "Зарегистрироваться";
            this.Registerbutton.UseVisualStyleBackColor = false;
            this.Registerbutton.Click += new System.EventHandler(this.Registerbutton_Click);
            this.Registerbutton.MouseEnter += new System.EventHandler(this.Registerbutton_MouseEnter);
            this.Registerbutton.MouseLeave += new System.EventHandler(this.Registerbutton_MouseLeave);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(57, 218);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(251, 26);
            this.Email.TabIndex = 3;
            this.Email.Text = "Адрес электронной почты";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(214, 176);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(94, 26);
            this.LastName.TabIndex = 4;
            this.LastName.Text = "Фамилия";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(232, 257);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(76, 26);
            this.Password.TabIndex = 5;
            this.Password.Text = "пароль";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(338, 123);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(290, 36);
            this.NameBox.TabIndex = 6;
            // 
            // MailBox
            // 
            this.MailBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MailBox.Location = new System.Drawing.Point(338, 208);
            this.MailBox.Multiline = true;
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(290, 36);
            this.MailBox.TabIndex = 7;
            this.MailBox.TextChanged += new System.EventHandler(this.MailBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.Location = new System.Drawing.Point(338, 250);
            this.PasswordBox.Multiline = true;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(290, 33);
            this.PasswordBox.TabIndex = 8;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(799, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(37, 38);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 508);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.MailBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox MailBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label CloseButton;
    }
}