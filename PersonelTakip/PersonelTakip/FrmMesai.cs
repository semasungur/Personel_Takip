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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace PersonelTakip
{
    public partial class FrmMesai : Form
    {
        public FrmMesai()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec Mesai_Getir", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[1].Visible = false;
        }
        void Toplamlistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec ToplamMesai_Getir", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
            gridView2.Columns[0].Visible = false;

         }
        void temizle()
        {
            TxtPersonelId.Text = "";
            TxtMesaiId.Text = "";
            TxtPersonel.Text = "";
            TxtAy.Text = "";
            TxtSaat.Text = "";
        }
        private void FrmMesai_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            Toplamlistele();
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
            if (TxtMesaiId.Text == "")
            {
                if (TxtPersonelId.Text != "")
                {
                    SqlCommand komut = new SqlCommand("insert into Mesai (Personel_ID,Ay,Saat) values (@p1,@p2,@p3)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", Convert.ToInt32(TxtPersonelId.Text));
                    komut.Parameters.AddWithValue("@p2", Convert.ToInt32(TxtAy.Text));
                    komut.Parameters.AddWithValue("@p3", Convert.ToInt32(TxtSaat.Text));
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Mesai bilgisi oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizle();
                    Toplamlistele();
                }
                else { MessageBox.Show("Mesai Bilgisi Girmelisiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("Mesai Kaydı Sistemde Mevcut!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtMesaiId.Text = dr["Mesai_ID"].ToString();
            TxtPersonelId.Text = dr["Personel_ID"].ToString();
            TxtPersonel.Text = dr["Ad_Soyad"].ToString();
            TxtAy.Text = dr["Ay"].ToString();
            TxtSaat.Text = dr["Saat"].ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtMesaiId.Text != "")
            {
                DialogResult result = MessageBox.Show("Mesai Bilgisini Silmeyi Onaylıyor Musunuz ?", "Uyarı", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        SqlCommand komutsil = new SqlCommand("delete from Mesai where Mesai_ID=@p1", bgl.baglanti());
                        komutsil.Parameters.AddWithValue("@p1", TxtMesaiId.Text);
                        komutsil.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Mesai Bilgisi Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        listele();
                        temizle();
                        Toplamlistele();
                    }
                    catch
                    {
                        MessageBox.Show("Silinemez !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else { MessageBox.Show("Silinecek Bilgiyi Seçmelisiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void gridView2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            int durum = Convert.ToInt32(gridView2.GetRowCellValue(e.RowHandle, "toplamsaat"));
            
            if (durum >= 270)
            {
                e.Appearance.BackColor = Color.Gray;
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtMesaiId.Text != "")
            {
                SqlCommand komutguncelle = new SqlCommand("update Mesai set Ay=@p1, Saat=@p2 where Mesai_Id=@p3", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@p1", Convert.ToInt32(TxtAy.Text));
                komutguncelle.Parameters.AddWithValue("@p2", Convert.ToInt32(TxtSaat.Text));
                komutguncelle.Parameters.AddWithValue("@p3", TxtMesaiId.Text);

                komutguncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Mesai Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
                temizle();
                Toplamlistele();
            }
            else { MessageBox.Show("Güncellenecek Bilgiyi Seçmelisiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnExcel1_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Excel Çalışma Kitabı |*.xls",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                FileName = "Mesai.xls"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
                gridView1.ExportToXls(dialog.FileName);
        }

        private void BtnExcel2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Excel Çalışma Kitabı |*.xls",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                FileName = "MesaiToplu.xls"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
                gridView2.ExportToXls(dialog.FileName);
        }
    }
}
