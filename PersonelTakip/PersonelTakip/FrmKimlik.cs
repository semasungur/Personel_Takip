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
using Microsoft.Office.Interop.Excel;
using Excel= Microsoft.Office.Interop.Excel;


namespace PersonelTakip
{
    public partial class FrmKimlik : Form
    {
        
        public FrmKimlik()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Personel_Id,TC,Ad_Soyad,Dogum_Tarih,SgkTip,Dosya_No,Giris_Tarih from Personel where durum=1", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns[0].Visible = false;
        }
        void temizle()
        {
            TxtID.Text = "";
            TxtTc.Text = "";
            TxtAdSoyad.Text = "";
            TxtDogumTarih.Text = "";
            CmbSgkTip.Text = "";
            TxtDosyaNo.Text = "";
            TxtGirisTarih.Text = "";
        }
        private void FrmKimlik_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
         
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                if (TxtTc.Text != "")
                {
                    SqlCommand komut = new SqlCommand("insert into Personel (TC,Ad_Soyad,Dogum_Tarih,Durum,SgkTip,Dosya_No,Giris_Tarih) values (@p1,@p2,@p3,1,@p4,@p5,@p6)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtTc.Text);
                    komut.Parameters.AddWithValue("@p2", TxtAdSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", TxtDogumTarih.Text);
                    komut.Parameters.AddWithValue("@p4", CmbSgkTip.Text);
                    komut.Parameters.AddWithValue("@p5", TxtDosyaNo.Text);
                    komut.Parameters.AddWithValue("@p6", TxtGirisTarih.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Personel Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizle();
                }
                else { MessageBox.Show("Personel Bilgisi Girmelisiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("Personel Sistemde Mevcut!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtID.Text = dr["Personel_Id"].ToString();
            TxtAdSoyad.Text = dr["Ad_Soyad"].ToString();
            TxtDogumTarih.Text = dr["Dogum_Tarih"].ToString();
            CmbSgkTip.Text = dr["SgkTip"].ToString();
            TxtTc.Text = dr["TC"].ToString();
            TxtDosyaNo.Text= dr["Dosya_No"].ToString();
            TxtGirisTarih.Text = dr["Giris_Tarih"].ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtID.Text != "")
            {
                DialogResult result = MessageBox.Show("Personeli Silmeyi Onaylıyor Musunuz ?", "Uyarı", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        SqlCommand komutsil = new SqlCommand("delete from Personel where Personel_ID=@p1", bgl.baglanti());
                        komutsil.Parameters.AddWithValue("@p1", TxtID.Text);
                        komutsil.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Personel Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        listele();
                        temizle();
                    }
                    catch
                    {
                        MessageBox.Show("Personelin sistemde bilgisi bulunmakta. Silinemez !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else { MessageBox.Show("Silinecek Personeli Seçmelisiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtID.Text != "")
            {
                SqlCommand komutguncelle = new SqlCommand("update Personel set TC=@p1, Ad_Soyad=@p2, Dogum_Tarih=@p3, SgkTip=@p5,Dosya_No=@p6,Giris_Tarih=@p7 where Personel_ID=@p4", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@p1", TxtTc.Text);
                komutguncelle.Parameters.AddWithValue("@p2", TxtAdSoyad.Text);
                komutguncelle.Parameters.AddWithValue("@p3", Convert.ToDateTime(TxtDogumTarih.Text));
                komutguncelle.Parameters.AddWithValue("@p4", TxtID.Text);
                komutguncelle.Parameters.AddWithValue("@p5", CmbSgkTip.Text);
                komutguncelle.Parameters.AddWithValue("@p6", TxtDosyaNo.Text);
                komutguncelle.Parameters.AddWithValue("@p7", Convert.ToDateTime(TxtGirisTarih.Text));
                komutguncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
                temizle();
            }
            else { MessageBox.Show("Güncellenecek Personeli Seçmelisiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Excel Çalışma Kitabı |*.xls",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                FileName = "Kimlik.xls"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
                gridView1.ExportToXls(dialog.FileName);
        }
        FrmCikis fr;
        public static int ID;
        private void BtnAyrildi_Click(object sender, EventArgs e)
        {
            if (TxtID.Text != "")
            {
                ID = Convert.ToInt32(TxtID.Text);
                fr = new FrmCikis();
                fr.ShowDialog();
            }
            else { MessageBox.Show("Ayrılacak Personeli Seçmelisiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            listele();
        }
    }
}
