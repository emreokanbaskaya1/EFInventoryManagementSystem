﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            var kategoriler = db.TBLKATEGORIs.ToList();
            dataGridView1.DataSource = kategoriler;

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLKATEGORI t = new TBLKATEGORI();
            t.AD = textBox2.Text; 
            db.TBLKATEGORIs.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var kategori = db.TBLKATEGORIs.Find(x);
            db.TBLKATEGORIs.Remove(kategori);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var kategori = db.TBLKATEGORIs.Find(x);
            kategori.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi");
        }
    }
}
