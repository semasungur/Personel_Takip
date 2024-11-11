namespace PersonelTakip
{
    partial class FrmUcretliIzin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUcretliIzin));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBitisTarih = new DevExpress.XtraEditors.DateEdit();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.TxtUcretliId = new DevExpress.XtraEditors.TextEdit();
            this.BtnPersonelRehber = new DevExpress.XtraEditors.SimpleButton();
            this.TxtPersonel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TxtPersonelId = new DevExpress.XtraEditors.TextEdit();
            this.TxtSebep = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBaslangicTarih = new DevExpress.XtraEditors.DateEdit();
            this.BtnExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBitisTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBitisTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUcretliId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSebep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslangicTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslangicTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(0, 26);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(837, 559);
            this.gridControl1.TabIndex = 6;
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
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TxtBitisTarih);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.TxtUcretliId);
            this.groupControl1.Controls.Add(this.BtnPersonelRehber);
            this.groupControl1.Controls.Add(this.TxtPersonel);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.TxtPersonelId);
            this.groupControl1.Controls.Add(this.TxtSebep);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.TxtBaslangicTarih);
            this.groupControl1.Location = new System.Drawing.Point(855, 26);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(400, 559);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Ücretli İzin Girişi";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(76, 204);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(204, 35);
            this.BtnGuncelle.TabIndex = 19;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 101);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 16);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Bit.Tarihi :";
            // 
            // TxtBitisTarih
            // 
            this.TxtBitisTarih.EditValue = null;
            this.TxtBitisTarih.Location = new System.Drawing.Point(76, 99);
            this.TxtBitisTarih.Name = "TxtBitisTarih";
            this.TxtBitisTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtBitisTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtBitisTarih.Properties.DisplayFormat.FormatString = "";
            this.TxtBitisTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtBitisTarih.Properties.EditFormat.FormatString = "";
            this.TxtBitisTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtBitisTarih.Properties.MaskSettings.Set("mask", "");
            this.TxtBitisTarih.Size = new System.Drawing.Size(204, 20);
            this.TxtBitisTarih.TabIndex = 17;
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(76, 245);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(204, 35);
            this.BtnSil.TabIndex = 15;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // TxtUcretliId
            // 
            this.TxtUcretliId.Location = new System.Drawing.Point(126, 424);
            this.TxtUcretliId.Name = "TxtUcretliId";
            this.TxtUcretliId.Size = new System.Drawing.Size(63, 20);
            this.TxtUcretliId.TabIndex = 14;
            this.TxtUcretliId.Visible = false;
            // 
            // BtnPersonelRehber
            // 
            this.BtnPersonelRehber.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnPersonelRehber.Appearance.Options.UseForeColor = true;
            this.BtnPersonelRehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonelRehber.ImageOptions.Image")));
            this.BtnPersonelRehber.Location = new System.Drawing.Point(76, 32);
            this.BtnPersonelRehber.Name = "BtnPersonelRehber";
            this.BtnPersonelRehber.Size = new System.Drawing.Size(22, 22);
            this.BtnPersonelRehber.TabIndex = 13;
            this.BtnPersonelRehber.Click += new System.EventHandler(this.BtnPersonelRehber_Click);
            // 
            // TxtPersonel
            // 
            this.TxtPersonel.Enabled = false;
            this.TxtPersonel.Location = new System.Drawing.Point(100, 34);
            this.TxtPersonel.Name = "TxtPersonel";
            this.TxtPersonel.Size = new System.Drawing.Size(180, 20);
            this.TxtPersonel.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 35);
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
            this.BtnTemizle.Location = new System.Drawing.Point(73, 286);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(204, 35);
            this.BtnTemizle.TabIndex = 10;
            this.BtnTemizle.Text = "TEMİZLE";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(76, 157);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(204, 35);
            this.BtnKaydet.TabIndex = 9;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtPersonelId
            // 
            this.TxtPersonelId.Location = new System.Drawing.Point(214, 424);
            this.TxtPersonelId.Name = "TxtPersonelId";
            this.TxtPersonelId.Size = new System.Drawing.Size(63, 20);
            this.TxtPersonelId.TabIndex = 6;
            this.TxtPersonelId.Visible = false;
            // 
            // TxtSebep
            // 
            this.TxtSebep.Location = new System.Drawing.Point(76, 131);
            this.TxtSebep.Name = "TxtSebep";
            this.TxtSebep.Size = new System.Drawing.Size(204, 20);
            this.TxtSebep.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 133);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Sebep :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Baş.Tarihi :";
            // 
            // TxtBaslangicTarih
            // 
            this.TxtBaslangicTarih.EditValue = null;
            this.TxtBaslangicTarih.Location = new System.Drawing.Point(76, 68);
            this.TxtBaslangicTarih.Name = "TxtBaslangicTarih";
            this.TxtBaslangicTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtBaslangicTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtBaslangicTarih.Properties.DisplayFormat.FormatString = "";
            this.TxtBaslangicTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtBaslangicTarih.Properties.EditFormat.FormatString = "";
            this.TxtBaslangicTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtBaslangicTarih.Properties.MaskSettings.Set("mask", "");
            this.TxtBaslangicTarih.Size = new System.Drawing.Size(204, 20);
            this.TxtBaslangicTarih.TabIndex = 3;
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
            this.BtnExcel.Location = new System.Drawing.Point(0, -1);
            this.BtnExcel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(1255, 32);
            this.BtnExcel.TabIndex = 8;
            this.BtnExcel.Text = "EXCELE AKTAR";
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // FrmUcretliIzin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 588);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmUcretliIzin";
            this.Text = "Ücretli İzin";
            this.Load += new System.EventHandler(this.FrmUcretliIzin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBitisTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBitisTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUcretliId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSebep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslangicTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslangicTarih.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit TxtBitisTarih;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.TextEdit TxtUcretliId;
        private DevExpress.XtraEditors.SimpleButton BtnPersonelRehber;
        private DevExpress.XtraEditors.TextEdit TxtPersonel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit TxtPersonelId;
        private DevExpress.XtraEditors.TextEdit TxtSebep;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit TxtBaslangicTarih;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnExcel;
    }
}