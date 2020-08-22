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
    public partial class ProgramForm2 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dorina\Desktop\c#\Eftimie Dorina\ticketing_system\ticketing_system\Database.mdf;Integrated Security=True");

        public static string titlu = "";
        public static string data = "";
        public static string descriere = "";
        public static string distributie = "";

        public ProgramForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand query = new SqlCommand("Select * from piesa",sqlCon);
            sqlCon.Open();
            query.Connection = sqlCon;
            SqlDataAdapter da = new SqlDataAdapter(query);
            DataTable dt = new DataTable();
            da.Fill(dt);

            titlu = dt.Rows[0].Field<String>(1);
           // var objResult = 
            data = dt.Rows[0].Field<DateTime>(3).ToString("dddd, dd MMMM yyyy");
            descriere = dt.Rows[0].Field<String>(2);
            distributie = dt.Rows[0].Field<String>(4);

            sqlCon.Close();

            DetaliiForm detaliiForm = new DetaliiForm(pictureBox1.Image);
            this.Hide();
            detaliiForm.ShowDialog();
            this.Show();
            
        }

        private void ProgramForm2_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand query = new SqlCommand("Select * from piesa",sqlCon);
            sqlCon.Open();
            query.Connection = sqlCon;
            SqlDataAdapter da = new SqlDataAdapter(query);
            DataTable dt = new DataTable();
            da.Fill(dt);

            titlu = dt.Rows[1].Field<String>(1);
            data = dt.Rows[1].Field<DateTime>(3).ToString("dddd, dd MMMM yyyy");
            descriere = dt.Rows[1].Field<String>(2);
            distributie = dt.Rows[1].Field<String>(4);

            sqlCon.Close();

            DetaliiForm detaliiForm = new DetaliiForm(pictureBox2.Image);
            this.Hide();
            detaliiForm.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("Select * from piesa", sqlCon);
            sqlCon.Open();
            query.Connection = sqlCon;
            SqlDataAdapter da = new SqlDataAdapter(query);
            DataTable dt = new DataTable();
            da.Fill(dt);

            titlu = dt.Rows[2].Field<String>(1);
            data = dt.Rows[2].Field<DateTime>(3).ToString("dddd, dd MMMM yyyy");
            descriere = dt.Rows[2].Field<String>(2);
            distributie = dt.Rows[2].Field<String>(4);

            sqlCon.Close();

            DetaliiForm detaliiForm = new DetaliiForm(pictureBox3.Image);
            this.Hide();
            detaliiForm.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("Select * from piesa", sqlCon);
            sqlCon.Open();
            query.Connection = sqlCon;
            SqlDataAdapter da = new SqlDataAdapter(query);
            DataTable dt = new DataTable();
            da.Fill(dt);

            titlu = dt.Rows[3].Field<String>(1);
            data = dt.Rows[3].Field<DateTime>(3).ToString("dddd, dd MMMM yyyy");
            descriere = dt.Rows[3].Field<String>(2);
            distributie = dt.Rows[3].Field<String>(4);

            sqlCon.Close();

            DetaliiForm detaliiForm = new DetaliiForm(pictureBox4.Image);
            this.Hide();
            detaliiForm.ShowDialog();
            this.Show();
        }
    }
}
