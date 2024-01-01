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
namespace Maliyet_Test
{
    //Data Source = MERYEM\SQLEXPRESS;Initial Catalog = TestMaliyet; Integrated Security = True
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection baglanti = new SqlConnection(@"Data Source=MERYEM\SQLEXPRESS;Initial Catalog=TestMaliyet;Integrated Security=True");

        void MalzemeListe()
        {
            SqlDataAdapter da=new SqlDataAdapter("Select * From  TBLMALZEMELER",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void UrunListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From TBLURUNLER", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource= dt2;
        }
        void Kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Select * From TBLKASA", baglanti);
            DataTable dt3=new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource= dt3;
        }
        void Urunler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select *From TBLURUNLER", baglanti);
            DataTable dt=new DataTable();
            da.Fill(dt);
            comboBox1.ValueMember = "URUNID";
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = dt;
            baglanti.Close();
        }
        void Malzemeler()
        {
            baglanti.Open();
            SqlDataAdapter da=new SqlDataAdapter("Select*From TBLMALZEMELER",baglanti);
            DataTable dt=new DataTable();
            da.Fill(dt);
            comboBox2.ValueMember = "MALZEMEID";
            comboBox2.DisplayMember = "AD";
            comboBox2.DataSource = dt;
            baglanti.Close();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListe();
            Urunler();
            Malzemeler();
        }

        private void btnUrunListesi_Click(object sender, EventArgs e)
        {
            UrunListesi();
        }

        private void btnMalzemeListesi_Click(object sender, EventArgs e)
        {
            MalzemeListe();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            Kasa();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMALZEMELER(AD,STOK,FIYAT,NOTLAR) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtStokAd.Text);
            komut.Parameters.AddWithValue("@p2", decimal.Parse(txtStok.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
            komut.Parameters.AddWithValue("@p4", txtNot.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Sisteme Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            MalzemeListe();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLURUNLER (ad) values(@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1",TxtUrunAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Sistemme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFIRIN(urunıd,malzemeıd,mıktar,malıyet) values(@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@p2", comboBox2.SelectedValue);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtMiktar.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtMaliyet.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBox1.Items.Add(comboBox2.Text + "-" + txtMaliyet.Text);
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
            if (txtMiktar.Text == "")
            {
                txtMiktar.Text = "0";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From TBLMALZEMELER where MALZEMEID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox2.SelectedValue);
            SqlDataReader dr=komut.ExecuteReader();
            while(dr.Read())
            {
                txtMaliyet.Text = dr[3].ToString();
            }
            baglanti.Close();

            maliyet=Convert.ToDouble(txtMaliyet.Text)/1000*Convert.ToDouble(txtMiktar.Text);
            txtMaliyet.Text=maliyet.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtUrunId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtUrunAd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Maliyet) from TBLFIRIN where URUNID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",txtUrunId.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while(dr.Read())
            {
                txtMFiyat.Text = dr[3].ToString();
            }
            baglanti.Close ();

        }
    }
}
