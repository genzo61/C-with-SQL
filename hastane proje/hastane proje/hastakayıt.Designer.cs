
namespace hastane_proje
{
    partial class hastakayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hastakayıt));
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtşifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.btnkayıtyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(160, 135);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(169, 33);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "TC Kimlik No:";
            // 
            // txtşifre
            // 
            this.txtşifre.Location = new System.Drawing.Point(160, 238);
            this.txtşifre.Name = "txtşifre";
            this.txtşifre.Size = new System.Drawing.Size(169, 33);
            this.txtşifre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Şifre:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(160, 89);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(169, 33);
            this.txtsoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Soyad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(160, 39);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(169, 33);
            this.txtad.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ad:";
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(160, 186);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(169, 33);
            this.msktelefon.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cinsiyet:";
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(160, 288);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(169, 34);
            this.cmbcinsiyet.TabIndex = 6;
            // 
            // btnkayıtyap
            // 
            this.btnkayıtyap.BackColor = System.Drawing.Color.Lime;
            this.btnkayıtyap.Location = new System.Drawing.Point(160, 338);
            this.btnkayıtyap.Name = "btnkayıtyap";
            this.btnkayıtyap.Size = new System.Drawing.Size(169, 32);
            this.btnkayıtyap.TabIndex = 7;
            this.btnkayıtyap.Text = "Kayıt Yap";
            this.btnkayıtyap.UseVisualStyleBackColor = false;
            this.btnkayıtyap.Click += new System.EventHandler(this.btnkayıtyap_Click);
            // 
            // hastakayıt
            // 
            this.AcceptButton = this.btnkayıtyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(382, 401);
            this.Controls.Add(this.btnkayıtyap);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtşifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "hastakayıt";
            this.Text = "Hasta Kayıt";
            this.Load += new System.EventHandler(this.hastakayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtşifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.Button btnkayıtyap;
    }
}