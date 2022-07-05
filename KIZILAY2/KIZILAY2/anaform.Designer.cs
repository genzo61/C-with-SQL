
namespace KIZILAY2
{
    partial class anaform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaform));
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kişiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kişiadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kişisoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kişişehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kişimaaşDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kişidurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kişimeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kişikangrubuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblkızılayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kızlay2DataSet1 = new KIZILAY2.kızlay2DataSet1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btngrafik = new System.Windows.Forms.Button();
            this.btnistatislik = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbkangrubu = new System.Windows.Forms.ComboBox();
            this.txtmeslek = new System.Windows.Forms.TextBox();
            this.rdbekar = new System.Windows.Forms.RadioButton();
            this.rdevli = new System.Windows.Forms.RadioButton();
            this.msdmaaş = new System.Windows.Forms.MaskedTextBox();
            this.txtşehir = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tblkızılayTableAdapter = new KIZILAY2.kızlay2DataSet1TableAdapters.tblkızılayTableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkızılayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kızlay2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1037, 395);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "label9";
            this.label9.TextChanged += new System.EventHandler(this.label9_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(30, 510);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(1208, 275);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KAYITLAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kişiidDataGridViewTextBoxColumn,
            this.kişiadDataGridViewTextBoxColumn,
            this.kişisoyadDataGridViewTextBoxColumn,
            this.kişişehirDataGridViewTextBoxColumn,
            this.kişimaaşDataGridViewTextBoxColumn,
            this.kişidurumDataGridViewCheckBoxColumn,
            this.kişimeslekDataGridViewTextBoxColumn,
            this.kişikangrubuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblkızılayBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1200, 256);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // kişiidDataGridViewTextBoxColumn
            // 
            this.kişiidDataGridViewTextBoxColumn.DataPropertyName = "kişiid";
            this.kişiidDataGridViewTextBoxColumn.HeaderText = "kişiid";
            this.kişiidDataGridViewTextBoxColumn.Name = "kişiidDataGridViewTextBoxColumn";
            this.kişiidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kişiadDataGridViewTextBoxColumn
            // 
            this.kişiadDataGridViewTextBoxColumn.DataPropertyName = "kişiad";
            this.kişiadDataGridViewTextBoxColumn.HeaderText = "kişiad";
            this.kişiadDataGridViewTextBoxColumn.Name = "kişiadDataGridViewTextBoxColumn";
            // 
            // kişisoyadDataGridViewTextBoxColumn
            // 
            this.kişisoyadDataGridViewTextBoxColumn.DataPropertyName = "kişisoyad";
            this.kişisoyadDataGridViewTextBoxColumn.HeaderText = "kişisoyad";
            this.kişisoyadDataGridViewTextBoxColumn.Name = "kişisoyadDataGridViewTextBoxColumn";
            // 
            // kişişehirDataGridViewTextBoxColumn
            // 
            this.kişişehirDataGridViewTextBoxColumn.DataPropertyName = "kişişehir";
            this.kişişehirDataGridViewTextBoxColumn.HeaderText = "kişişehir";
            this.kişişehirDataGridViewTextBoxColumn.Name = "kişişehirDataGridViewTextBoxColumn";
            // 
            // kişimaaşDataGridViewTextBoxColumn
            // 
            this.kişimaaşDataGridViewTextBoxColumn.DataPropertyName = "kişimaaş";
            this.kişimaaşDataGridViewTextBoxColumn.HeaderText = "kişimaaş";
            this.kişimaaşDataGridViewTextBoxColumn.Name = "kişimaaşDataGridViewTextBoxColumn";
            // 
            // kişidurumDataGridViewCheckBoxColumn
            // 
            this.kişidurumDataGridViewCheckBoxColumn.DataPropertyName = "kişidurum";
            this.kişidurumDataGridViewCheckBoxColumn.HeaderText = "kişidurum";
            this.kişidurumDataGridViewCheckBoxColumn.Name = "kişidurumDataGridViewCheckBoxColumn";
            // 
            // kişimeslekDataGridViewTextBoxColumn
            // 
            this.kişimeslekDataGridViewTextBoxColumn.DataPropertyName = "kişimeslek";
            this.kişimeslekDataGridViewTextBoxColumn.HeaderText = "kişimeslek";
            this.kişimeslekDataGridViewTextBoxColumn.Name = "kişimeslekDataGridViewTextBoxColumn";
            // 
            // kişikangrubuDataGridViewTextBoxColumn
            // 
            this.kişikangrubuDataGridViewTextBoxColumn.DataPropertyName = "kişikangrubu";
            this.kişikangrubuDataGridViewTextBoxColumn.HeaderText = "kişikangrubu";
            this.kişikangrubuDataGridViewTextBoxColumn.Name = "kişikangrubuDataGridViewTextBoxColumn";
            // 
            // tblkızılayBindingSource
            // 
            this.tblkızılayBindingSource.DataMember = "tblkızılay";
            this.tblkızılayBindingSource.DataSource = this.kızlay2DataSet1;
            // 
            // kızlay2DataSet1
            // 
            this.kızlay2DataSet1.DataSetName = "kızlay2DataSet1";
            this.kızlay2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(971, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btngrafik);
            this.groupBox2.Controls.Add(this.btnistatislik);
            this.groupBox2.Controls.Add(this.btntemizle);
            this.groupBox2.Controls.Add(this.btngüncelle);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Controls.Add(this.btnlistele);
            this.groupBox2.Location = new System.Drawing.Point(672, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(267, 474);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞLEMLER";
            // 
            // btngrafik
            // 
            this.btngrafik.Location = new System.Drawing.Point(67, 406);
            this.btngrafik.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btngrafik.Name = "btngrafik";
            this.btngrafik.Size = new System.Drawing.Size(137, 39);
            this.btngrafik.TabIndex = 13;
            this.btngrafik.Text = "GRAFİK";
            this.btngrafik.UseVisualStyleBackColor = true;
            this.btngrafik.Click += new System.EventHandler(this.btngrafik_Click);
            // 
            // btnistatislik
            // 
            this.btnistatislik.Location = new System.Drawing.Point(67, 352);
            this.btnistatislik.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnistatislik.Name = "btnistatislik";
            this.btnistatislik.Size = new System.Drawing.Size(137, 39);
            this.btnistatislik.TabIndex = 12;
            this.btnistatislik.Text = "İSTATİSLİK";
            this.btnistatislik.UseVisualStyleBackColor = true;
            this.btnistatislik.Click += new System.EventHandler(this.btnistatislik_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(67, 295);
            this.btntemizle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(137, 39);
            this.btntemizle.TabIndex = 11;
            this.btntemizle.Text = "TEMİZLE";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(67, 237);
            this.btngüncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(137, 39);
            this.btngüncelle.TabIndex = 10;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(67, 183);
            this.btnsil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(137, 39);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(67, 120);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(137, 39);
            this.btnkaydet.TabIndex = 8;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(67, 61);
            this.btnlistele.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(137, 39);
            this.btnlistele.TabIndex = 7;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbkangrubu);
            this.groupBox1.Controls.Add(this.txtmeslek);
            this.groupBox1.Controls.Add(this.rdbekar);
            this.groupBox1.Controls.Add(this.rdevli);
            this.groupBox1.Controls.Add(this.msdmaaş);
            this.groupBox1.Controls.Add(this.txtşehir);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(30, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(601, 474);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONEL BİLGİLERİ";
            // 
            // cmbkangrubu
            // 
            this.cmbkangrubu.FormattingEnabled = true;
            this.cmbkangrubu.Items.AddRange(new object[] {
            "A RH +",
            "A RH - ",
            "B RH +",
            "B RH -",
            "0 RH + ",
            "0 RH - ",
            "AB RH +",
            "AB RH - "});
            this.cmbkangrubu.Location = new System.Drawing.Point(235, 415);
            this.cmbkangrubu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbkangrubu.Name = "cmbkangrubu";
            this.cmbkangrubu.Size = new System.Drawing.Size(203, 21);
            this.cmbkangrubu.TabIndex = 6;
            // 
            // txtmeslek
            // 
            this.txtmeslek.Location = new System.Drawing.Point(235, 355);
            this.txtmeslek.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmeslek.Name = "txtmeslek";
            this.txtmeslek.Size = new System.Drawing.Size(203, 20);
            this.txtmeslek.TabIndex = 5;
            // 
            // rdbekar
            // 
            this.rdbekar.AutoSize = true;
            this.rdbekar.Location = new System.Drawing.Point(337, 306);
            this.rdbekar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbekar.Name = "rdbekar";
            this.rdbekar.Size = new System.Drawing.Size(61, 17);
            this.rdbekar.TabIndex = 15;
            this.rdbekar.TabStop = true;
            this.rdbekar.Text = "BEKAR";
            this.rdbekar.UseVisualStyleBackColor = true;
            this.rdbekar.CheckedChanged += new System.EventHandler(this.rdbekar_CheckedChanged);
            // 
            // rdevli
            // 
            this.rdevli.AutoSize = true;
            this.rdevli.Location = new System.Drawing.Point(235, 306);
            this.rdevli.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdevli.Name = "rdevli";
            this.rdevli.Size = new System.Drawing.Size(48, 17);
            this.rdevli.TabIndex = 14;
            this.rdevli.TabStop = true;
            this.rdevli.Text = "EVLİ";
            this.rdevli.UseVisualStyleBackColor = true;
            this.rdevli.CheckedChanged += new System.EventHandler(this.rdevli_CheckedChanged);
            // 
            // msdmaaş
            // 
            this.msdmaaş.Location = new System.Drawing.Point(235, 240);
            this.msdmaaş.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.msdmaaş.Mask = "0000";
            this.msdmaaş.Name = "msdmaaş";
            this.msdmaaş.Size = new System.Drawing.Size(203, 20);
            this.msdmaaş.TabIndex = 4;
            this.msdmaaş.ValidatingType = typeof(int);
            // 
            // txtşehir
            // 
            this.txtşehir.Location = new System.Drawing.Point(235, 195);
            this.txtşehir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtşehir.Name = "txtşehir";
            this.txtşehir.Size = new System.Drawing.Size(203, 20);
            this.txtşehir.TabIndex = 3;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(235, 147);
            this.txtsoyad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(203, 20);
            this.txtsoyad.TabIndex = 2;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(235, 96);
            this.txtad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(203, 20);
            this.txtad.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(235, 44);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(203, 20);
            this.txtid.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KİŞİ İD:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 419);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "KİŞİ KAN GRUBU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "KİŞİ AD:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 365);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "KİŞİ MESLEK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KİŞİ SOYAD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "KİŞİ DURUM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "KİŞİ ŞEHİR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "KİŞİ MAAŞ:";
            // 
            // tblkızılayTableAdapter
            // 
            this.tblkızılayTableAdapter.ClearBeforeFill = true;
            // 
            // anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 795);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "anaform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkızılayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kızlay2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btngrafik;
        private System.Windows.Forms.Button btnistatislik;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbkangrubu;
        private System.Windows.Forms.TextBox txtmeslek;
        private System.Windows.Forms.RadioButton rdbekar;
        private System.Windows.Forms.RadioButton rdevli;
        private System.Windows.Forms.MaskedTextBox msdmaaş;
        private System.Windows.Forms.TextBox txtşehir;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private kızlay2DataSet1 kızlay2DataSet1;
        private System.Windows.Forms.BindingSource tblkızılayBindingSource;
        private kızlay2DataSet1TableAdapters.tblkızılayTableAdapter tblkızılayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kişiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kişiadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kişisoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kişişehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kişimaaşDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kişidurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kişimeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kişikangrubuDataGridViewTextBoxColumn;
    }
}

