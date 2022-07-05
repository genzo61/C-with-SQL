
namespace hastane_proje
{
    partial class doktordetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doktordetay));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchşikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltcno = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnçıkış = new System.Windows.Forms.Button();
            this.btnduyurular = new System.Windows.Forms.Button();
            this.btnbilgidüzenle = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(347, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(673, 543);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(667, 511);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchşikayet);
            this.groupBox2.Location = new System.Drawing.Point(12, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 234);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // rchşikayet
            // 
            this.rchşikayet.Location = new System.Drawing.Point(6, 43);
            this.rchşikayet.Name = "rchşikayet";
            this.rchşikayet.Size = new System.Drawing.Size(304, 187);
            this.rchşikayet.TabIndex = 1;
            this.rchşikayet.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbltcno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 178);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(149, 93);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(82, 26);
            this.lbladsoyad.TabIndex = 18;
            this.lbladsoyad.Text = "null null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "AD SOYAD:";
            // 
            // lbltcno
            // 
            this.lbltcno.AutoSize = true;
            this.lbltcno.Location = new System.Drawing.Point(148, 50);
            this.lbltcno.Name = "lbltcno";
            this.lbltcno.Size = new System.Drawing.Size(133, 26);
            this.lbltcno.TabIndex = 16;
            this.lbltcno.Text = "00000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "TC NO:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnçıkış);
            this.groupBox4.Controls.Add(this.btnduyurular);
            this.groupBox4.Controls.Add(this.btnbilgidüzenle);
            this.groupBox4.Location = new System.Drawing.Point(12, 445);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 126);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kısa Yollar";
            // 
            // btnçıkış
            // 
            this.btnçıkış.Location = new System.Drawing.Point(6, 84);
            this.btnçıkış.Name = "btnçıkış";
            this.btnçıkış.Size = new System.Drawing.Size(300, 36);
            this.btnçıkış.TabIndex = 2;
            this.btnçıkış.Text = "Çıkış";
            this.btnçıkış.UseVisualStyleBackColor = true;
            this.btnçıkış.Click += new System.EventHandler(this.btnçıkış_Click);
            // 
            // btnduyurular
            // 
            this.btnduyurular.Location = new System.Drawing.Point(159, 42);
            this.btnduyurular.Name = "btnduyurular";
            this.btnduyurular.Size = new System.Drawing.Size(147, 36);
            this.btnduyurular.TabIndex = 1;
            this.btnduyurular.Text = "Duyurular";
            this.btnduyurular.UseVisualStyleBackColor = true;
            this.btnduyurular.Click += new System.EventHandler(this.btnduyurular_Click);
            // 
            // btnbilgidüzenle
            // 
            this.btnbilgidüzenle.Location = new System.Drawing.Point(6, 42);
            this.btnbilgidüzenle.Name = "btnbilgidüzenle";
            this.btnbilgidüzenle.Size = new System.Drawing.Size(147, 36);
            this.btnbilgidüzenle.TabIndex = 0;
            this.btnbilgidüzenle.Text = "Bilgi Düzenle";
            this.btnbilgidüzenle.UseVisualStyleBackColor = true;
            this.btnbilgidüzenle.Click += new System.EventHandler(this.btnbilgidüzenle_Click);
            // 
            // doktordetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1039, 579);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "doktordetay";
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.doktordetay_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rchşikayet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltcno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnçıkış;
        private System.Windows.Forms.Button btnduyurular;
        private System.Windows.Forms.Button btnbilgidüzenle;
    }
}