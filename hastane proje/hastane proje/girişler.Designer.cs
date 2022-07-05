
namespace hastane_proje
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
            this.btnhastagiriş = new System.Windows.Forms.Button();
            this.btndoktorgiriş = new System.Windows.Forms.Button();
            this.btnsekretergiriş = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhastagiriş
            // 
            this.btnhastagiriş.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhastagiriş.BackgroundImage")));
            this.btnhastagiriş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhastagiriş.Location = new System.Drawing.Point(48, 137);
            this.btnhastagiriş.Name = "btnhastagiriş";
            this.btnhastagiriş.Size = new System.Drawing.Size(129, 110);
            this.btnhastagiriş.TabIndex = 0;
            this.btnhastagiriş.UseVisualStyleBackColor = true;
            this.btnhastagiriş.Click += new System.EventHandler(this.btnhastagiriş_Click);
            // 
            // btndoktorgiriş
            // 
            this.btndoktorgiriş.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndoktorgiriş.BackgroundImage")));
            this.btndoktorgiriş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoktorgiriş.Location = new System.Drawing.Point(232, 137);
            this.btndoktorgiriş.Name = "btndoktorgiriş";
            this.btndoktorgiriş.Size = new System.Drawing.Size(129, 110);
            this.btndoktorgiriş.TabIndex = 1;
            this.btndoktorgiriş.UseVisualStyleBackColor = true;
            this.btndoktorgiriş.Click += new System.EventHandler(this.btndoktorgiriş_Click);
            // 
            // btnsekretergiriş
            // 
            this.btnsekretergiriş.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsekretergiriş.BackgroundImage")));
            this.btnsekretergiriş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsekretergiriş.Location = new System.Drawing.Point(410, 137);
            this.btnsekretergiriş.Name = "btnsekretergiriş";
            this.btnsekretergiriş.Size = new System.Drawing.Size(129, 110);
            this.btnsekretergiriş.TabIndex = 2;
            this.btnsekretergiriş.UseVisualStyleBackColor = true;
            this.btnsekretergiriş.Click += new System.EventHandler(this.btnsekretergiriş_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "HASTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "DOKTOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "SEKRETER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "Heart Beat Hospital";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(581, 282);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsekretergiriş);
            this.Controls.Add(this.btndoktorgiriş);
            this.Controls.Add(this.btnhastagiriş);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Heart Beat Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhastagiriş;
        private System.Windows.Forms.Button btndoktorgiriş;
        private System.Windows.Forms.Button btnsekretergiriş;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

