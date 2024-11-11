namespace PersonelTakip
{
    partial class FrmKimlik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKimlik));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GoupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.CmbSgkTip = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.TxtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.TxtTc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDogumTarih = new DevExpress.XtraEditors.DateEdit();
            this.TxtDosyaNo = new DevExpress.XtraEditors.SpinEdit();
            this.BtnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtGirisTarih = new DevExpress.XtraEditors.DateEdit();
            this.BtnAyrildi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoupControl1)).BeginInit();
            this.GoupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbSgkTip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDogumTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDogumTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDosyaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGirisTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGirisTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(0, 27);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(837, 558);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // GoupControl1
            // 
            this.GoupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoupControl1.Controls.Add(this.BtnAyrildi);
            this.GoupControl1.Controls.Add(this.labelControl6);
            this.GoupControl1.Controls.Add(this.TxtGirisTarih);
            this.GoupControl1.Controls.Add(this.labelControl5);
            this.GoupControl1.Controls.Add(this.labelControl4);
            this.GoupControl1.Controls.Add(this.CmbSgkTip);
            this.GoupControl1.Controls.Add(this.BtnTemizle);
            this.GoupControl1.Controls.Add(this.BtnGuncelle);
            this.GoupControl1.Controls.Add(this.BtnSil);
            this.GoupControl1.Controls.Add(this.BtnKaydet);
            this.GoupControl1.Controls.Add(this.TxtID);
            this.GoupControl1.Controls.Add(this.TxtAdSoyad);
            this.GoupControl1.Controls.Add(this.TxtTc);
            this.GoupControl1.Controls.Add(this.labelControl3);
            this.GoupControl1.Controls.Add(this.labelControl2);
            this.GoupControl1.Controls.Add(this.labelControl1);
            this.GoupControl1.Controls.Add(this.TxtDogumTarih);
            this.GoupControl1.Controls.Add(this.TxtDosyaNo);
            this.GoupControl1.Location = new System.Drawing.Point(844, 27);
            this.GoupControl1.Name = "GoupControl1";
            this.GoupControl1.Size = new System.Drawing.Size(400, 558);
            this.GoupControl1.TabIndex = 1;
            this.GoupControl1.Text = "Kimlik Bilgi Girişi";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(18, 169);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 16);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "DOSYA NO :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(18, 143);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 16);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "SGK TİP :";
            // 
            // CmbSgkTip
            // 
            this.CmbSgkTip.Location = new System.Drawing.Point(125, 142);
            this.CmbSgkTip.Name = "CmbSgkTip";
            this.CmbSgkTip.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbSgkTip.Properties.DropDownRows = 3;
            this.CmbSgkTip.Properties.Items.AddRange(new object[] {
            "Üretim",
            "İdari",
            "Emekli"});
            this.CmbSgkTip.Size = new System.Drawing.Size(204, 20);
            this.CmbSgkTip.TabIndex = 12;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(243, 285);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(112, 35);
            this.BtnTemizle.TabIndex = 10;
            this.BtnTemizle.Text = "TEMİZLE";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(125, 285);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(112, 35);
            this.BtnGuncelle.TabIndex = 9;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(243, 244);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(112, 35);
            this.BtnSil.TabIndex = 8;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(125, 244);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(112, 35);
            this.BtnKaydet.TabIndex = 7;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(147, 451);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 6;
            this.TxtID.Visible = false;
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(125, 72);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(204, 20);
            this.TxtAdSoyad.TabIndex = 4;
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(125, 35);
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.TxtTc.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.TxtTc.Size = new System.Drawing.Size(204, 20);
            this.TxtTc.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "DOĞUM TARİHİ :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "AD - SOYAD :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "TC NO :";
            // 
            // TxtDogumTarih
            // 
            this.TxtDogumTarih.EditValue = null;
            this.TxtDogumTarih.Location = new System.Drawing.Point(125, 107);
            this.TxtDogumTarih.Name = "TxtDogumTarih";
            this.TxtDogumTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtDogumTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtDogumTarih.Properties.DisplayFormat.FormatString = "";
            this.TxtDogumTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtDogumTarih.Properties.EditFormat.FormatString = "";
            this.TxtDogumTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtDogumTarih.Properties.MaskSettings.Set("mask", "");
            this.TxtDogumTarih.Size = new System.Drawing.Size(204, 20);
            this.TxtDogumTarih.TabIndex = 5;
            // 
            // TxtDosyaNo
            // 
            this.TxtDosyaNo.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtDosyaNo.Location = new System.Drawing.Point(125, 168);
            this.TxtDosyaNo.Name = "TxtDosyaNo";
            this.TxtDosyaNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtDosyaNo.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.TxtDosyaNo.Properties.IsFloatValue = false;
            this.TxtDosyaNo.Properties.MaskSettings.Set("mask", "N00");
            this.TxtDosyaNo.Properties.MaxValue = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.TxtDosyaNo.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtDosyaNo.Size = new System.Drawing.Size(204, 20);
            this.TxtDosyaNo.TabIndex = 14;
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
            this.BtnExcel.Location = new System.Drawing.Point(0, -2);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(1244, 32);
            this.BtnExcel.TabIndex = 2;
            this.BtnExcel.Text = "EXCELE AKTAR";
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(18, 202);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(93, 16);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "GİRİŞ TARİHİ :";
            // 
            // TxtGirisTarih
            // 
            this.TxtGirisTarih.EditValue = null;
            this.TxtGirisTarih.Location = new System.Drawing.Point(125, 201);
            this.TxtGirisTarih.Name = "TxtGirisTarih";
            this.TxtGirisTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtGirisTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtGirisTarih.Properties.DisplayFormat.FormatString = "";
            this.TxtGirisTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtGirisTarih.Properties.EditFormat.FormatString = "";
            this.TxtGirisTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtGirisTarih.Properties.MaskSettings.Set("mask", "");
            this.TxtGirisTarih.Size = new System.Drawing.Size(204, 20);
            this.TxtGirisTarih.TabIndex = 16;
            // 
            // BtnAyrildi
            // 
            this.BtnAyrildi.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAyrildi.Appearance.Options.UseFont = true;
            this.BtnAyrildi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAyrildi.ImageOptions.Image")));
            this.BtnAyrildi.Location = new System.Drawing.Point(125, 326);
            this.BtnAyrildi.Name = "BtnAyrildi";
            this.BtnAyrildi.Size = new System.Drawing.Size(230, 35);
            this.BtnAyrildi.TabIndex = 17;
            this.BtnAyrildi.Text = "AYRILDI";
            this.BtnAyrildi.Click += new System.EventHandler(this.BtnAyrildi_Click);
            // 
            // FrmKimlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 588);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.GoupControl1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKimlik";
            this.Text = "Kimlik Bilgileri";
            this.Load += new System.EventHandler(this.FrmKimlik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoupControl1)).EndInit();
            this.GoupControl1.ResumeLayout(false);
            this.GoupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbSgkTip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDogumTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDogumTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDosyaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGirisTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGirisTarih.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl GoupControl1;
        private DevExpress.XtraEditors.TextEdit TxtAdSoyad;
        private DevExpress.XtraEditors.TextEdit TxtTc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit CmbSgkTip;
        private DevExpress.XtraEditors.DateEdit TxtDogumTarih;
        private DevExpress.XtraEditors.SimpleButton BtnExcel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit TxtDosyaNo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit TxtGirisTarih;
        private DevExpress.XtraEditors.SimpleButton BtnAyrildi;
    }
}