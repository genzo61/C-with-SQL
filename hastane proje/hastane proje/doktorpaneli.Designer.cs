
namespace hastane_proje
{
    partial class doktorpaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doktorpaneli));
            this.txtad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbranş = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtşifre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(125, 23);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(144, 31);
            this.txtad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "AD:";
            // 
            // cmbbranş
            // 
            this.cmbbranş.FormattingEnabled = true;
            this.cmbbranş.Location = new System.Drawing.Point(125, 134);
            this.cmbbranş.Name = "cmbbranş";
            this.cmbbranş.Size = new System.Drawing.Size(144, 31);
            this.cmbbranş.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "ŞİFRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "TC NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "BRANŞ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "SOYAD:";
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(125, 187);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(144, 31);
            this.msktc.TabIndex = 4;
            this.msktc.ValidatingType = typeof(int);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(125, 76);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(144, 31);
            this.txtsoyad.TabIndex = 2;
            // 
            // txtşifre
            // 
            this.txtşifre.Location = new System.Drawing.Point(125, 249);
            this.txtşifre.Name = "txtşifre";
            this.txtşifre.Size = new System.Drawing.Size(144, 31);
            this.txtşifre.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(816, 343);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Yellow;
            this.btnekle.Location = new System.Drawing.Point(125, 298);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(69, 31);
            this.btnekle.TabIndex = 25;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Red;
            this.btnsil.Location = new System.Drawing.Point(200, 298);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(69, 31);
            this.btnsil.TabIndex = 26;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btngüncelle.Location = new System.Drawing.Point(125, 335);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(144, 31);
            this.btngüncelle.TabIndex = 27;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // doktorpaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1134, 377);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtşifre);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbbranş);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "doktorpaneli";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.doktorpaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbranş;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtşifre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
    }
}