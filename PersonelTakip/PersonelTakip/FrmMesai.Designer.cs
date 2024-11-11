namespace PersonelTakip
{
    partial class FrmMesai
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMesai));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.TxtMesaiId = new DevExpress.XtraEditors.TextEdit();
            this.BtnPersonelRehber = new DevExpress.XtraEditors.SimpleButton();
            this.TxtPersonel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TxtPersonelId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAy = new DevExpress.XtraEditors.SpinEdit();
            this.TxtSaat = new DevExpress.XtraEditors.SpinEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnExcel1 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnExcel2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMesaiId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.Location = new System.Drawing.Point(1, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(477, 562);
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
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.TxtMesaiId);
            this.groupControl1.Controls.Add(this.BtnPersonelRehber);
            this.groupControl1.Controls.Add(this.TxtPersonel);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.TxtPersonelId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.TxtAy);
            this.groupControl1.Controls.Add(this.TxtSaat);
            this.groupControl1.Location = new System.Drawing.Point(853, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(400, 585);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Mesai Bilgi Girişi";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(84, 171);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(204, 35);
            this.BtnGuncelle.TabIndex = 22;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 106);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 16);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Saat :";
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(84, 212);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(204, 35);
            this.BtnSil.TabIndex = 15;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // TxtMesaiId
            // 
            this.TxtMesaiId.Location = new System.Drawing.Point(126, 361);
            this.TxtMesaiId.Name = "TxtMesaiId";
            this.TxtMesaiId.Size = new System.Drawing.Size(63, 20);
            this.TxtMesaiId.TabIndex = 14;
            this.TxtMesaiId.Visible = false;
            // 
            // BtnPersonelRehber
            // 
            this.BtnPersonelRehber.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnPersonelRehber.Appearance.Options.UseForeColor = true;
            this.BtnPersonelRehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonelRehber.ImageOptions.Image")));
            this.BtnPersonelRehber.Location = new System.Drawing.Point(85, 37);
            this.BtnPersonelRehber.Name = "BtnPersonelRehber";
            this.BtnPersonelRehber.Size = new System.Drawing.Size(22, 22);
            this.BtnPersonelRehber.TabIndex = 13;
            this.BtnPersonelRehber.Click += new System.EventHandler(this.BtnPersonelRehber_Click);
            // 
            // TxtPersonel
            // 
            this.TxtPersonel.Enabled = false;
            this.TxtPersonel.Location = new System.Drawing.Point(113, 38);
            this.TxtPersonel.Name = "TxtPersonel";
            this.TxtPersonel.Size = new System.Drawing.Size(175, 20);
            this.TxtPersonel.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 39);
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
            this.BtnTemizle.Location = new System.Drawing.Point(84, 253);
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
            this.BtnKaydet.Location = new System.Drawing.Point(84, 130);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(204, 35);
            this.BtnKaydet.TabIndex = 9;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtPersonelId
            // 
            this.TxtPersonelId.Location = new System.Drawing.Point(214, 361);
            this.TxtPersonelId.Name = "TxtPersonelId";
            this.TxtPersonelId.Size = new System.Drawing.Size(63, 20);
            this.TxtPersonelId.TabIndex = 6;
            this.TxtPersonelId.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ay :";
            // 
            // TxtAy
            // 
            this.TxtAy.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtAy.Location = new System.Drawing.Point(84, 69);
            this.TxtAy.Name = "TxtAy";
            this.TxtAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtAy.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtAy.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtAy.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.TxtAy.Properties.IsFloatValue = false;
            this.TxtAy.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtAy.Properties.MaskSettings.Set("mask", "d");
            this.TxtAy.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.TxtAy.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtAy.Size = new System.Drawing.Size(204, 20);
            this.TxtAy.TabIndex = 3;
            // 
            // TxtSaat
            // 
            this.TxtSaat.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtSaat.Location = new System.Drawing.Point(84, 102);
            this.TxtSaat.Name = "TxtSaat";
            this.TxtSaat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtSaat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtSaat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtSaat.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.TxtSaat.Properties.IsFloatValue = false;
            this.TxtSaat.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtSaat.Properties.MaskSettings.Set("mask", "d");
            this.TxtSaat.Properties.MaxValue = new decimal(new int[] {
            270,
            0,
            0,
            0});
            this.TxtSaat.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtSaat.Size = new System.Drawing.Size(204, 20);
            this.TxtSaat.TabIndex = 17;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Location = new System.Drawing.Point(484, 24);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(363, 563);
            this.gridControl2.TabIndex = 10;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView2_RowCellStyle);
            // 
            // BtnExcel1
            // 
            this.BtnExcel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcel1.Appearance.BackColor = System.Drawing.Color.Teal;
            this.BtnExcel1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnExcel1.Appearance.Options.UseBackColor = true;
            this.BtnExcel1.Appearance.Options.UseFont = true;
            this.BtnExcel1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcel1.ImageOptions.Image")));
            this.BtnExcel1.Location = new System.Drawing.Point(1, 1);
            this.BtnExcel1.Name = "BtnExcel1";
            this.BtnExcel1.Size = new System.Drawing.Size(477, 23);
            this.BtnExcel1.TabIndex = 11;
            this.BtnExcel1.Text = "EXCELE AKTAR";
            this.BtnExcel1.Click += new System.EventHandler(this.BtnExcel1_Click);
            // 
            // BtnExcel2
            // 
            this.BtnExcel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcel2.Appearance.BackColor = System.Drawing.Color.Teal;
            this.BtnExcel2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnExcel2.Appearance.Options.UseBackColor = true;
            this.BtnExcel2.Appearance.Options.UseFont = true;
            this.BtnExcel2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcel2.ImageOptions.Image")));
            this.BtnExcel2.Location = new System.Drawing.Point(484, 1);
            this.BtnExcel2.Name = "BtnExcel2";
            this.BtnExcel2.Size = new System.Drawing.Size(363, 23);
            this.BtnExcel2.TabIndex = 12;
            this.BtnExcel2.Text = "EXCELE AKTAR";
            this.BtnExcel2.Click += new System.EventHandler(this.BtnExcel2_Click);
            // 
            // FrmMesai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 588);
            this.Controls.Add(this.BtnExcel2);
            this.Controls.Add(this.BtnExcel1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmMesai";
            this.Text = "Mesai Bilgileri";
            this.Load += new System.EventHandler(this.FrmMesai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMesaiId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.TextEdit TxtMesaiId;
        private DevExpress.XtraEditors.SimpleButton BtnPersonelRehber;
        private DevExpress.XtraEditors.TextEdit TxtPersonel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit TxtPersonelId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit TxtAy;
        private DevExpress.XtraEditors.SpinEdit TxtSaat;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnExcel1;
        private DevExpress.XtraEditors.SimpleButton BtnExcel2;
    }
}