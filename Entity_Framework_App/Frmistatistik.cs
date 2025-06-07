using System;
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
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBLKATEGORIs.Count().ToString();
            label3.Text = db.TBLURUNs.Count().ToString();
            label5.Text = db.TBLMUSTERIs.Count(x=>x.DURUM == true).ToString();
            label7.Text = db.TBLMUSTERIs.Count(x=>x.DURUM == false).ToString();
            label17.Text = db.TBLURUNs.Sum(y=>y.STOK).ToString();
            label27.Text = db.TBLSATIS.Sum(z => z.FIYAT).ToString() + "TL";
            label15.Text = (from x in db.TBLURUNs orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            label13.Text = (from x in db.TBLURUNs orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            label19.Text = db.TBLURUNs.Count(x => x.KATEGORI == 1).ToString();
            label23.Text = db.TBLURUNs.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            label29.Text = (from x in db.TBLMUSTERIs select x.SEHIR).Distinct().Count().ToString();
            label25.Text = (from x in db.TBLURUNs orderby x.STOK descending select x.MARKA).FirstOrDefault();
            label25.Text = (from x in db.TBLURUNs
                            group x by x.MARKA into g
                            orderby g.Sum(x => x.STOK) descending
                            select g.Key).FirstOrDefault();

        }


        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}
