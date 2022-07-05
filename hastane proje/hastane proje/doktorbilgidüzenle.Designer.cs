
namespace hastane_proje
{
    partial class doktorbilgidüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doktorbilgidüzenle));
            this.btnbilgigüncelle = new System.Windows.Forms.Button();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtşifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbranş = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbilgigüncelle
            // 
            this.btnbilgigüncelle.BackColor = System.Drawing.Color.Lime;
            this.btnbilgigüncelle.Location = new System.Drawing.Point(146, 278);
            this.btnbilgigüncelle.Name = "btnbilgigüncelle";
            this.btnbilgigüncelle.Size = new System.Drawing.Size(169, 48);
            this.btnbilgigüncelle.TabIndex = 45;
            this.btnbilgigüncelle.Text = "Güncelle";
            this.btnbilgigüncelle.UseVisualStyleBackColor = false;
            this.btnbilgigüncelle.Click += new System.EventHandler(this.btnbilgigüncelle_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(146, 19);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(169, 31);
            this.txtad.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Ad:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(146, 69);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(169, 31);
            this.txtsoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "Soyad:";
            // 
            // txtşifre
            // 
            this.txtşifre.Location = new System.Drawing.Point(146, 167);
            this.txtşifre.Name = "txtşifre";
            this.txtşifre.Size = new System.Drawing.Size(169, 31);
            this.txtşifre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Şifre:";
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(146, 115);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(169, 31);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "TC Kimlik No:";
            // 
            // cmbbranş
            // 
            this.cmbbranş.FormattingEnabled = true;
            this.cmbbranş.Location = new System.Drawing.Point(146, 219);
            this.cmbbranş.Name = "cmbbranş";
            this.cmbbranş.Size = new System.Drawing.Size(169, 31);
            this.cmbbranş.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "BRANŞ:";
            // 
            // doktorbilgidüzenle
            // 
            this.AcceptButton = this.btnbilgigüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(349, 339);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbbranş);
            this.Controls.Add(this.btnbilgigüncelle);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtşifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimizeBox = false;
            this.Name = "doktorbilgidüzenle";
            this.Text = "Doktor Bilgi Güncelle";
            this.Load += new System.EventHandler(this.doktorbilgidüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbilgigüncelle;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtşifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbranş;
        private System.Windows.Forms.Label label3;
    }
}