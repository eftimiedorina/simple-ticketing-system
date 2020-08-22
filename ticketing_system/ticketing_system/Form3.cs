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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbNume.Text = Form2.nume;
            lbRand.Text = Form2.txtRand;
            lbLoc.Text = Form2.txtLoc;
            lbPret.Text = Form2.txtPret;

        }

        private void btnPrintPrev_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.png_ticket_7;
            Image img = bmp;
            e.Graphics.DrawImage(img, 25, 25,img.Width,img.Height);

            e.Graphics.DrawString("Nume: " + lbNume.Text,new Font("Arial",20,FontStyle.Regular),Brushes.Black, new Point(200,100));
            e.Graphics.DrawString("Rand: " + lbRand.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(200, 150));
            e.Graphics.DrawString("Loc: " + lbLoc.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(500, 150));
            e.Graphics.DrawString("Pret: " + lbPret.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(200, 200));
        }
    }
}
