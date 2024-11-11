namespace PersonelTakip
{
    partial class FrmEk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEk));
            this.BtnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtMezuniyetTarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAdres = new DevExpress.XtraEditors.TextEdit();
            this.TxtTel = new DevExpress.XtraEditors.TextEdit();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.CmbMedeniDurum = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtCocukSayisi = new DevExpress.XtraEditors.SpinEdit();
            this.TxtHesapNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtOkul = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TxtIban = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMezuniyetTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMezuniyetTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbMedeniDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCocukSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOkul.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIban.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.BtnExcel.Location = new System.Drawing.Point(0, 1);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(1255, 30);
            this.BtnExcel.TabIndex = 6;
            this.BtnExcel.Text = "EXCELE AKTAR";
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.Location = new System.Drawing.Point(1, 37);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(837, 549);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.TxtMezuniyetTarih);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtAdres);
            this.groupControl1.Controls.Add(this.TxtTel);
            this.groupControl1.Controls.Add(this.TxtID);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.CmbMedeniDurum);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.TxtCocukSayisi);
            this.groupControl1.Controls.Add(this.TxtHesapNo);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.TxtOkul);
            this.groupControl1.Controls.Add(this.TxtIban);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(844, 37);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(357, 349);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Ek Bilgiler";
            // 
            // TxtMezuniyetTarih
            // 
            this.TxtMezuniyetTarih.EditValue = null;
            this.TxtMezuniyetTarih.Location = new System.Drawing.Point(116, 287);
            this.TxtMezuniyetTarih.Name = "TxtMezuniyetTarih";
            this.TxtMezuniyetTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtMezuniyetTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtMezuniyetTarih.Properties.DisplayFormat.FormatString = "";
            this.TxtMezuniyetTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtMezuniyetTarih.Properties.EditFormat.FormatString = "";
            this.TxtMezuniyetTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtMezuniyetTarih.Properties.MaskSettings.Set("mask", "d");
            this.TxtMezuniyetTarih.Size = new System.Drawing.Size(185, 20);
            this.TxtMezuniyetTarih.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 144);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 16);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Çocuk Sayısı :";
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(116, 220);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(186, 20);
            this.TxtAdres.TabIndex = 4;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(116, 186);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.TxtTel.Properties.MaskSettings.Set("mask", "\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?");
            this.TxtTel.Size = new System.Drawing.Size(186, 20);
            this.TxtTel.TabIndex = 3;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(170, 324);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(44, 20);
            this.TxtID.TabIndex = 6;
            this.TxtID.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 113);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Medeni Durum :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 221);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 16);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "ADRES :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(3, 288);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(103, 16);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "MEZUN. TARİHİ :";
            // 
            // CmbMedeniDurum
            // 
            this.CmbMedeniDurum.Location = new System.Drawing.Point(116, 112);
            this.CmbMedeniDurum.Name = "CmbMedeniDurum";
            this.CmbMedeniDurum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbMedeniDurum.Properties.DropDownRows = 2;
            this.CmbMedeniDurum.Properties.Items.AddRange(new object[] {
            "Evli",
            "Bekar"});
            this.CmbMedeniDurum.Size = new System.Drawing.Size(186, 20);
            this.CmbMedeniDurum.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 190);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 16);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "TELEFON :";
            // 
            // TxtCocukSayisi
            // 
            this.TxtCocukSayisi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TxtCocukSayisi.Location = new System.Drawing.Point(116, 143);
            this.TxtCocukSayisi.Name = "TxtCocukSayisi";
            this.TxtCocukSayisi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtCocukSayisi.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.TxtCocukSayisi.Properties.IsFloatValue = false;
            this.TxtCocukSayisi.Properties.MaskSettings.Set("mask", "N00");
            this.TxtCocukSayisi.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.TxtCocukSayisi.Size = new System.Drawing.Size(186, 20);
            this.TxtCocukSayisi.TabIndex = 4;
            // 
            // TxtHesapNo
            // 
            this.TxtHesapNo.Location = new System.Drawing.Point(115, 66);
            this.TxtHesapNo.Name = "TxtHesapNo";
            this.TxtHesapNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtHesapNo.Properties.MaskSettings.Set("mask", "99999999");
            this.TxtHesapNo.Size = new System.Drawing.Size(186, 20);
            this.TxtHesapNo.TabIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(5, 261);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(41, 16);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "OKUL :";
            // 
            // TxtOkul
            // 
            this.TxtOkul.Location = new System.Drawing.Point(116, 260);
            this.TxtOkul.Name = "TxtOkul";
            this.TxtOkul.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtOkul.Properties.Items.AddRange(new object[] {
            "İlkokul",
            "Ortaokul",
            "Lise",
            "Önlisans",
            "Lisans"});
            this.TxtOkul.Size = new System.Drawing.Size(186, 20);
            this.TxtOkul.TabIndex = 3;
            // 
            // TxtIban
            // 
            this.TxtIban.Location = new System.Drawing.Point(115, 33);
            this.TxtIban.Name = "TxtIban";
            this.TxtIban.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.TxtIban.Properties.MaskSettings.Set("mask", "TR\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.TxtIban.Size = new System.Drawing.Size(186, 20);
            this.TxtIban.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "HESAP NO :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "IBAN :";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(844, 442);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(357, 35);
            this.BtnTemizle.TabIndex = 13;
            this.BtnTemizle.Text = "TEMİZLE";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(844, 401);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(357, 35);
            this.BtnGuncelle.TabIndex = 12;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // FrmEk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 588);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.BtnExcel);
            this.Name = "FrmEk";
            this.Text = "Ek Bilgiler";
            this.Load += new System.EventHandler(this.FrmEk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMezuniyetTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMezuniyetTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbMedeniDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCocukSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOkul.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIban.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnExcel;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.TextEdit TxtHesapNo;
        private DevExpress.XtraEditors.TextEdit TxtIban;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit CmbMedeniDurum;
        private DevExpress.XtraEditors.SpinEdit TxtCocukSayisi;
        private DevExpress.XtraEditors.TextEdit TxtAdres;
        private DevExpress.XtraEditors.TextEdit TxtTel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit TxtOkul;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.DateEdit TxtMezuniyetTarih;
    }
}