using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticketing_system
{
    public partial class DetaliiForm : Form
    {
        Image image;
        public DetaliiForm(Image image)
        {
            InitializeComponent();
            this.image = image;
        }

        private void DetaliiForm_Load(object sender, EventArgs e)
        {
          
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            txtTitlu.Text = ProgramForm2.titlu;
            txtData.Text = ProgramForm2.data;
            txtDescriere.Text = ProgramForm2.descriere;
            txtDistributia.Text = ProgramForm2.distributie;
            
        }

        private void txtDescriere_Click(object sender, EventArgs e)
        {

        }

        private void txtDistributia_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 rezervari = new Form2();
            rezervari.ShowDialog();

        }
    }
}
