
namespace filmkütüphaensi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfilmad = new System.Windows.Forms.TextBox();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlink = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btntamekran = new System.Windows.Forms.Button();
            this.btnhakkımızda = new System.Windows.Forms.Button();
            this.btnrenkdeğiştir = new System.Windows.Forms.Button();
            this.btnçıkış = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1560, 170);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 560);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filmler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(653, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(910, 560);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekran";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 29);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(904, 528);
            this.webBrowser1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "Düzenli Yapım...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1074, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Aqua;
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnkaydet);
            this.groupBox3.Controls.Add(this.txtlink);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtkategori);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtfilmad);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(359, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 560);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Film ad:";
            // 
            // txtfilmad
            // 
            this.txtfilmad.Location = new System.Drawing.Point(101, 77);
            this.txtfilmad.Name = "txtfilmad";
            this.txtfilmad.Size = new System.Drawing.Size(184, 33);
            this.txtfilmad.TabIndex = 1;
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(101, 116);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Size = new System.Drawing.Size(184, 33);
            this.txtkategori.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori:";
            // 
            // txtlink
            // 
            this.txtlink.Location = new System.Drawing.Point(101, 155);
            this.txtlink.Name = "txtlink";
            this.txtlink.Size = new System.Drawing.Size(184, 33);
            this.txtlink.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Link:";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(101, 194);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(181, 30);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnçıkış);
            this.groupBox4.Controls.Add(this.btnrenkdeğiştir);
            this.groupBox4.Controls.Add(this.btnhakkımızda);
            this.groupBox4.Controls.Add(this.btntamekran);
            this.groupBox4.Location = new System.Drawing.Point(6, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 311);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ek İşlemler";
            // 
            // btntamekran
            // 
            this.btntamekran.Location = new System.Drawing.Point(13, 81);
            this.btntamekran.Name = "btntamekran";
            this.btntamekran.Size = new System.Drawing.Size(257, 30);
            this.btntamekran.TabIndex = 8;
            this.btntamekran.Text = "Tam Ekran";
            this.btntamekran.UseVisualStyleBackColor = true;
            // 
            // btnhakkımızda
            // 
            this.btnhakkımızda.Location = new System.Drawing.Point(13, 117);
            this.btnhakkımızda.Name = "btnhakkımızda";
            this.btnhakkımızda.Size = new System.Drawing.Size(257, 30);
            this.btnhakkımızda.TabIndex = 9;
            this.btnhakkımızda.Text = "Hakkımızda";
            this.btnhakkımızda.UseVisualStyleBackColor = true;
            this.btnhakkımızda.Click += new System.EventHandler(this.btnhakkımızda_Click);
            // 
            // btnrenkdeğiştir
            // 
            this.btnrenkdeğiştir.Location = new System.Drawing.Point(13, 153);
            this.btnrenkdeğiştir.Name = "btnrenkdeğiştir";
            this.btnrenkdeğiştir.Size = new System.Drawing.Size(257, 30);
            this.btnrenkdeğiştir.TabIndex = 10;
            this.btnrenkdeğiştir.Text = "Renk Değiştir";
            this.btnrenkdeğiştir.UseVisualStyleBackColor = true;
            this.btnrenkdeğiştir.Click += new System.EventHandler(this.btnrenkdeğiştir_Click);
            // 
            // btnçıkış
            // 
            this.btnçıkış.Location = new System.Drawing.Point(13, 189);
            this.btnçıkış.Name = "btnçıkış";
            this.btnçıkış.Size = new System.Drawing.Size(257, 30);
            this.btnçıkış.TabIndex = 11;
            this.btnçıkış.Text = "Çıkış";
            this.btnçıkış.UseVisualStyleBackColor = true;
            this.btnçıkış.Click += new System.EventHandler(this.btnçıkış_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 528);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1572, 739);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtlink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfilmad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnçıkış;
        private System.Windows.Forms.Button btnrenkdeğiştir;
        private System.Windows.Forms.Button btnhakkımızda;
        private System.Windows.Forms.Button btntamekran;
        private System.Windows.Forms.Button btnkaydet;
    }
}

