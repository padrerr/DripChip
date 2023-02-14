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
    public partial class Authentication : Form
    {
        DB db = new DB();

        public Authentication()
        {
            InitializeComponent();
        }
        private void Authentication_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                Passwordbox.UseSystemPasswordChar = false;
            }
            else
            {
                Passwordbox.UseSystemPasswordChar = true;
            }
        }

        private void Passwordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if((Logbox.Text=="")&&(Passwordbox.Text=="")) 
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                var email = Logbox.Text;
                var pass = Passwordbox.Text;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();

                string querystring = $"select id_user,Mail,Password from account_information where Mail='{email}' and Password='{pass}' ";
                SqlCommand command = new SqlCommand(querystring, db.GetConnection());
                sqlDataAdapter.SelectCommand = command;
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    MessageBox.Show("Запрос успешнно выполнен!");
                    FuncSystem funcSystem = new FuncSystem();
                    funcSystem.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверные авторизационные данные");
                }
                Info.m = Logbox.Text;
                Info.p = Passwordbox.Text;
            }
            
        }

        private void Logbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
