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
    public partial class Form2 : Form
    {
        private Button[,] btnMatrix = new Button[5, 8];
        private  Button btn;
        public static string nume = "";
        public static string txtRand = "";
        public static string txtLoc = "";
        public static string txtPret = "";

        public Form2()
        {
            InitializeComponent();

        }
        private void seat_ready()
        {
            int noSeat = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    btnMatrix[i, j].Text = noSeat.ToString();
                    btnMatrix[i, j].Font = new Font("Microsoft Sans Serif", 6.70f);
                    btnMatrix[i,j].Tag= noSeat++;
                    btnMatrix[i, j].Click += MatrixButtonClick;
                   // btnMatrix[i, j].FlatStyle = FlatStyle.Flat;
                   // btnMatrix[i, j].BackColor = Color.Gray;
                    
                }

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            /*----------------------------------------------------- fill the combobox Piesa---------------------------------------------------- */
          /*  SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dorina\Desktop\c#\Eftimie Dorina\ticketing_system\ticketing_system\Database.mdf;Integrated Security=True");
            SqlCommand query = new SqlCommand("select idPiesa,titlu from piesa",sqlCon);
            SqlDataReader reader;

            
          
                sqlCon.Open();
                reader = query.ExecuteReader();

                while (reader.Read())
                {
                    cmbPiesa.Items.Add(reader["titlu"]);
                }
            cmbPiesa.DisplayMember = "titlu";
            cmbPiesa.ValueMember = "idPiesa";
            sqlCon.Close();*/
            
  using (SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dorina\Desktop\c#\Eftimie Dorina\ticketing_system\ticketing_system\Database.mdf;Integrated Security=True"))
            {
                string query = "Select idPiesa,titlu from piesa";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
                DataTable dtb = new DataTable();
                da.Fill(dtb);

                cmbPiesa.DataSource = dtb;
                cmbPiesa.DisplayMember = "titlu";
                cmbPiesa.ValueMember = "idPiesa";
            }

               btnMatrix = new Button[,] {
                { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 },
                { btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16 },
                {btn17,btn18,btn19,btn20,btn21,btn22,btn23,btn24 },
                { btn25, btn26, btn27, btn28, btn29, btn30, btn31, btn32 },
                { btn33, btn34, btn35, btn36, btn37, btn38, btn39, btn40 }};

            seat_ready();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Click(object sender, EventArgs e)
        {

        }

        private void cmbPiesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPiesa.SelectedIndex > 0)
            {

              //   DataRowView dataRowView = cmbPiesa.SelectedItem as DataRowView;
                // var selectedItem = cmbPiesa.SelectedItem;
                SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dorina\Desktop\c#\Eftimie Dorina\ticketing_system\ticketing_system\Database.mdf;Integrated Security=True");

                SqlCommand query = new SqlCommand("Select * from piesa where idPiesa= @Piesa");
                SqlCommand queryBooked = new SqlCommand("Select * from rezervariPiesa2 where idPiesa= @Piesa1");


                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Piesa";
                param.Value = cmbPiesa.SelectedValue;
              //  param.Value = dataRowView.Row["idPiesa"].ToString();
                query.Parameters.Add(param);
                //  int piesa = ((DataRowView)cmbPiesa.SelectedValue).Row.Field<int>("idPiesa");
                queryBooked.Parameters.AddWithValue("@Piesa1", cmbPiesa.SelectedValue);
              //  queryBooked.Parameters.AddWithValue("@Piesa1", dataRowView.Row["idPiesa"].ToString());
           

                sqlCon.Open();
                query.Connection = sqlCon;
                queryBooked.Connection = sqlCon;

                SqlDataAdapter da = new SqlDataAdapter(query);
                SqlDataAdapter daBooked = new SqlDataAdapter(queryBooked);
                DataSet dt = new DataSet();
                DataSet dtBooked = new DataSet();
                da.Fill(dt);
                daBooked.Fill(dtBooked);

                /* afisarea datei */
                DateTime cell = dt.Tables[0].Rows[0].Field<DateTime>(3); // luam valoarea celulei
                datePicker.Value = cell;

                Console.WriteLine(cmbPiesa.SelectedIndex);


                /* afisare rezervari locuri */
                // verificam ca idPiesa sa corespunda cu idPiesa a locului selectat

                if (dt.Tables[0].Rows[0].Field<int>(0) == dtBooked.Tables[0].Rows[0].Field<int>(0))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            /*  if(dtBooked.Rows[0][i].ToString() != "0")
                              {
                                  var rand = (int)dtBooked.Rows[i][1];
                                  var loc = (int)dtBooked.Rows[i][2];
                                  Button btn = btnMatrix[rand, loc];
                                  btn.BackColor = Color.Salmon;
                              }
                              else
                              {
                                  btnMatrix[i, j].BackColor = Color.Silver;
                              }*/

                            if (btnMatrix[i, j].BackColor == Color.Salmon)
                             btnMatrix[i, j].BackColor = Color.Silver;
                            else
                            {
                                btnMatrix[i, j].BackColor = Color.Silver;
                            }
                            
                        }
                    }
                    foreach (DataRow dtRow in dtBooked.Tables[0].Rows)
                    {
                        
                        var rand = (int)dtRow[1];
                        var loc = (int)dtRow[2];

                        Button btn = btnMatrix[rand, loc];
                        btn.BackColor = Color.Salmon;

                    }

                }

                sqlCon.Close();
            }
        }
        /**
        * --------------------------------------------------
                            BOOK SEAT
         --------------------------------------------------
            */

        private void button45_Click(object sender, EventArgs e)
        {
            if (btn == null)
            {
                MessageBox.Show("Nu ati selectat niciun loc!");
            } if(txtNume.Text == "" || cmbPret.ValueMember == "")
            {
                MessageBox.Show("Completati toate campurile!");
            }
            else
            {
                Console.WriteLine(getRow((int)this.btn.Tag));
                Console.WriteLine(getCol((int)this.btn.Tag));

                SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dorina\Desktop\c#\Eftimie Dorina\ticketing_system\ticketing_system\Database.mdf;Integrated Security=True");
                string query = "insert into dbo.rezervariPiesa2(idPiesa,rand,loc,nume) values(@ID,@RAND,@LOC,@NUME)";
 
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters.Add("@RAND", SqlDbType.Int);
                cmd.Parameters.Add("@LOC", SqlDbType.Int);
                cmd.Parameters.Add("@NUME", SqlDbType.Text);

                cmd.Parameters["@ID"].Value = (int)cmbPiesa.SelectedValue;
                cmd.Parameters["@RAND"].Value = getRow((int)this.btn.Tag);
                cmd.Parameters["@LOC"].Value = getCol((int)this.btn.Tag);
                cmd.Parameters["@NUME"].Value = txtNume.Text;
                sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();

                nume = txtNume.Text;
                txtRand = getRow((int)this.btn.Tag).ToString();
                txtLoc = getCol((int)this.btn.Tag).ToString();
                txtPret = cmbPret.Text;

                Form3 form3 = new Form3();
                form3.Show();
            }
        }

        private void MatrixButtonClick(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                btn = sender as Button;
                btn.BackColor = Color.Salmon;
                Console.WriteLine(getCol((int)btn.Tag));
            }
        }
        private int getRow(int index)
        {
            for(int i = 0; i < 5; i++) {
                
                    for(int j = 0; j < 8; j++)
                {
                    int value = Int32.Parse(btnMatrix[i, j].Text);
                    if (value == index) return i+1;
                }
                       
            }
            return 0;
        }
        private int getCol(int index)
        {
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 8; j++)
                {
                    int value = Int32.Parse(btnMatrix[i, j].Text);
                    if (value == index) return j+1;
                }

            }
            return 0;
        }

/*
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }*/
    }

       
    }
