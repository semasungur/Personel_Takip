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
    public partial class FrmMuayene : Form
    {
        public FrmMuayene()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec muayenegetir", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[1].Visible = false;
        }
        void temizle()
        {
            TxtPersonelId.Text = "";
            TxtMuayeneId.Text = "";
            TxtPersonel.Text = "";
            TxtMuayeneTarih.Text = "";
            TxtFirma.Text = "";
        }     
        private void FrmMuayene_Load(object sender, EventArgs e)
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
            if (TxtMuayeneId.Text == "")
            {
                if (TxtPersonelId.Text != "")
                {
                    SqlCommand komut = new SqlCommand("insert into Muayene (Personel_ID,Muayene_Tarih,Muyene_Firma) values (@p1,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Convert.ToInt32(TxtPersonelId.Text));
            komut.Parameters.AddWithValue("@p3", Convert.ToDateTime(TxtMuayeneTarih.Text));
            komut.Parameters.AddWithValue("@p4", TxtFirma.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Muayene bilgisi oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
                }
                else { MessageBox.Show("Muayene Bilgisi Girmelisiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("Muayene Kaydı Sistemde Mevcut!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtMuayeneId.Text != "")
            {
                DialogResult result = MessageBox.Show("Muayene Bilgisini Silmeyi Onaylıyor Musunuz ?", "Uyarı", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        SqlCommand komutsil = new SqlCommand("delete from Muayene where MuayeneId=@p1", bgl.baglanti());
                        komutsil.Parameters.AddWithValue("@p1", TxtMuayeneId.Text);
                        komutsil.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Muayene Bilgisi Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtMuayeneId.Text = dr["MuayeneId"].ToString();
            TxtPersonelId.Text = dr["Personel_ID"].ToString();
            TxtPersonel.Text = dr["Ad_Soyad"].ToString();
            TxtMuayeneTarih.Text = dr["Muayene_Tarih"].ToString();
            TxtFirma.Text = dr["Muyene_Firma"].ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtMuayeneId.Text != "")
            {
                SqlCommand komutguncelle = new SqlCommand("update Muayene set Muayene_Tarih=@p1, Muyene_Firma=@p2 where MuayeneId=@p3", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@p1", Convert.ToDateTime(TxtMuayeneTarih.Text));
                komutguncelle.Parameters.AddWithValue("@p2", TxtFirma.Text);
                komutguncelle.Parameters.AddWithValue("@p3", TxtMuayeneId.Text);
                komutguncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Muayene Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                FileName = "Muayene.xls"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
                gridView1.ExportToXls(dialog.FileName);
        }
    }
}
