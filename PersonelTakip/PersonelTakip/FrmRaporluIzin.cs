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
    public partial class FrmRaporluIzin : Form
    {
        public FrmRaporluIzin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec RaporluIzin_Getir", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[1].Visible = false;
        }
        void temizle()
        {
            TxtPersonelId.Text = "";
            TxtRaporluId.Text = "";
            TxtPersonel.Text = "";
            TxtBaslangicTarih.Text = "";
            TxtBitisTarih.Text = "";
        }
        private void FrmRaporluIzin_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
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
            if (TxtRaporluId.Text == "")
            {
                if (TxtPersonelId.Text != "")
                {
                    SqlCommand komut = new SqlCommand("insert into Raporlu_Izin (Personel_ID,Bas_Tarih,Bit_Tarih) values (@p1,@p2,@p3)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", Convert.ToInt32(TxtPersonelId.Text));
                    komut.Parameters.AddWithValue("@p2", Convert.ToDateTime(TxtBaslangicTarih.Text));
                    komut.Parameters.AddWithValue("@p3", Convert.ToDateTime(TxtBitisTarih.Text));
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Raporlu izin bilgisi oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            TxtRaporluId.Text = dr["Raporlu_Izin_ID"].ToString();
            TxtPersonelId.Text = dr["Personel_ID"].ToString();
            TxtPersonel.Text = dr["Ad_Soyad"].ToString();
            TxtBaslangicTarih.Text = dr["Bas_Tarih"].ToString();
            TxtBitisTarih.Text = dr["Bit_Tarih"].ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

            if (TxtRaporluId.Text != "")
            {
                DialogResult result = MessageBox.Show("Raporlu İzin Bilgisini Silmeyi Onaylıyor Musunuz ?", "Uyarı", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        SqlCommand komutsil = new SqlCommand("delete from Raporlu_Izin where Raporlu_Izin_ID=@p1", bgl.baglanti());
                        komutsil.Parameters.AddWithValue("@p1", TxtRaporluId.Text);
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

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtRaporluId.Text != "")
            {
                SqlCommand komutguncelle = new SqlCommand("update Raporlu_Izin set Bas_Tarih=@p1, Bit_Tarih=@p2 where Raporlu_Izin_ID=@p3", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@p1", Convert.ToDateTime(TxtBaslangicTarih.Text));
                komutguncelle.Parameters.AddWithValue("@p2", Convert.ToDateTime(TxtBitisTarih.Text));
                komutguncelle.Parameters.AddWithValue("@p3", TxtRaporluId.Text);
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
                FileName = "Raporlu.xls"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
                gridView1.ExportToXls(dialog.FileName);
        }
    }
}
