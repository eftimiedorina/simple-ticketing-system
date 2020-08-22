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

namespace ticketing_system
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dorina\Desktop\c#\Eftimie Dorina\ticketing_system\ticketing_system\Database.mdf;Integrated Security=True");
            string query = "Select * from [Table] where username = '" + txtUsername.Text.Trim()+"' and password = '" + txtPassword.Text.Trim() +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            if(dtb.Rows.Count == 1)
            {
                Form1 mainForm = new Form1();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Username or password is worng. Please try again!");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
