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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=EMarketing; integrated security=true");
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioBilgisayar_CheckedChanged(object sender, EventArgs e)
        {
            ProductDal2 productDal2 = new ProductDal2();
            dgwProduct2.DataSource = productDal2.GetAll2();
            pictureBilgisayar.Visible = true;
            pictureTelefon.Visible = false;
            pictureTablet.Visible = false;

            int toplam = 0;
            for (int i = 0; i < dgwProduct2.Rows.Count; i++)
            {
                toplam = toplam + Convert.ToInt32(dgwProduct2.Rows[i].Cells[3].Value);
            }
            lblStokAdet.Text = toplam.ToString();


            int toplam2 = 0;
            for (int i = 0; i < dgwProduct2.Rows.Count; i++)
            {
                toplam2 = toplam2 + Convert.ToInt32(dgwProduct2.Rows[i].Cells[4].Value);
            }
            lblStokFiyat.Text = toplam2.ToString();
        }

        private void radioTelefon_CheckedChanged(object sender, EventArgs e)
        {
            ProductDal2 productDal2 = new ProductDal2();
            dgwProduct2.DataSource = productDal2.GetAll3();
            pictureBilgisayar.Visible = false;
            pictureTelefon.Visible = true;
            pictureTablet.Visible = false;



            int toplam = 0;
            for (int i = 0; i < dgwProduct2.Rows.Count; i++)
            {
                toplam = toplam + Convert.ToInt32(dgwProduct2.Rows[i].Cells[3].Value);
            }
            lblStokAdet.Text = toplam.ToString();


            int toplam2 = 0;
            for (int i = 0; i < dgwProduct2.Rows.Count; i++)
            {
                toplam2 = toplam2 + Convert.ToInt32(dgwProduct2.Rows[i].Cells[4].Value);
            }
            lblStokFiyat.Text = toplam2.ToString();
        }

        private void radioTablet_CheckedChanged(object sender, EventArgs e)
        {
            ProductDal2 productDal2 = new ProductDal2();
            dgwProduct2.DataSource = productDal2.GetAll4();
            pictureBilgisayar.Visible = false;
            pictureTelefon.Visible = false;
            pictureTablet.Visible = true;


            int toplam = 0;
            for (int i = 0; i < dgwProduct2.Rows.Count; i++)
            {
                toplam = toplam + Convert.ToInt32(dgwProduct2.Rows[i].Cells[3].Value);
            }
            lblStokAdet.Text = toplam.ToString();


            int toplam2 = 0;
            for (int i = 0; i < dgwProduct2.Rows.Count; i++)
            {
                toplam2 = toplam2 + Convert.ToInt32(dgwProduct2.Rows[i].Cells[4].Value);
            }
            lblStokFiyat.Text = toplam2.ToString();
        }
    }
}
