﻿using EgitimUygulamasi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimUygulamasi.View
{
    public partial class MedyaDegistir : Form,IMedya
    {
        private SoruDuzenleme soruDuzenleme1;
        private int selectedId;
        private MedyaGuncelleme guncelleme = new MedyaGuncelleme();
        public void setSoruDuzenleme(SoruDuzenleme soruDuzenleme1, int selectedId)
        {
            this.soruDuzenleme1 = soruDuzenleme1;
            this.selectedId = selectedId;

            cmbKategori.Enabled = true;
            cmbKategori.Items.Add(Database.Select.KategoriCekMedya(selectedId));
            cmbKategori.DisplayMember = "Ad";

            MedyaYukle();
            imageLists.DisplayMember = "Ad";

        }
        public MedyaDegistir()
        {
            InitializeComponent();
        }



        private void MedyaDegistir_Load(object sender, EventArgs e)
        {

        }
        private bool kontrol;
        public void KategoriDegisti(bool kontrol)
        {
            this.kontrol = kontrol;

        }
        Medya _medya;
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.soruDuzenleme1.MedyaDegistir(_medya);
            this.Dispose();
        }

        private void imageLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imageLists.SelectedIndex >= 0)
            {
                _medya = (Medya)imageLists.SelectedItem;
                if (_medya == null)
                    return;

                vlcPlayer1.SetMedia(_medya);
                guncelleme = new MedyaGuncelleme();
                guncelleme.SetMedya(_medya,this);
                txtIsim.Text = _medya.Ad;
                txtPath.Text = _medya.Path;
                materialFlatButton1.Enabled = true;
                btnDuzenle.Enabled = true;
            }

        }

        public void setSoruDuzenleme1(SoruDuzenleme soruDuzenleme1, int kategori_id)
        {
            this.soruDuzenleme1 = soruDuzenleme1;
            cmbKategori.Enabled = true;
            cmbKategori.Items.Add(Database.Select.KategoriCekTekli(kategori_id));
            cmbKategori.DisplayMember = "Ad";

            imageLists.Items.Clear();
            List<Medya> _medyalar = Database.Select.MedyaCekYeni(kategori_id);
            foreach (var i in _medyalar)
            {
                imageLists.Items.Add(i);
            }
            imageLists.DisplayMember = "Ad";
        }

        public void MedyaYukle()
        {
            imageLists.Items.Clear();
            List<Medya> _medyalar = Database.Select.MedyaCekForMedyaDegistir(selectedId);
            foreach (var i in _medyalar)
            {
                imageLists.Items.Add(i);
            }
            imageLists.DisplayMember = "Ad";
        }

        private void btnYeniMedya_Click(object sender, EventArgs e)
        {
            YeniMedya _yenimedya = new YeniMedya();
            _yenimedya.setYeniMedya(this, selectedId);
            _yenimedya.Show();
        }

        private void MedyaDegistir_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void MedyaDegistir_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void MedyaDegistir_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kontrol)
            {
                e.Cancel = true;
                MessageBox.Show("Kategori değiştiğinde haliyle medya da değişmek zorunda çünkü medyalar kategorilere göre ayrıldı.");
            }
        }

        private void btnTamEkran_Click(object sender, EventArgs e)
        {
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            guncelleme.Show();
        }

        public void Guncelle()
        {
            setSoruDuzenleme(this.soruDuzenleme1, this.selectedId);
        }
    }
}
