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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 6)
                imageNumber = 1;
            sliderPic.ImageLocation = string.Format(@"poze\{0}.jpg",imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReserved_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sliderPic_Click(object sender, EventArgs e)
        {

        }

        private void btnProgram_Click(object sender, EventArgs e)
        {
            ProgramForm2 programForm = new ProgramForm2();
            programForm.ShowDialog();
          //  this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }
    }
}
