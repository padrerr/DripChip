using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DripChip
{
    public partial class Register : Form
    {
        DB db = new DB();
        public Register()
        {
            InitializeComponent();
        }
        private Boolean checkuser()
        {

           
            var email = MailBox.Text;
            
            string querystring = $"select id_user, Mail from account_information where Mail='{email}'";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Аккаунт с таким email уже существует");
                return true;
            }
            else
            {
                return false;
            }


        }

        private void Registerbutton_Click(object sender, EventArgs e)
        { 
            
            if ((NameBox.Text=="")|(LastNameBox.Text=="")|(MailBox.Text=="")|(PasswordBox.Text=="")) 
                 {
                     MessageBox.Show("Не все поля заполнены!");
                 }
            
            else
            {
                if (checkuser())

                {
                    return;
                }
                var firstname = NameBox.Text;
                var lastname = LastNameBox.Text;
                var email = MailBox.Text;
                var password = PasswordBox.Text;

                string querystring = $"insert into account_information(Mail, LastName, Name, Password) values('{email}',N'{lastname}',N'{firstname}','{password}')";
                SqlCommand command = new SqlCommand(querystring, db.GetConnection());
                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запрос успешно выполнен");
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
        

        private void MailBox_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Firebrick;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor= Color.Black;
        }

        private void Registerbutton_MouseEnter(object sender, EventArgs e)
        {
            Registerbutton.ForeColor = Color.HotPink;
        }

        private void Registerbutton_MouseLeave(object sender, EventArgs e)
        {
            Registerbutton.ForeColor= Color.Black;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            MailBox.MaxLength = 62;
            NameBox.MaxLength = 62 ;
            LastNameBox.MaxLength=62;
            PasswordBox.MaxLength=62 ;
        }
    }
}
