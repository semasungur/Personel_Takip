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
    public partial class FrmEk : Form
    {
        public FrmEk()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Personel_Id,Ad_Soyad,Iban,Hesap_No,Medeni_Durum,Cocuk,Tel,Adres,Okul,Mezun_Tarih from Personel where durum = 1", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns[0].Visible = false;
        }
        void temizle()
        {
            TxtID.Text = "";
            TxtIban.Text = "";
            TxtHesapNo.Text = "";
            CmbMedeniDurum.Text = "";
            TxtCocukSayisi.Text = "";
            TxtTel.Text = "";
            TxtAdres.Text = "";
            TxtOkul.Text = "";
            TxtMezuniyetTarih.Text = "";
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Excel Çalışma Kitabı |*.xls",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                FileName = "EkBilgiler.xls"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
                gridView1.ExportToXls(dialog.FileName);
        }

        private void FrmEk_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtID.Text = dr["Personel_Id"].ToString();
            TxtIban.Text = dr["Iban"].ToString();
            TxtHesapNo.Text = dr["Hesap_No"].ToString();
            CmbMedeniDurum.Text = dr["Medeni_Durum"].ToString();
            TxtCocukSayisi.Text = dr["Cocuk"].ToString();
            TxtTel.Text = dr["Tel"].ToString();
            TxtAdres.Text = dr["Adres"].ToString();
            TxtOkul.Text = dr["Okul"].ToString();
            TxtMezuniyetTarih.Text = dr["Mezun_Tarih"].ToString();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtID.Text != "")
            {
                SqlCommand komutguncelle = new SqlCommand("update Personel set Iban=@p1, Hesap_No=@p2,Medeni_Durum=@p3, Cocuk=@p4,Tel=@p5, Adres=@p6,Okul=@p7,Mezun_Tarih=@p8 where Personel_ID=@p9", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@p1", TxtIban.Text);
                komutguncelle.Parameters.AddWithValue("@p2", TxtHesapNo.Text);
                komutguncelle.Parameters.AddWithValue("@p3", CmbMedeniDurum.Text);
                komutguncelle.Parameters.AddWithValue("@p4", TxtCocukSayisi.Text);
                komutguncelle.Parameters.AddWithValue("@p5", TxtTel.Text);
                komutguncelle.Parameters.AddWithValue("@p6", TxtAdres.Text);
                komutguncelle.Parameters.AddWithValue("@p7", TxtOkul.Text);
                komutguncelle.Parameters.AddWithValue("@p8", TxtMezuniyetTarih.Text);
                komutguncelle.Parameters.AddWithValue("@p9", TxtID.Text);
                komutguncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bilgiler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
                temizle();
            }
            else { MessageBox.Show("Güncellenecek Personeli Seçmelisiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
