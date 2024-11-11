namespace PersonelTakip
{
    partial class FrmYillikIzin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYillikIzin));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTamamlandı = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtIzinTarih = new DevExpress.XtraEditors.DateEdit();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.TxtYillikId = new DevExpress.XtraEditors.TextEdit();
            this.BtnPersonelRehber = new DevExpress.XtraEditors.SimpleButton();
            this.TxtPersonel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TxtPersonelId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtKullanilanGun = new DevExpress.XtraEditors.SpinEdit();
            this.TxtYil = new DevExpress.XtraEditors.LookUpEdit();
            this.BtnExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIzinTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIzinTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYillikId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullanilanGun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYil.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(-1, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(837, 564);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnTamamlandı);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TxtIzinTarih);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.TxtYillikId);
            this.groupControl1.Controls.Add(this.BtnPersonelRehber);
            this.groupControl1.Controls.Add(this.TxtPersonel);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.TxtPersonelId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.TxtKullanilanGun);
            this.groupControl1.Controls.Add(this.TxtYil);
            this.groupControl1.Location = new System.Drawing.Point(853, 23);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(400, 564);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Yıllık İzin Girişi";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(102, 170);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(100, 35);
            this.BtnGuncelle.TabIndex = 21;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnTamamlandı
            // 
            this.BtnTamamlandı.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTamamlandı.Appearance.Options.UseFont = true;
            this.BtnTamamlandı.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTamamlandı.ImageOptions.Image")));
            this.BtnTamamlandı.Location = new System.Drawing.Point(102, 211);
            this.BtnTamamlandı.Name = "BtnTamamlandı";
            this.BtnTamamlandı.Size = new System.Drawing.Size(204, 35);
            this.BtnTamamlandı.TabIndex = 20;
            this.BtnTamamlandı.Text = "TAMAMLANDI";
            this.BtnTamamlandı.Click += new System.EventHandler(this.BtnTamamlandı_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 16);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Kullanılan Gün :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 79);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 16);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "İzin Tarihi :";
            // 
            // TxtIzinTarih
            // 
            this.TxtIzinTarih.EditValue = null;
            this.TxtIzinTarih.Location = new System.Drawing.Point(102, 77);
            this.TxtIzinTarih.Name = "TxtIzinTarih";
            this.TxtIzinTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtIzinTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtIzinTarih.Properties.DisplayFormat.FormatString = "";
            this.TxtIzinTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtIzinTarih.Properties.EditFormat.FormatString = "";
            this.TxtIzinTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtIzinTarih.Properties.MaskSettings.Set("mask", "");
            this.TxtIzinTarih.Size = new System.Drawing.Size(204, 20);
            this.TxtIzinTarih.TabIndex = 17;
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(208, 129);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(100, 35);
            this.BtnSil.TabIndex = 15;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // TxtYillikId
            // 
            this.TxtYillikId.Location = new System.Drawing.Point(126, 480);
            this.TxtYillikId.Name = "TxtYillikId";
            this.TxtYillikId.Size = new System.Drawing.Size(63, 20);
            this.TxtYillikId.TabIndex = 14;
            this.TxtYillikId.Visible = false;
            // 
            // BtnPersonelRehber
            // 
            this.BtnPersonelRehber.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnPersonelRehber.Appearance.Options.UseForeColor = true;
            this.BtnPersonelRehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonelRehber.ImageOptions.Image")));
            this.BtnPersonelRehber.Location = new System.Drawing.Point(102, 23);
            this.BtnPersonelRehber.Name = "BtnPersonelRehber";
            this.BtnPersonelRehber.Size = new System.Drawing.Size(22, 22);
            this.BtnPersonelRehber.TabIndex = 13;
            this.BtnPersonelRehber.Click += new System.EventHandler(this.BtnPersonelRehber_Click);
            // 
            // TxtPersonel
            // 
            this.TxtPersonel.Enabled = false;
            this.TxtPersonel.Location = new System.Drawing.Point(126, 25);
            this.TxtPersonel.Name = "TxtPersonel";
            this.TxtPersonel.Size = new System.Drawing.Size(180, 20);
            this.TxtPersonel.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 16);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Personel :";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(208, 170);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(100, 35);
            this.BtnTemizle.TabIndex = 10;
            this.BtnTemizle.Text = "TEMİZLE";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(102, 129);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(100, 35);
            this.BtnKaydet.TabIndex = 9;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtPersonelId
            // 
            this.TxtPersonelId.Location = new System.Drawing.Point(214, 480);
            this.TxtPersonelId.Name = "TxtPersonelId";
            this.TxtPersonelId.Size = new System.Drawing.Size(63, 20);
            this.TxtPersonelId.TabIndex = 6;
            this.TxtPersonelId.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Yıl :";
            // 
            // TxtKullanilanGun
            // 
            this.TxtKullanilanGun.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtKullanilanGun.Location = new System.Drawing.Point(102, 103);
            this.TxtKullanilanGun.Name = "TxtKullanilanGun";
            this.TxtKullanilanGun.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtKullanilanGun.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.TxtKullanilanGun.Properties.IsFloatValue = false;
            this.TxtKullanilanGun.Properties.MaskSettings.Set("mask", "N00");
            this.TxtKullanilanGun.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.TxtKullanilanGun.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtKullanilanGun.Size = new System.Drawing.Size(204, 20);
            this.TxtKullanilanGun.TabIndex = 19;
            // 
            // TxtYil
            // 
            this.TxtYil.Location = new System.Drawing.Point(102, 51);
            this.TxtYil.Name = "TxtYil";
            this.TxtYil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtYil.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtYil.Properties.DropDownRows = 60;
            this.TxtYil.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtYil.Properties.NullText = "";
            this.TxtYil.Size = new System.Drawing.Size(204, 20);
            this.TxtYil.TabIndex = 3;
            // 
            // BtnExcel
            // 
            this.BtnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcel.Appearance.BackColor = System.Drawing.Color.Teal;
            this.BtnExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnExcel.Appearance.Options.UseBackColor = true;
            this.BtnExcel.Appearance.Options.UseFont = true;
            this.BtnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcel.ImageOptions.Image")));
            this.BtnExcel.Location = new System.Drawing.Point(-1, -2);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(1254, 26);
            this.BtnExcel.TabIndex = 10;
            this.BtnExcel.Text = "EXCELE AKTAR";
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // FrmYillikIzin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 588);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmYillikIzin";
            this.Text = "Yıllık İzin";
            this.Load += new System.EventHandler(this.FrmYillikIzin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIzinTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIzinTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYillikId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullanilanGun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYil.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit TxtIzinTarih;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.TextEdit TxtYillikId;
        private DevExpress.XtraEditors.SimpleButton BtnPersonelRehber;
        private DevExpress.XtraEditors.TextEdit TxtPersonel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit TxtPersonelId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnTamamlandı;
        private DevExpress.XtraEditors.SpinEdit TxtKullanilanGun;
        private DevExpress.XtraEditors.LookUpEdit TxtYil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnExcel;
    }
}