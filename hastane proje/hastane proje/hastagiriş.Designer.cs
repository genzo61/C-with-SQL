﻿
namespace hastane_proje
{
    partial class hastagiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hastagiriş));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnküyeol = new System.Windows.Forms.LinkLabel();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.txtşifre = new System.Windows.Forms.TextBox();
            this.btngirişyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // lnküyeol
            // 
            this.lnküyeol.AutoSize = true;
            this.lnküyeol.Location = new System.Drawing.Point(404, 137);
            this.lnküyeol.Name = "lnküyeol";
            this.lnküyeol.Size = new System.Drawing.Size(76, 23);
            this.lnküyeol.TabIndex = 3;
            this.lnküyeol.TabStop = true;
            this.lnküyeol.Text = "Üye Ol";
            this.lnküyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnküyeol_LinkClicked);
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(222, 90);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(165, 29);
            this.msktc.TabIndex = 4;
            this.msktc.ValidatingType = typeof(int);
            // 
            // txtşifre
            // 
            this.txtşifre.Location = new System.Drawing.Point(222, 131);
            this.txtşifre.Name = "txtşifre";
            this.txtşifre.Size = new System.Drawing.Size(165, 29);
            this.txtşifre.TabIndex = 5;
            this.txtşifre.UseSystemPasswordChar = true;
            // 
            // btngirişyap
            // 
            this.btngirişyap.Location = new System.Drawing.Point(266, 166);
            this.btngirişyap.Name = "btngirişyap";
            this.btngirişyap.Size = new System.Drawing.Size(121, 35);
            this.btngirişyap.TabIndex = 6;
            this.btngirişyap.Text = "Giriş Yap";
            this.btngirişyap.UseVisualStyleBackColor = true;
            this.btngirişyap.Click += new System.EventHandler(this.btngirişyap_Click);
            // 
            // hastagiriş
            // 
            this.AcceptButton = this.btngirişyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(533, 233);
            this.Controls.Add(this.btngirişyap);
            this.Controls.Add(this.txtşifre);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.lnküyeol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MinimizeBox = false;
            this.Name = "hastagiriş";
            this.Text = "Hasta Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnküyeol;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.TextBox txtşifre;
        private System.Windows.Forms.Button btngirişyap;
    }
}