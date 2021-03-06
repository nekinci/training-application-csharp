﻿namespace EgitimUygulamasi.View
{
    partial class MedyaDegistir
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
            this.imageLists = new System.Windows.Forms.ListBox();
            this.cmbKategori = new MetroFramework.Controls.MetroComboBox();
            this.groupSeciliResim = new System.Windows.Forms.GroupBox();
            this.vlcPlayer1 = new EgitimUygulamasi.View.VlcPlayer();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.lblMedyaismi = new System.Windows.Forms.Label();
            this.btnYeniMedya = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDuzenle = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupSeciliResim.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageLists
            // 
            this.imageLists.FormattingEnabled = true;
            this.imageLists.Location = new System.Drawing.Point(12, 55);
            this.imageLists.Name = "imageLists";
            this.imageLists.Size = new System.Drawing.Size(292, 316);
            this.imageLists.TabIndex = 0;
            this.imageLists.SelectedIndexChanged += new System.EventHandler(this.imageLists_SelectedIndexChanged);
            // 
            // cmbKategori
            // 
            this.cmbKategori.Enabled = false;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.ItemHeight = 23;
            this.cmbKategori.Location = new System.Drawing.Point(13, 20);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(291, 29);
            this.cmbKategori.TabIndex = 2;
            this.cmbKategori.UseSelectable = true;
            // 
            // groupSeciliResim
            // 
            this.groupSeciliResim.Controls.Add(this.vlcPlayer1);
            this.groupSeciliResim.Controls.Add(this.txtPath);
            this.groupSeciliResim.Controls.Add(this.lblPath);
            this.groupSeciliResim.Controls.Add(this.txtIsim);
            this.groupSeciliResim.Controls.Add(this.lblMedyaismi);
            this.groupSeciliResim.Location = new System.Drawing.Point(310, 20);
            this.groupSeciliResim.Name = "groupSeciliResim";
            this.groupSeciliResim.Size = new System.Drawing.Size(292, 305);
            this.groupSeciliResim.TabIndex = 3;
            this.groupSeciliResim.TabStop = false;
            this.groupSeciliResim.Text = "Seçilen Medya:";
            // 
            // vlcPlayer1
            // 
            this.vlcPlayer1.Location = new System.Drawing.Point(11, 19);
            this.vlcPlayer1.Name = "vlcPlayer1";
            this.vlcPlayer1.Size = new System.Drawing.Size(266, 195);
            this.vlcPlayer1.TabIndex = 5;
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(77, 274);
            this.txtPath.MinimumSize = new System.Drawing.Size(200, 27);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(200, 20);
            this.txtPath.TabIndex = 4;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(8, 281);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(67, 13);
            this.lblPath.TabIndex = 3;
            this.lblPath.Text = "Medya Path:";
            // 
            // txtIsim
            // 
            this.txtIsim.Enabled = false;
            this.txtIsim.Location = new System.Drawing.Point(77, 241);
            this.txtIsim.MinimumSize = new System.Drawing.Size(200, 27);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(200, 20);
            this.txtIsim.TabIndex = 2;
            // 
            // lblMedyaismi
            // 
            this.lblMedyaismi.AutoSize = true;
            this.lblMedyaismi.Location = new System.Drawing.Point(7, 248);
            this.lblMedyaismi.Name = "lblMedyaismi";
            this.lblMedyaismi.Size = new System.Drawing.Size(63, 13);
            this.lblMedyaismi.TabIndex = 1;
            this.lblMedyaismi.Text = "Medya İsmi:";
            // 
            // btnYeniMedya
            // 
            this.btnYeniMedya.Depth = 0;
            this.btnYeniMedya.Location = new System.Drawing.Point(310, 331);
            this.btnYeniMedya.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYeniMedya.Name = "btnYeniMedya";
            this.btnYeniMedya.Primary = true;
            this.btnYeniMedya.Size = new System.Drawing.Size(160, 40);
            this.btnYeniMedya.TabIndex = 4;
            this.btnYeniMedya.Text = "Yeni Medya";
            this.btnYeniMedya.UseVisualStyleBackColor = true;
            this.btnYeniMedya.Click += new System.EventHandler(this.btnYeniMedya_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialFlatButton1.Enabled = false;
            this.materialFlatButton1.Location = new System.Drawing.Point(556, 333);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(45, 36);
            this.materialFlatButton1.TabIndex = 5;
            this.materialFlatButton1.Text = "Bitir";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.AutoSize = true;
            this.btnDuzenle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDuzenle.Depth = 0;
            this.btnDuzenle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDuzenle.Enabled = false;
            this.btnDuzenle.Location = new System.Drawing.Point(481, 333);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDuzenle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Primary = false;
            this.btnDuzenle.Size = new System.Drawing.Size(71, 36);
            this.btnDuzenle.TabIndex = 6;
            this.btnDuzenle.Text = "Duzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // MedyaDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.materialFlatButton1;
            this.ClientSize = new System.Drawing.Size(614, 386);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.btnYeniMedya);
            this.Controls.Add(this.groupSeciliResim);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.imageLists);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MedyaDegistir";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medya Degistir";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MedyaDegistir_FormClosing);
            this.Load += new System.EventHandler(this.MedyaDegistir_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MedyaDegistir_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedyaDegistir_KeyPress);
            this.groupSeciliResim.ResumeLayout(false);
            this.groupSeciliResim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox imageLists;
        private MetroFramework.Controls.MetroComboBox cmbKategori;
        private System.Windows.Forms.GroupBox groupSeciliResim;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label lblMedyaismi;
        private MaterialSkin.Controls.MaterialRaisedButton btnYeniMedya;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton btnDuzenle;
        private VlcPlayer vlcPlayer1;
    }
}