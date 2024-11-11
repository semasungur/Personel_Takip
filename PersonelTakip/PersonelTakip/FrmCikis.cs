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

namespace PersonelTakip
{
    public partial class FrmCikis : Form
    {
        public FrmCikis()
        {
            InitializeComponent();
        }
        FrmKimlik fr;
        private void FrmCikis_Load(object sender, EventArgs e)
        {
            fr = new FrmKimlik();
            TxtID.Text= FrmKimlik.ID.ToString();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnOnay_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update Personel set Cikis_Tarih=@p1,Durum=0 where Personel_ID=@p3", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", Convert.ToDateTime(TxtCikisTarihi.Text));
            komutguncelle.Parameters.AddWithValue("@p3", TxtID.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Çıkışı Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
    }
}
