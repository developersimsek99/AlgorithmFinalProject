using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmFinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbxSifreUye.PasswordChar = '*';
            tbxSifreGiris.PasswordChar = '*';
        }
        
        SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=EMarketing;integrated security=true");
        private void Form1_Load(object sender, EventArgs e)
        {
            using (EMarketingContext context = new EMarketingContext())
            {
                dgwProduct.DataSource = context.Products.ToList();
            }
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            UserDal userDal = new UserDal();
            userDal.Add(new User
            {
                AdSoyad = tbxAdSoyadUye.Text,
                KullaniciAdi = tbxKullaniciAdiUye.Text,
                Sifre = tbxSifreUye.Text
            });
            MessageBox.Show("Üye Olundu");
        }
        private void cikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uyeolButonu_Click(object sender, EventArgs e)
        {
            
            girisYap.Visible = false;

        }

        private void girisButonu_Click(object sender, EventArgs e)
        {
            girisYap.Visible = true;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from Users where KullaniciAdi='"+tbxKullaniciAdiGiris.Text+"'and Sifre= '"+tbxSifreGiris.Text+"'",connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                label5.Text = tbxKullaniciAdiGiris.Text;
                yesilTik.Visible = true;
                yetkiliKullanici.Visible = true;
                uyeolButonu.Visible = false;
                girisButonu.Visible = false;
                btnCikis.Visible = true;
                girisYap.Visible = false;
                uyeOl.Visible = false;
                urunEkle.Visible = true;
                urunGuncelle.Visible = true;
                btnSil.Visible = true;
                btnDetay.Visible = true;
                //Giriş yapıldığında olacak olaylar
            }
            else {
                MessageBox.Show("Kullanıcı Adınız veya Şifreniz Hatalı");
            }
            connection.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            yesilTik.Visible = false;
            yetkiliKullanici.Visible = false;
            uyeolButonu.Visible = true;
            girisButonu.Visible = true;
            girisYap.Visible = true;
            uyeOl.Visible = true;
            urunEkle.Visible = false;
            urunGuncelle.Visible = false;
            btnCikis.Visible = false;
            btnSil.Visible = false ;
            btnDetay.Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ProductDal productDal = new ProductDal();
            productDal.Add(new Product {
                Kategori = tbxKategoriEkle.Text,
                Marka = tbxMarkaEkle.Text,
                Adet = Convert.ToInt32(tbxAdetEkle.Text),
                Fiyat = Convert.ToInt32(tbxFiyatEkle.Text),
                Ozellikler = tbxOzelliklerEkle.Text
            });
            dgwProduct.DataSource = productDal.GetAll();
            MessageBox.Show("Ürün Eklendi");
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxKategoriGuncelle.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            tbxMarkaGuncelle.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            tbxAdetGuncelle.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            tbxFiyatGuncelle.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            tbxOzelliklerGuncelle.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
            lblKategori.Text= dgwProduct.CurrentRow.Cells[1].Value.ToString();
            lblMarka.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            lblAdet.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            lblFiyat.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            lblOzellik.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ProductDal productDal = new ProductDal();
            productDal.Update(new Product {
                Id=Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                Kategori=tbxKategoriGuncelle.Text,
                Marka=tbxMarkaGuncelle.Text,
                Adet=Convert.ToInt32(tbxAdetGuncelle.Text),
                Fiyat=Convert.ToInt32(tbxFiyatGuncelle.Text),
                Ozellikler=tbxOzelliklerGuncelle.Text
            });
            dgwProduct.DataSource = productDal.GetAll();
            MessageBox.Show("Ürün Güncellendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ProductDal productDal = new ProductDal();
            productDal.Delete(new Product {
                Id=Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
            });
            dgwProduct.DataSource = productDal.GetAll();
            MessageBox.Show("Ürün Silindi");
        }
        private void ListProductsByMarka(string key)
        {
            using (EMarketingContext context = new EMarketingContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.Marka.ToLower().Contains(key)).ToList();
            }
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            ListProductsByMarka(tbxSearch.Text);
        }
        private void ListProductsByKategori(string key)
        {
            using (EMarketingContext context = new EMarketingContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.Kategori.ToLower().Contains(key)).ToList();
            }
        }

        private void tbxKategori_TextChanged(object sender, EventArgs e)
        {
            ListProductsByKategori(tbxKategori.Text);
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            Form2 formDetay = new Form2();
            formDetay.Show();
        }
    }
}