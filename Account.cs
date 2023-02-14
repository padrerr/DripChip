using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DripChip
{
    public partial class Account : Form
    {
        DB db = new DB();   
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            MailBox.Text = Info.m;
            Passbox.Text = Info.p;
            View();
            
        }

        private void ChangerButton_Click(object sender, EventArgs e)
        {
           


            if(ChangerButton.Enabled==true)
            {
                Namebox.Enabled = true;
                Lastname_box.Enabled = true;
                Passbox.Enabled = true;
                MailBox.Enabled = true;
                ConfirmButton.Visible = true;
                ChangerButton.Visible = false;
            }

        }
        
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
           if((Namebox.Text == "") | (Lastname_box.Text == "") | (MailBox.Text == "") | (Passbox.Text=="")) 
            {
                MessageBox.Show("Не все поля заполнены!");
            }
           else
            {
                var firstname = Namebox.Text;
                var lastname = Lastname_box.Text;
                var email = MailBox.Text;
                var password = Passbox.Text;

                string querystring = $"update account_information set Mail='{email}', Password='{password}',Name=N'{firstname}',LastName=N'{lastname}' WHERE Mail='{Info.m}'";
                SqlCommand command = new SqlCommand(querystring, db.GetConnection());
                db.OpenConnection();


                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные успешно изменены!");
                    ChangerButton.Visible = true;
                    Namebox.Enabled = false;
                    Lastname_box.Enabled = false;
                    Passbox.Enabled = false;
                    MailBox.Enabled = false;
                    ConfirmButton.Visible = false;
                }
                else
                {
                    MessageBox.Show("Упс, что то пошло не так.");
                }
                db.CloseConnection();
            }
            
            

        }
       private void View()
        {
            db.OpenConnection();
            
            SqlCommand cmd = new SqlCommand("Select Name, Mail,LastName, password from account_information where Mail=@Mail",db.GetConnection());
            cmd.Parameters.AddWithValue("@Mail",MailBox.Text);
            SqlDataReader dr= cmd.ExecuteReader();
            while(dr.Read())
            {
                Namebox.Text = dr.GetValue(0).ToString();
                Lastname_box.Text=dr.GetValue(2).ToString();
            }
            db.CloseConnection( );
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                Passbox.UseSystemPasswordChar = false;
            }
            else
            {
                Passbox.UseSystemPasswordChar = true;
            }
        }

        private void MailBox_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void Back_Click(object sender, EventArgs e)
        {
            FuncSystem funcSystem = new FuncSystem();
            funcSystem.Show();
            Hide();
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
           

            string querystring = $"delete from account_information where Mail='{Info.m}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());
            db.OpenConnection();


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт удален!");
                Namebox.Text = "";
                Lastname_box.Text = "";
                MailBox.Text = "";
                Passbox.Text = "";
                Authentication authentication = new Authentication();
                authentication.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Упс, что то пошло не так.");
            }
            db.CloseConnection();
        }
    }
}
