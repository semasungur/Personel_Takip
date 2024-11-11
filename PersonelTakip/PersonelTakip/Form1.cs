using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class PersonelTakip : Form
    {
        public PersonelTakip()
        {
            InitializeComponent();
        }
        FrmKimlik fr;
        private void BtnKimlik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new FrmKimlik();
                fr.MdiParent = this;
                fr.Show();
            }
        }
       
       
        FrmAyrilan fr2;
        private void BtnAyrilan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null || fr.IsDisposed)
            {
                fr2 = new FrmAyrilan();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }
        
        FrmMuayene fr3;
        private void BtnMuayene_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null || fr.IsDisposed)
            {
                fr3 = new FrmMuayene();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
        FrmUcretsizIzin fr4;
        private void BtnUcretsizIzin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null || fr.IsDisposed)
            {
                fr4 = new FrmUcretsizIzin();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }
        FrmUcretliIzin fr5;
        private void BtnUcretliIzin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr.IsDisposed)
            {
                fr5 = new FrmUcretliIzin();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }
        FrmRaporluIzin fr6;
        private void BtnRaporluIzin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null || fr.IsDisposed)
            {
                fr6 = new FrmRaporluIzin();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }
        FrmMesai fr7;
        private void BtnMesai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null || fr.IsDisposed)
            {
                fr7 = new FrmMesai();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }
        FrmYillikIzin fr8;
        private void BtnYillikIzin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null || fr.IsDisposed)
            {
                fr8 = new FrmYillikIzin();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }
        private void PersonelTakip_Load(object sender, EventArgs e)
        {

        }
        FrmAnasayfa fr9;
        private void BtnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null || fr.IsDisposed)
            {
                fr9 = new FrmAnasayfa();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }
        FrmEk fr10;
        private void BtnEk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null || fr.IsDisposed)
            {
                fr10 = new FrmEk();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }
        FrmAyrilan fr11;
        private void BtnAyrilanPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null || fr.IsDisposed)
            {
                fr11 = new FrmAyrilan();
                fr11.MdiParent = this;
                fr11.Show();
            }
        }
        FrmRapor fr12;
        private void BtnRapor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null || fr.IsDisposed)
            {
                fr12 = new FrmRapor();
                fr12.MdiParent = this;
                fr12.Show();
            }
        }
    }
}
