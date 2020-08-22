namespace ticketing_system
{
    partial class DetaliiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetaliiForm));
            this.txtTitlu = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.Label();
            this.txtDistributia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescriere = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitlu
            // 
            this.txtTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitlu.ForeColor = System.Drawing.Color.Gray;
            this.txtTitlu.Location = new System.Drawing.Point(293, 23);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(333, 26);
            this.txtTitlu.TabIndex = 1;
            this.txtTitlu.Text = "txtTitlu";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(383, 107);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(256, 18);
            this.txtData.TabIndex = 3;
            this.txtData.Text = "label1";
            // 
            // txtDistributia
            // 
            this.txtDistributia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistributia.Location = new System.Drawing.Point(383, 174);
            this.txtDistributia.Name = "txtDistributia";
            this.txtDistributia.Size = new System.Drawing.Size(240, 58);
            this.txtDistributia.TabIndex = 4;
            this.txtDistributia.Text = "label1";
            this.txtDistributia.Click += new System.EventHandler(this.txtDistributia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(294, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(290, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Distributia:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(258, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Rezerva Bilet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 418);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGreen;
            this.label3.Location = new System.Drawing.Point(290, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descriere:";
            // 
            // txtDescriere
            // 
            this.txtDescriere.BackColor = System.Drawing.Color.White;
            this.txtDescriere.Location = new System.Drawing.Point(386, 277);
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.ReadOnly = true;
            this.txtDescriere.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDescriere.Size = new System.Drawing.Size(251, 164);
            this.txtDescriere.TabIndex = 9;
            this.txtDescriere.Text = "";
            // 
            // DetaliiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 561);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDistributia);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtTitlu);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetaliiForm";
            this.Text = "Detali";
            this.Load += new System.EventHandler(this.DetaliiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtTitlu;
        private System.Windows.Forms.Label txtData;
        private System.Windows.Forms.Label txtDistributia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDescriere;
    }
}