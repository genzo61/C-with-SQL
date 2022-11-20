
namespace Secim_parti_grafik_uygulaması
{
    partial class frmoygiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmoygiriş));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtilçead = new System.Windows.Forms.TextBox();
            this.txtapartisi = new System.Windows.Forms.TextBox();
            this.txtbpartisi = new System.Windows.Forms.TextBox();
            this.txtcpartisi = new System.Windows.Forms.TextBox();
            this.txtdpartisi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btngrafikler = new System.Windows.Forms.Button();
            this.btnçıkış = new System.Windows.Forms.Button();
            this.btnoygiriiş = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Ad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "A partisi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "B partisi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "C partisi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "D partisi:";
            // 
            // txtilçead
            // 
            this.txtilçead.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtilçead.Location = new System.Drawing.Point(143, 32);
            this.txtilçead.Name = "txtilçead";
            this.txtilçead.Size = new System.Drawing.Size(195, 28);
            this.txtilçead.TabIndex = 5;
            // 
            // txtapartisi
            // 
            this.txtapartisi.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapartisi.Location = new System.Drawing.Point(143, 71);
            this.txtapartisi.Name = "txtapartisi";
            this.txtapartisi.Size = new System.Drawing.Size(195, 28);
            this.txtapartisi.TabIndex = 6;
            // 
            // txtbpartisi
            // 
            this.txtbpartisi.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbpartisi.Location = new System.Drawing.Point(143, 111);
            this.txtbpartisi.Name = "txtbpartisi";
            this.txtbpartisi.Size = new System.Drawing.Size(195, 28);
            this.txtbpartisi.TabIndex = 7;
            // 
            // txtcpartisi
            // 
            this.txtcpartisi.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpartisi.Location = new System.Drawing.Point(143, 145);
            this.txtcpartisi.Name = "txtcpartisi";
            this.txtcpartisi.Size = new System.Drawing.Size(195, 28);
            this.txtcpartisi.TabIndex = 8;
            // 
            // txtdpartisi
            // 
            this.txtdpartisi.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdpartisi.Location = new System.Drawing.Point(143, 179);
            this.txtdpartisi.Name = "txtdpartisi";
            this.txtdpartisi.Size = new System.Drawing.Size(195, 28);
            this.txtdpartisi.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btngrafikler);
            this.groupBox1.Controls.Add(this.btnçıkış);
            this.groupBox1.Controls.Add(this.btnoygiriiş);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdpartisi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcpartisi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbpartisi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtapartisi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtilçead);
            this.groupBox1.Location = new System.Drawing.Point(36, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 375);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btngrafikler
            // 
            this.btngrafikler.Location = new System.Drawing.Point(240, 250);
            this.btngrafikler.Name = "btngrafikler";
            this.btngrafikler.Size = new System.Drawing.Size(98, 31);
            this.btngrafikler.TabIndex = 12;
            this.btngrafikler.Text = "Grafikler";
            this.btngrafikler.UseVisualStyleBackColor = true;
            this.btngrafikler.Click += new System.EventHandler(this.btngrafikler_Click);
            // 
            // btnçıkış
            // 
            this.btnçıkış.Location = new System.Drawing.Point(136, 250);
            this.btnçıkış.Name = "btnçıkış";
            this.btnçıkış.Size = new System.Drawing.Size(98, 31);
            this.btnçıkış.TabIndex = 11;
            this.btnçıkış.Text = "Çıkış";
            this.btnçıkış.UseVisualStyleBackColor = true;
            // 
            // btnoygiriiş
            // 
            this.btnoygiriiş.Location = new System.Drawing.Point(136, 213);
            this.btnoygiriiş.Name = "btnoygiriiş";
            this.btnoygiriiş.Size = new System.Drawing.Size(202, 31);
            this.btnoygiriiş.TabIndex = 10;
            this.btnoygiriiş.Text = "Oy Grişi Yap";
            this.btnoygiriiş.UseVisualStyleBackColor = true;
            this.btnoygiriiş.Click += new System.EventHandler(this.btnoygiriiş_Click);
            // 
            // frmoygiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(501, 455);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmoygiriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtilçead;
        private System.Windows.Forms.TextBox txtapartisi;
        private System.Windows.Forms.TextBox txtbpartisi;
        private System.Windows.Forms.TextBox txtcpartisi;
        private System.Windows.Forms.TextBox txtdpartisi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btngrafikler;
        private System.Windows.Forms.Button btnçıkış;
        private System.Windows.Forms.Button btnoygiriiş;
    }
}

