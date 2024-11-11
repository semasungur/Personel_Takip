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
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Personel_Id,Ad_Soyad from Personel where durum=1", bgl.baglanti());
            da.Fill(dt);
            gridControl5.DataSource = dt;
            gridView5.Columns[0].Visible = false;
        }
        void listele1()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Muayene where Personel_Id = @p1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", Convert.ToInt32(TxtPersonelId.Text));
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[1].Visible = false;
        }
        void listele2()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Ucretsiz_Izin where Personel_Id = @p1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", Convert.ToInt32(TxtPersonelId.Text));
            da.Fill(dt);
            gridControl3.DataSource = dt;
            gridView3.Columns[0].Visible = false;
            gridView3.Columns[4].Visible = false;
        }
        void listele3()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Ucretli_Izin where Personel_Id = @p1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", Convert.ToInt32(TxtPersonelId.Text));
            da.Fill(dt);
            gridControl4.DataSource = dt;
            gridView4.Columns[0].Visible = false;
            gridView4.Columns[4].Visible = false;
        }
        void listele4()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Mesai where Personel_Id = @p1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", Convert.ToInt32(TxtPersonelId.Text));
            da.Fill(dt);
            gridControl2.DataSource = dt;
            gridView2.Columns[0].Visible = false;
            gridView2.Columns[1].Visible = false;
        }
        void listele5()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Raporlu_Izin where Personel_Id = @p1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", Convert.ToInt32(TxtPersonelId.Text));
            da.Fill(dt);
            gridControl7.DataSource = dt;
            gridView7.Columns[0].Visible = false;
            gridView7.Columns[3].Visible = false;
        }
        void listele6()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Yillik_Izin where Personel_Id = @p1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", Convert.ToInt32(TxtPersonelId.Text));
            da.Fill(dt);
            gridControl6.DataSource = dt;
            gridView6.Columns[0].Visible = false;
            gridView6.Columns[1].Visible = false;
            gridView6.Columns[5].Visible = false;
        }
        private void gridView5_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView5.GetDataRow(gridView5.FocusedRowHandle);
            TxtPersonelId.Text = dr["Personel_ID"].ToString();
            listele1();
            listele2();
            listele3();
            listele4();
            listele5();
            listele6();
        }
        private void FrmRapor_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView6_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            int durum = Convert.ToInt32(gridView6.GetRowCellValue(e.RowHandle, "Durum"));
            if (durum == 1)
            {
                e.Appearance.BackColor = Color.Red;
            }
        }
    }
}
