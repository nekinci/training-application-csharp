﻿namespace EgitimUygulamasi
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnCikis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOturumuKapat = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.board = new System.Windows.Forms.Button();
            this.kategoriekle = new System.Windows.Forms.Button();
            this.soruekle = new System.Windows.Forms.Button();
            this.kategoriduzenle = new System.Windows.Forms.Button();
            this.soruduzenle = new System.Windows.Forms.Button();
            this.calisanislemleri = new System.Windows.Forms.Button();
            this.calisanduzenle = new System.Windows.Forms.Button();
            this.temaayarlari = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ayarlar = new System.Windows.Forms.Button();
            this.ayarlar1 = new EgitimUygulamasi.View.Ayarlar();
            this.calisanDuzenle1 = new EgitimUygulamasi.View.CalisanDuzenle();
            this.calisan1 = new EgitimUygulamasi.View.Calisan();
            this.kategoriDuzenleme1 = new EgitimUygulamasi.View.KategoriDuzenleme();
            this.soruDuzenleme1 = new EgitimUygulamasi.View.SoruDuzenleme();
            this.kategoriEkleme1 = new EgitimUygulamasi.KategoriEkleme();
            this.soruEkleme1 = new EgitimUygulamasi.View.SoruEkleme();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.White;
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCikis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.btnCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(717, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(51, 61);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(115)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 61);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eğitim Uygulaması";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnOturumuKapat);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnMin);
            this.panel2.Controls.Add(this.btnCikis);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(218, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 61);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // btnOturumuKapat
            // 
            this.btnOturumuKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnOturumuKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOturumuKapat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOturumuKapat.FlatAppearance.BorderSize = 0;
            this.btnOturumuKapat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btnOturumuKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btnOturumuKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOturumuKapat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOturumuKapat.ForeColor = System.Drawing.Color.White;
            this.btnOturumuKapat.Location = new System.Drawing.Point(528, 0);
            this.btnOturumuKapat.Name = "btnOturumuKapat";
            this.btnOturumuKapat.Size = new System.Drawing.Size(138, 61);
            this.btnOturumuKapat.TabIndex = 4;
            this.btnOturumuKapat.Text = "Oturumu Kapat";
            this.btnOturumuKapat.UseVisualStyleBackColor = false;
            this.btnOturumuKapat.Click += new System.EventHandler(this.btnOturumuKapat_Click);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(666, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(51, 61);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "_";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 61);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(52, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.board.Dock = System.Windows.Forms.DockStyle.Top;
            this.board.FlatAppearance.BorderSize = 0;
            this.board.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.board.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.board.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.board.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.board.Location = new System.Drawing.Point(0, 61);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(218, 47);
            this.board.TabIndex = 1;
            this.board.Text = "Board";
            this.board.UseVisualStyleBackColor = false;
            // 
            // kategoriekle
            // 
            this.kategoriekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.kategoriekle.Dock = System.Windows.Forms.DockStyle.Top;
            this.kategoriekle.FlatAppearance.BorderSize = 0;
            this.kategoriekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.kategoriekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.kategoriekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kategoriekle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategoriekle.ForeColor = System.Drawing.Color.White;
            this.kategoriekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kategoriekle.Location = new System.Drawing.Point(0, 108);
            this.kategoriekle.Name = "kategoriekle";
            this.kategoriekle.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.kategoriekle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kategoriekle.Size = new System.Drawing.Size(218, 47);
            this.kategoriekle.TabIndex = 2;
            this.kategoriekle.Text = "Kategori Ekleme";
            this.kategoriekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.kategoriekle.UseVisualStyleBackColor = false;
            this.kategoriekle.Click += new System.EventHandler(this.kategoriekle_Click);
            // 
            // soruekle
            // 
            this.soruekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.soruekle.Dock = System.Windows.Forms.DockStyle.Top;
            this.soruekle.FlatAppearance.BorderSize = 0;
            this.soruekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.soruekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.soruekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soruekle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruekle.Location = new System.Drawing.Point(0, 155);
            this.soruekle.Name = "soruekle";
            this.soruekle.Size = new System.Drawing.Size(218, 47);
            this.soruekle.TabIndex = 3;
            this.soruekle.Text = "Soru Ekleme";
            this.soruekle.UseVisualStyleBackColor = false;
            this.soruekle.Click += new System.EventHandler(this.soruekle_Click);
            // 
            // kategoriduzenle
            // 
            this.kategoriduzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.kategoriduzenle.Dock = System.Windows.Forms.DockStyle.Top;
            this.kategoriduzenle.FlatAppearance.BorderSize = 0;
            this.kategoriduzenle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.kategoriduzenle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.kategoriduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kategoriduzenle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategoriduzenle.Location = new System.Drawing.Point(0, 202);
            this.kategoriduzenle.Name = "kategoriduzenle";
            this.kategoriduzenle.Size = new System.Drawing.Size(218, 47);
            this.kategoriduzenle.TabIndex = 4;
            this.kategoriduzenle.Text = "Kategori Düzenleme";
            this.kategoriduzenle.UseVisualStyleBackColor = false;
            this.kategoriduzenle.Click += new System.EventHandler(this.kategoriduzenle_Click);
            // 
            // soruduzenle
            // 
            this.soruduzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.soruduzenle.Dock = System.Windows.Forms.DockStyle.Top;
            this.soruduzenle.FlatAppearance.BorderSize = 0;
            this.soruduzenle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.soruduzenle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.soruduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soruduzenle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruduzenle.Location = new System.Drawing.Point(0, 249);
            this.soruduzenle.Name = "soruduzenle";
            this.soruduzenle.Size = new System.Drawing.Size(218, 47);
            this.soruduzenle.TabIndex = 5;
            this.soruduzenle.Text = "Soru Düzenleme";
            this.soruduzenle.UseVisualStyleBackColor = false;
            this.soruduzenle.Click += new System.EventHandler(this.soruduzenle_Click);
            // 
            // calisanislemleri
            // 
            this.calisanislemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.calisanislemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.calisanislemleri.FlatAppearance.BorderSize = 0;
            this.calisanislemleri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.calisanislemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.calisanislemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calisanislemleri.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calisanislemleri.Location = new System.Drawing.Point(0, 296);
            this.calisanislemleri.Name = "calisanislemleri";
            this.calisanislemleri.Size = new System.Drawing.Size(218, 47);
            this.calisanislemleri.TabIndex = 6;
            this.calisanislemleri.Text = "Çalışan Ekle";
            this.calisanislemleri.UseVisualStyleBackColor = false;
            this.calisanislemleri.Click += new System.EventHandler(this.calisanislemleri_Click);
            // 
            // calisanduzenle
            // 
            this.calisanduzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.calisanduzenle.Dock = System.Windows.Forms.DockStyle.Top;
            this.calisanduzenle.FlatAppearance.BorderSize = 0;
            this.calisanduzenle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.calisanduzenle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.calisanduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calisanduzenle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calisanduzenle.Location = new System.Drawing.Point(0, 343);
            this.calisanduzenle.Name = "calisanduzenle";
            this.calisanduzenle.Size = new System.Drawing.Size(218, 47);
            this.calisanduzenle.TabIndex = 7;
            this.calisanduzenle.Text = "Çalışanları Düzenle";
            this.calisanduzenle.UseVisualStyleBackColor = false;
            this.calisanduzenle.Click += new System.EventHandler(this.calisanduzenle_Click);
            // 
            // temaayarlari
            // 
            this.temaayarlari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.temaayarlari.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.temaayarlari.FlatAppearance.BorderSize = 0;
            this.temaayarlari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.temaayarlari.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.temaayarlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temaayarlari.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temaayarlari.Location = new System.Drawing.Point(0, 536);
            this.temaayarlari.Name = "temaayarlari";
            this.temaayarlari.Size = new System.Drawing.Size(218, 47);
            this.temaayarlari.TabIndex = 8;
            this.temaayarlari.Text = "Tema Ayarları";
            this.temaayarlari.UseVisualStyleBackColor = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlMenu.Controls.Add(this.ayarlar);
            this.pnlMenu.Controls.Add(this.temaayarlari);
            this.pnlMenu.Controls.Add(this.calisanduzenle);
            this.pnlMenu.Controls.Add(this.calisanislemleri);
            this.pnlMenu.Controls.Add(this.soruduzenle);
            this.pnlMenu.Controls.Add(this.kategoriduzenle);
            this.pnlMenu.Controls.Add(this.soruekle);
            this.pnlMenu.Controls.Add(this.kategoriekle);
            this.pnlMenu.Controls.Add(this.board);
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.Color.White;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(218, 583);
            this.pnlMenu.TabIndex = 0;
            // 
            // ayarlar
            // 
            this.ayarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ayarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ayarlar.FlatAppearance.BorderSize = 0;
            this.ayarlar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.ayarlar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.ayarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayarlar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ayarlar.Location = new System.Drawing.Point(0, 390);
            this.ayarlar.Name = "ayarlar";
            this.ayarlar.Size = new System.Drawing.Size(218, 47);
            this.ayarlar.TabIndex = 9;
            this.ayarlar.Text = "Ayarlar";
            this.ayarlar.UseVisualStyleBackColor = false;
            this.ayarlar.Click += new System.EventHandler(this.ayarlar_Click);
            // 
            // ayarlar1
            // 
            this.ayarlar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ayarlar1.Location = new System.Drawing.Point(218, 61);
            this.ayarlar1.Name = "ayarlar1";
            this.ayarlar1.Size = new System.Drawing.Size(768, 522);
            this.ayarlar1.TabIndex = 8;
            this.ayarlar1.Visible = false;
            // 
            // calisanDuzenle1
            // 
            this.calisanDuzenle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calisanDuzenle1.Location = new System.Drawing.Point(218, 61);
            this.calisanDuzenle1.Name = "calisanDuzenle1";
            this.calisanDuzenle1.Size = new System.Drawing.Size(768, 522);
            this.calisanDuzenle1.TabIndex = 7;
            this.calisanDuzenle1.Visible = false;
            this.calisanDuzenle1.Load += new System.EventHandler(this.calisanDuzenle1_Load);
            // 
            // calisan1
            // 
            this.calisan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calisan1.Location = new System.Drawing.Point(218, 61);
            this.calisan1.Name = "calisan1";
            this.calisan1.Size = new System.Drawing.Size(768, 522);
            this.calisan1.TabIndex = 6;
            this.calisan1.Visible = false;
            // 
            // kategoriDuzenleme1
            // 
            this.kategoriDuzenleme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kategoriDuzenleme1.Location = new System.Drawing.Point(218, 61);
            this.kategoriDuzenleme1.Name = "kategoriDuzenleme1";
            this.kategoriDuzenleme1.Size = new System.Drawing.Size(768, 522);
            this.kategoriDuzenleme1.TabIndex = 5;
            this.kategoriDuzenleme1.Visible = false;
            // 
            // soruDuzenleme1
            // 
            this.soruDuzenleme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soruDuzenleme1.Location = new System.Drawing.Point(218, 61);
            this.soruDuzenleme1.Name = "soruDuzenleme1";
            this.soruDuzenleme1.Size = new System.Drawing.Size(768, 522);
            this.soruDuzenleme1.TabIndex = 4;
            this.soruDuzenleme1.Visible = false;
            this.soruDuzenleme1.Load += new System.EventHandler(this.soruDuzenleme1_Load);
            // 
            // kategoriEkleme1
            // 
            this.kategoriEkleme1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kategoriEkleme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kategoriEkleme1.Location = new System.Drawing.Point(218, 61);
            this.kategoriEkleme1.Name = "kategoriEkleme1";
            this.kategoriEkleme1.Size = new System.Drawing.Size(768, 522);
            this.kategoriEkleme1.TabIndex = 3;
            this.kategoriEkleme1.Visible = false;
            // 
            // soruEkleme1
            // 
            this.soruEkleme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soruEkleme1.Location = new System.Drawing.Point(218, 61);
            this.soruEkleme1.Name = "soruEkleme1";
            this.soruEkleme1.Size = new System.Drawing.Size(768, 522);
            this.soruEkleme1.TabIndex = 2;
            this.soruEkleme1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(986, 583);
            this.Controls.Add(this.ayarlar1);
            this.Controls.Add(this.calisanDuzenle1);
            this.Controls.Add(this.calisan1);
            this.Controls.Add(this.kategoriDuzenleme1);
            this.Controls.Add(this.soruDuzenleme1);
            this.Controls.Add(this.kategoriEkleme1);
            this.Controls.Add(this.soruEkleme1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button board;
        private System.Windows.Forms.Button kategoriekle;
        private System.Windows.Forms.Button soruekle;
        private System.Windows.Forms.Button kategoriduzenle;
        private System.Windows.Forms.Button soruduzenle;
        private System.Windows.Forms.Button calisanislemleri;
        private System.Windows.Forms.Button calisanduzenle;
        private System.Windows.Forms.Button temaayarlari;
        private System.Windows.Forms.Panel pnlMenu;
        private View.SoruEkleme soruEkleme1;
        private KategoriEkleme kategoriEkleme1;
        private View.SoruDuzenleme soruDuzenleme1;
        private View.KategoriDuzenleme kategoriDuzenleme1;
        private System.Windows.Forms.Button btnOturumuKapat;
        private System.Windows.Forms.Button btnMin;
        private View.Calisan calisan1;
        private System.Windows.Forms.Button ayarlar;
        private View.CalisanDuzenle calisanDuzenle1;
        private View.Ayarlar ayarlar1;
    }
}

