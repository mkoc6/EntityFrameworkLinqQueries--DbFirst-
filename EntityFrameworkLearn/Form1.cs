using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EntityFrameworkLearn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbEntityFramewrokEntities db = new DbEntityFramewrokEntities();
        private void btnDersList_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1DQCP20\SQLEXPRESS;Initial Catalog=DbEntityFramewrok;Integrated Security=True");
            SqlCommand command = new SqlCommand("select * from TBL_DERSLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnOgrenciList_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.TBL_OGRENCI.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

        }

        private void BtnNotlist_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBL_NOTLAR
                        select new
                        {
                            item.NOTID,
                            item.TBL_OGRENCI.AD,
                            item.TBL_OGRENCI.SOYAD,
                            item.TBL_DERSLER.DERSAD,
                            item.SINAV1,
                            item.SINAV2,
                            item.SINAV3,
                            item.ORTALAMA,
                            item.DURUM
                        };
            dataGridView1.DataSource = query.ToList();

        }

        private void btnKayfet_Click(object sender, EventArgs e)
        {
            TBL_OGRENCI t = new TBL_OGRENCI();
            t.AD = txtad.Text;
            t.SOYAD = txtsoyad.Text;
            db.TBL_OGRENCI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Listeye Eklenmiştir");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBL_DERSLER d = new TBL_DERSLER();
            d.DERSAD = txtDersAd.Text;
            db.TBL_DERSLER.Add(d);
            db.SaveChanges();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtogrencıId.Text);
            var x = db.TBL_OGRENCI.Find(id);
            db.TBL_OGRENCI.Remove(x);
            db.SaveChanges();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtogrencıId.Text);
            var x = db.TBL_OGRENCI.Find(id);
            x.AD = txtad.Text;
            x.SOYAD = txtsoyad.Text;
            x.FOTOGRAF = txtfotograf.Text;
            db.SaveChanges();
        }

        private void BTNPROCESRUE_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NOTLISTESI();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBL_OGRENCI.Where(x => x.AD == txtad.Text | x.SOYAD == txtsoyad.Text).ToList();
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

            String aranan = txtad.Text;
            var dergerler = from item in db.TBL_OGRENCI
                            where item.AD.Contains(aranan)
                            select item;
            dataGridView1.DataSource = dergerler.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                List<TBL_OGRENCI> liste1 = db.TBL_OGRENCI.OrderBy(p => p.AD).ToList();
                dataGridView1.DataSource = liste1;
            }
            if (radioButton2.Checked == true)
            {
                List<TBL_OGRENCI> liste2 = db.TBL_OGRENCI.OrderByDescending(p => p.AD).ToList();
                dataGridView1.DataSource = liste2;

            }
            if (radioButton3.Checked == true)
            {
                List<TBL_OGRENCI> liste3 = db.TBL_OGRENCI.OrderBy(p => p.AD).Take(3).ToList();
                dataGridView1.DataSource = liste3;
            }
            if (radioButton4.Checked == true)
            {
                List<TBL_OGRENCI> liste4 = db.TBL_OGRENCI.Where(p => p.ID == 5).ToList();
                dataGridView1.DataSource = liste4;
            }
            if (radioButton5.Checked == true)
            {
                List<TBL_OGRENCI> liste5 = db.TBL_OGRENCI.Where(p => p.AD.StartsWith("a") | p.AD.StartsWith("e")).ToList();
                dataGridView1.DataSource = liste5;
            }
            if (radioButton6.Checked == true)
            {
                List<TBL_OGRENCI> liste6 = db.TBL_OGRENCI.Where(p => p.SOYAD.EndsWith("a")).ToList();
                dataGridView1.DataSource = liste6;
            }
            if (radioButton7.Checked == true)
            {
                bool deger = db.TBL_OGRENCI.Any();
                MessageBox.Show(deger.ToString());

            }
            if (radioButton8.Checked == true)
            {
                var toplam = db.TBL_OGRENCI.Count();
                MessageBox.Show(toplam.ToString());
            }
            if (radioButton9.Checked == true)
            {
                var toplam = db.TBL_NOTLAR.Sum(p => p.SINAV1);
                MessageBox.Show(toplam.ToString());
            }
            if (radioButton10.Checked == true)
            {
                var ortalama = db.TBL_NOTLAR.Average(p => p.SINAV1);
                MessageBox.Show(ortalama.ToString());

            }
            if (radioButton11.Checked == true)
            {
                var enyuksek = db.TBL_NOTLAR.Max(p => p.SINAV1);
                MessageBox.Show(enyuksek.ToString());
            }
            if (radioButton12.Checked == true)
            {
                var ortalama = db.TBL_NOTLAR.Average(p => p.SINAV1);
                List<TBL_NOTLAR> liste = db.TBL_NOTLAR.Where(p => p.SINAV1 > ortalama).ToList();

                dataGridView1.DataSource = liste;
            }
        }

        private void btnSınavGuncelle_Click(object sender, EventArgs e)
        {
            var query = from d1 in db.TBL_NOTLAR
                        join d2 in db.TBL_OGRENCI
                        on d1.OGR equals d2.ID
                        join d3 in db.TBL_DERSLER
                        on d1.DERS equals d3.DERSID


                        select new
                        {
                            Öğrenci = d2.AD,
                            Soyad = d2.SOYAD,
                            Ders = d3.DERSAD,
                            Sınav1 = d1.SINAV1,
                            Sınav2 = d1.SINAV2,
                            Sınav3 = d1.SINAV3,
                            Ortalama = d1.ORTALAMA
                        };
            dataGridView1.DataSource = query.ToList();
        }
    }
}
