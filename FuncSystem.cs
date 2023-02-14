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
    public partial class FuncSystem : Form
    {

        public FuncSystem()
        {
            InitializeComponent();
        }
        DB db = new DB();

        private void AccountButton_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            Hide();
        }

        private void FuncSystem_Load(object sender, EventArgs e)
        {

        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            Authentication authentication = new Authentication();
            authentication.ShowDialog();
            this.Hide();
        }

        private void AnimalButton_Click(object sender, EventArgs e)
        {

        }
    }
}
