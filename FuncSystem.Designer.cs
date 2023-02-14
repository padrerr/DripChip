namespace DripChip
{
    partial class FuncSystem
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
            this.AccountButton = new System.Windows.Forms.Button();
            this.AnimalButton = new System.Windows.Forms.Button();
            this.AnimalVisitedLocationButton = new System.Windows.Forms.Button();
            this.LocationPointButton = new System.Windows.Forms.Button();
            this.AnimalTypeButton = new System.Windows.Forms.Button();
            this.BackToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountButton
            // 
            this.AccountButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountButton.Location = new System.Drawing.Point(71, 113);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(137, 92);
            this.AccountButton.TabIndex = 0;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // AnimalButton
            // 
            this.AnimalButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnimalButton.Location = new System.Drawing.Point(189, 198);
            this.AnimalButton.Name = "AnimalButton";
            this.AnimalButton.Size = new System.Drawing.Size(137, 92);
            this.AnimalButton.TabIndex = 1;
            this.AnimalButton.Text = "Animal";
            this.AnimalButton.UseVisualStyleBackColor = true;
            this.AnimalButton.Click += new System.EventHandler(this.AnimalButton_Click);
            // 
            // AnimalVisitedLocationButton
            // 
            this.AnimalVisitedLocationButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnimalVisitedLocationButton.Location = new System.Drawing.Point(450, 190);
            this.AnimalVisitedLocationButton.Name = "AnimalVisitedLocationButton";
            this.AnimalVisitedLocationButton.Size = new System.Drawing.Size(138, 109);
            this.AnimalVisitedLocationButton.TabIndex = 2;
            this.AnimalVisitedLocationButton.Text = "Animal Visited Location";
            this.AnimalVisitedLocationButton.UseVisualStyleBackColor = true;
            // 
            // LocationPointButton
            // 
            this.LocationPointButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationPointButton.Location = new System.Drawing.Point(321, 113);
            this.LocationPointButton.Name = "LocationPointButton";
            this.LocationPointButton.Size = new System.Drawing.Size(137, 92);
            this.LocationPointButton.TabIndex = 3;
            this.LocationPointButton.Text = "Location Point";
            this.LocationPointButton.UseVisualStyleBackColor = true;
            // 
            // AnimalTypeButton
            // 
            this.AnimalTypeButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnimalTypeButton.Location = new System.Drawing.Point(580, 113);
            this.AnimalTypeButton.Name = "AnimalTypeButton";
            this.AnimalTypeButton.Size = new System.Drawing.Size(137, 92);
            this.AnimalTypeButton.TabIndex = 4;
            this.AnimalTypeButton.Text = "Animal Type";
            this.AnimalTypeButton.UseVisualStyleBackColor = true;
            // 
            // BackToLogin
            // 
            this.BackToLogin.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToLogin.Location = new System.Drawing.Point(556, 352);
            this.BackToLogin.Name = "BackToLogin";
            this.BackToLogin.Size = new System.Drawing.Size(232, 86);
            this.BackToLogin.TabIndex = 5;
            this.BackToLogin.Text = "Вернуться к авторизации";
            this.BackToLogin.UseVisualStyleBackColor = true;
            this.BackToLogin.Click += new System.EventHandler(this.BackToLogin_Click);
            // 
            // FuncSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToLogin);
            this.Controls.Add(this.AnimalTypeButton);
            this.Controls.Add(this.LocationPointButton);
            this.Controls.Add(this.AnimalVisitedLocationButton);
            this.Controls.Add(this.AnimalButton);
            this.Controls.Add(this.AccountButton);
            this.Name = "FuncSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuncSystem";
            this.Load += new System.EventHandler(this.FuncSystem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button AnimalButton;
        private System.Windows.Forms.Button AnimalVisitedLocationButton;
        private System.Windows.Forms.Button LocationPointButton;
        private System.Windows.Forms.Button AnimalTypeButton;
        private System.Windows.Forms.Button BackToLogin;
    }
}