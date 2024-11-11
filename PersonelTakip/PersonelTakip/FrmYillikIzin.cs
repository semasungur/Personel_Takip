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
    public partial class FrmYillikIzin : Form
    {
        public FrmYillikIzin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec YillikIzin_Getir", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[1].Visible = false;
        }
        void temizle()
        {
            TxtPersonelId.Text = "";
            TxtYillikId.Text = "";
            TxtPersonel.Text = "";
            TxtYil.Text = "";
            TxtKullanilanGun.Text = "";
            TxtIzinTarih.Text = "";
            BtnTamamlandı.Visible = false;
        }
        private void FrmYillikIzin_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            string[] Yillar = { "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025","2026","2027","2028","2029","2030","2031","2032","2033","2034","2035","2036","2037","2038","2039","2040" };
            TxtYil.Properties.DataSource=Yillar;
            
        }
        FrmPersonelRehber fr;
        private void BtnPersonelRehber_Click(object sender, EventArgs e)
        {
            fr = new FrmPersonelRehber();
            fr.ShowDialog();
            TxtPersonel.Text = FrmPersonelRehber.PersonelIsim;
            TxtPersonelId.Text = FrmPersonelRehber.Id.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtYillikId.Text == "")
            {
                if (TxtPersonelId.Text != "")
                {
                    SqlCommand komut = new SqlCommand("insert into Yillik_Izin (Personel_ID,Yil,Kullanılan_Gun,Kullanma_Tarih,Durum) values (@p1,@p2,@p3,@P4,0)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", Convert.ToInt32(TxtPersonelId.Text));
                    komut.Parameters.AddWithValue("@p2", Convert.ToInt32(TxtYil.Text));
                    komut.Parameters.AddWithValue("@p3", Convert.ToInt32(TxtKullanilanGun.Text));
                    komut.Parameters.AddWithValue("@p4", Convert.ToDateTime(TxtIzinTarih.Text));
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Yillik izin bilgisi oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizle();
                }
                else { MessageBox.Show("İzin Bilgisi Girmelisiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("İzin Kaydı Sistemde Mevcut!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtYillikId.Text = dr["YillikIzin_ID"].ToString();
            TxtPersonelId.Text = dr["Personel_ID"].ToString();
            TxtPersonel.Text = dr["Ad_Soyad"].ToString();
            TxtYil.Text = dr["Yil"].ToString();
            TxtKullanilanGun.Text = dr["Kullanılan_Gun"].ToString();
            TxtIzinTarih.Text = dr["Kullanma_Tarih"].ToString();
            BtnTamamlandı.Visible = true;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtYillikId.Text != "")
            {
                DialogResult result = MessageBox.Show("Yillik İzin Bilgisini Silmeyi Onaylıyor Musunuz ?", "Uyarı", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        SqlCommand komutsil = new SqlCommand("delete from Yillik_Izin where Yillik_ID=@p1", bgl.baglanti());
                        komutsil.Parameters.AddWithValue("@p1", TxtYillikId.Text);
                        komutsil.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("İzin Bilgisi Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        listele();
                        temizle();
                    }
                    catch
                    {
                        MessageBox.Show("Silinemez !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else { MessageBox.Show("Silinecek Bilgiyi Seçmelisiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnTamamlandı_Click(object sender, EventArgs e)
        {
            if (TxtYillikId.Text != "")
            {
                DialogResult result = MessageBox.Show("Yıl İçindeki İzinleri Tamamlamayı Onaylıyor Musunuz ?", "Uyarı", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    SqlCommand komutguncelle = new SqlCommand("update Yillik_Izin set Durum=1 where Personel_ID=@p1 and Yil=@p2", bgl.baglanti());
                    komutguncelle.Parameters.AddWithValue("@p1", TxtPersonelId.Text);
                    komutguncelle.Parameters.AddWithValue("@p2", TxtYil.Text);
                    komutguncelle.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Yıl İçindeki İzinlerin Tümü Kullanıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    listele();
                    temizle();
                }
                else { MessageBox.Show("İzin Bilgisi Seçmelisiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            int durum = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, "Durum"));
            if (durum == 1)
            {
                e.Appearance.BackColor = Color.Red;
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtYillikId.Text != "")
            {
                SqlCommand komutguncelle = new SqlCommand("update Yillik_Izin set Yil=@p1, Kullanılan_Gun=@p2,Kullanma_Tarih=@p4 where YillikIzin_ID=@p3", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@p1", Convert.ToInt32(TxtYil.Text));
                komutguncelle.Parameters.AddWithValue("@p2", Convert.ToInt32(TxtKullanilanGun.Text));
                komutguncelle.Parameters.AddWithValue("@p4", Convert.ToDateTime(TxtIzinTarih.Text));
                komutguncelle.Parameters.AddWithValue("@p3", TxtYillikId.Text);
        
                komutguncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("İzin Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
                temizle();
            }
            else { MessageBox.Show("Güncellenecek Bilgiyi Seçmelisiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Excel Çalışma Kitabı |*.xls",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                FileName = "Yilllik.xls"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
                gridView1.ExportToXls(dialog.FileName);
        }
    }
}
