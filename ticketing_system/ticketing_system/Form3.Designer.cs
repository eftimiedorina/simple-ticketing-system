namespace ticketing_system
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.lbNume = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRand = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLoc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPret = new System.Windows.Forms.Label();
            this.btnPrintPrev = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume:";
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Location = new System.Drawing.Point(189, 98);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(46, 17);
            this.lbNume.TabIndex = 2;
            this.lbNume.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rand:";
            // 
            // lbRand
            // 
            this.lbRand.AutoSize = true;
            this.lbRand.Location = new System.Drawing.Point(192, 137);
            this.lbRand.Name = "lbRand";
            this.lbRand.Size = new System.Drawing.Size(46, 17);
            this.lbRand.TabIndex = 4;
            this.lbRand.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loc:";
            // 
            // lbLoc
            // 
            this.lbLoc.AutoSize = true;
            this.lbLoc.Location = new System.Drawing.Point(333, 137);
            this.lbLoc.Name = "lbLoc";
            this.lbLoc.Size = new System.Drawing.Size(46, 17);
            this.lbLoc.TabIndex = 6;
            this.lbLoc.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pret:";
            // 
            // lbPret
            // 
            this.lbPret.AutoSize = true;
            this.lbPret.Location = new System.Drawing.Point(192, 178);
            this.lbPret.Name = "lbPret";
            this.lbPret.Size = new System.Drawing.Size(46, 17);
            this.lbPret.TabIndex = 8;
            this.lbPret.Text = "label5";
            // 
            // btnPrintPrev
            // 
            this.btnPrintPrev.Location = new System.Drawing.Point(175, 330);
            this.btnPrintPrev.Name = "btnPrintPrev";
            this.btnPrintPrev.Size = new System.Drawing.Size(146, 44);
            this.btnPrintPrev.TabIndex = 9;
            this.btnPrintPrev.Text = "Print preview";
            this.btnPrintPrev.UseVisualStyleBackColor = true;
            this.btnPrintPrev.Click += new System.EventHandler(this.btnPrintPrev_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ticketing_system.Properties.Resources.png_ticket_7;
            this.pictureBox1.Location = new System.Drawing.Point(23, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 404);
            this.Controls.Add(this.btnPrintPrev);
            this.Controls.Add(this.lbPret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbLoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbLoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPret;
        private System.Windows.Forms.Button btnPrintPrev;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}