namespace DripChip
{
    partial class Authentication
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
            this.Enter = new System.Windows.Forms.Button();
            this.Login_or_mail = new System.Windows.Forms.Label();
            this.Logbox = new System.Windows.Forms.TextBox();
            this.Passwordbox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter.Location = new System.Drawing.Point(352, 311);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(95, 36);
            this.Enter.TabIndex = 0;
            this.Enter.Text = "Войти";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Login_or_mail
            // 
            this.Login_or_mail.AutoSize = true;
            this.Login_or_mail.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_or_mail.Location = new System.Drawing.Point(247, 132);
            this.Login_or_mail.Name = "Login_or_mail";
            this.Login_or_mail.Size = new System.Drawing.Size(334, 26);
            this.Login_or_mail.TabIndex = 1;
            this.Login_or_mail.Text = "Введите адрес электронной почты:";
            // 
            // Logbox
            // 
            this.Logbox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Logbox.Location = new System.Drawing.Point(237, 161);
            this.Logbox.Multiline = true;
            this.Logbox.Name = "Logbox";
            this.Logbox.Size = new System.Drawing.Size(344, 41);
            this.Logbox.TabIndex = 2;
            this.Logbox.TextChanged += new System.EventHandler(this.Logbox_TextChanged);
            // 
            // Passwordbox
            // 
            this.Passwordbox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passwordbox.Location = new System.Drawing.Point(237, 243);
            this.Passwordbox.Multiline = true;
            this.Passwordbox.Name = "Passwordbox";
            this.Passwordbox.PasswordChar = '*';
            this.Passwordbox.Size = new System.Drawing.Size(344, 41);
            this.Passwordbox.TabIndex = 3;
            this.Passwordbox.TextChanged += new System.EventHandler(this.Passwordbox_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(360, 214);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(87, 26);
            this.Password.TabIndex = 4;
            this.Password.Text = "Пароль:";
            // 
            // Register
            // 
            this.Register.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Register.Location = new System.Drawing.Point(326, 353);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(144, 36);
            this.Register.TabIndex = 5;
            this.Register.Text = "Регистрация";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(587, 265);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Показать пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Passwordbox);
            this.Controls.Add(this.Logbox);
            this.Controls.Add(this.Login_or_mail);
            this.Controls.Add(this.Enter);
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.Load += new System.EventHandler(this.Authentication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Login_or_mail;
        private System.Windows.Forms.TextBox Passwordbox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TextBox Logbox;
        public System.Windows.Forms.Button Enter;
    }
}

