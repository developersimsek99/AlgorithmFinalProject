namespace AlgorithmFinalProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.radioBilgisayar = new System.Windows.Forms.RadioButton();
            this.radioTelefon = new System.Windows.Forms.RadioButton();
            this.radioTablet = new System.Windows.Forms.RadioButton();
            this.dgwProduct2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureTablet = new System.Windows.Forms.PictureBox();
            this.pictureBilgisayar = new System.Windows.Forms.PictureBox();
            this.pictureTelefon = new System.Windows.Forms.PictureBox();
            this.lblStokFiyat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStokAdet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTablet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBilgisayar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTelefon)).BeginInit();
            this.SuspendLayout();
            // 
            // radioBilgisayar
            // 
            this.radioBilgisayar.AutoSize = true;
            this.radioBilgisayar.Location = new System.Drawing.Point(153, 51);
            this.radioBilgisayar.Name = "radioBilgisayar";
            this.radioBilgisayar.Size = new System.Drawing.Size(69, 17);
            this.radioBilgisayar.TabIndex = 0;
            this.radioBilgisayar.TabStop = true;
            this.radioBilgisayar.Text = "Bilgisayar";
            this.radioBilgisayar.UseVisualStyleBackColor = true;
            this.radioBilgisayar.CheckedChanged += new System.EventHandler(this.radioBilgisayar_CheckedChanged);
            // 
            // radioTelefon
            // 
            this.radioTelefon.AutoSize = true;
            this.radioTelefon.Location = new System.Drawing.Point(228, 51);
            this.radioTelefon.Name = "radioTelefon";
            this.radioTelefon.Size = new System.Drawing.Size(89, 17);
            this.radioTelefon.TabIndex = 1;
            this.radioTelefon.TabStop = true;
            this.radioTelefon.Text = "Cep Telefonu";
            this.radioTelefon.UseVisualStyleBackColor = true;
            this.radioTelefon.CheckedChanged += new System.EventHandler(this.radioTelefon_CheckedChanged);
            // 
            // radioTablet
            // 
            this.radioTablet.AutoSize = true;
            this.radioTablet.Location = new System.Drawing.Point(323, 51);
            this.radioTablet.Name = "radioTablet";
            this.radioTablet.Size = new System.Drawing.Size(55, 17);
            this.radioTablet.TabIndex = 2;
            this.radioTablet.TabStop = true;
            this.radioTablet.Text = "Tablet";
            this.radioTablet.UseVisualStyleBackColor = true;
            this.radioTablet.CheckedChanged += new System.EventHandler(this.radioTablet_CheckedChanged);
            // 
            // dgwProduct2
            // 
            this.dgwProduct2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct2.Location = new System.Drawing.Point(12, 84);
            this.dgwProduct2.Name = "dgwProduct2";
            this.dgwProduct2.Size = new System.Drawing.Size(527, 150);
            this.dgwProduct2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Anasayfa     >";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(79, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "     Stok Detay";
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(463, 9);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureTablet);
            this.groupBox1.Controls.Add(this.pictureBilgisayar);
            this.groupBox1.Controls.Add(this.pictureTelefon);
            this.groupBox1.Controls.Add(this.lblStokFiyat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblStokAdet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 138);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "₺";
            // 
            // pictureTablet
            // 
            this.pictureTablet.Image = ((System.Drawing.Image)(resources.GetObject("pictureTablet.Image")));
            this.pictureTablet.Location = new System.Drawing.Point(383, 15);
            this.pictureTablet.Name = "pictureTablet";
            this.pictureTablet.Size = new System.Drawing.Size(136, 113);
            this.pictureTablet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTablet.TabIndex = 9;
            this.pictureTablet.TabStop = false;
            this.pictureTablet.Visible = false;
            // 
            // pictureBilgisayar
            // 
            this.pictureBilgisayar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBilgisayar.Image")));
            this.pictureBilgisayar.Location = new System.Drawing.Point(383, 15);
            this.pictureBilgisayar.Name = "pictureBilgisayar";
            this.pictureBilgisayar.Size = new System.Drawing.Size(136, 113);
            this.pictureBilgisayar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBilgisayar.TabIndex = 5;
            this.pictureBilgisayar.TabStop = false;
            this.pictureBilgisayar.Visible = false;
            // 
            // pictureTelefon
            // 
            this.pictureTelefon.Image = ((System.Drawing.Image)(resources.GetObject("pictureTelefon.Image")));
            this.pictureTelefon.Location = new System.Drawing.Point(383, 15);
            this.pictureTelefon.Name = "pictureTelefon";
            this.pictureTelefon.Size = new System.Drawing.Size(136, 113);
            this.pictureTelefon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTelefon.TabIndex = 8;
            this.pictureTelefon.TabStop = false;
            this.pictureTelefon.Visible = false;
            // 
            // lblStokFiyat
            // 
            this.lblStokFiyat.AutoSize = true;
            this.lblStokFiyat.Location = new System.Drawing.Point(175, 78);
            this.lblStokFiyat.Name = "lblStokFiyat";
            this.lblStokFiyat.Size = new System.Drawing.Size(0, 13);
            this.lblStokFiyat.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Toplam Birim Fiyatı :";
            // 
            // lblStokAdet
            // 
            this.lblStokAdet.AutoSize = true;
            this.lblStokAdet.Location = new System.Drawing.Point(175, 47);
            this.lblStokAdet.Name = "lblStokAdet";
            this.lblStokAdet.Size = new System.Drawing.Size(0, 13);
            this.lblStokAdet.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Toplam Stok Adedi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürünün;";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwProduct2);
            this.Controls.Add(this.radioTablet);
            this.Controls.Add(this.radioTelefon);
            this.Controls.Add(this.radioBilgisayar);
            this.Name = "Form2";
            this.Text = "Stok Detay";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTablet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBilgisayar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTelefon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBilgisayar;
        private System.Windows.Forms.RadioButton radioTelefon;
        private System.Windows.Forms.RadioButton radioTablet;
        private System.Windows.Forms.DataGridView dgwProduct2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStokFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStokAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBilgisayar;
        private System.Windows.Forms.PictureBox pictureTelefon;
        private System.Windows.Forms.PictureBox pictureTablet;
        private System.Windows.Forms.Label label5;
    }
}