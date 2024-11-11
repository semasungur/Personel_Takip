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
    public partial class FrmUcretliIzin : Form
    {
        public FrmUcretliIzin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec UcretliIzin_Getir", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[1].Visible = false;
        }
        void temizle()
        {
            TxtPersonelId.Text = "";
            TxtUcretliId.Text = "";
            TxtPersonel.Text = "";
            TxtBaslangicTarih.Text = "";
            TxtBitisTarih.Text = "";
            TxtSebep.Text = "";
        }
        private void FrmUcretliIzin_Load(object sender, EventArgs e)
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
            if (TxtUcretliId.Text == "")
            {
                if (TxtPersonelId.Text != "")
                {
                    SqlCommand komut = new SqlCommand("insert into Ucretli_Izin (Personel_ID,Bas_Tarih,Bit_Tarih,Sebep) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", Convert.ToInt32(TxtPersonelId.Text));
                    komut.Parameters.AddWithValue("@p2", Convert.ToDateTime(TxtBaslangicTarih.Text));
                    komut.Parameters.AddWithValue("@p3", Convert.ToDateTime(TxtBitisTarih.Text));
                    komut.Parameters.AddWithValue("@p4", TxtSebep.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Ücretli izin bilgisi oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            TxtUcretliId.Text = dr["UcretliIzin_ID"].ToString();
            TxtPersonelId.Text = dr["Personel_ID"].ToString();
            TxtPersonel.Text = dr["Ad_Soyad"].ToString();
            TxtBaslangicTarih.Text = dr["Bas_Tarih"].ToString();
            TxtBitisTarih.Text = dr["Bit_Tarih"].ToString();
            TxtSebep.Text = dr["Sebep"].ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtUcretliId.Text != "")
            {
                DialogResult result = MessageBox.Show("Ücretli İzin Bilgisini Silmeyi Onaylıyor Musunuz ?", "Uyarı", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        SqlCommand komutsil = new SqlCommand("delete from Ucretli_Izin where UcretliIzin_ID=@p1", bgl.baglanti());
                        komutsil.Parameters.AddWithValue("@p1", TxtUcretliId.Text);
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
            if (TxtUcretliId.Text != "")
            {
                SqlCommand komutguncelle = new SqlCommand("update Ucretli_Izin set Bas_Tarih=@p1, Bit_Tarih=@p2,Sebep=@p4 where UcretliIzin_ID=@p3", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@p1", Convert.ToDateTime(TxtBaslangicTarih.Text));
                komutguncelle.Parameters.AddWithValue("@p2", Convert.ToDateTime(TxtBitisTarih.Text));
                komutguncelle.Parameters.AddWithValue("@p4", TxtSebep.Text);
                komutguncelle.Parameters.AddWithValue("@p3", TxtUcretliId.Text);
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
                FileName = "Ücretli.xls"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
                gridView1.ExportToXls(dialog.FileName);
        }
    }
}
