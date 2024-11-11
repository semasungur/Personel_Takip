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
    public partial class FrmPersonelRehber : Form
    {
        public static string PersonelIsim;
        public static int Id;
        public FrmPersonelRehber()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Personel_Id,Ad_Soyad from Personel WHERE durum=1", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns[0].Visible = false;
        }

        private void FrmPersonelRehber_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            PersonelIsim = gridView1.GetFocusedRowCellValue("Ad_Soyad").ToString();
            Id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Personel_Id"));
            this.Close();
        }
    }
}
