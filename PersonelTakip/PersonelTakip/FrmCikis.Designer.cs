namespace PersonelTakip
{
    partial class FrmCikis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCikis));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtCikisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.BtnOnay = new DevExpress.XtraEditors.SimpleButton();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCikisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCikisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(112, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ÇIKIŞ TARİHİ";
            // 
            // TxtCikisTarihi
            // 
            this.TxtCikisTarihi.EditValue = null;
            this.TxtCikisTarihi.Location = new System.Drawing.Point(73, 63);
            this.TxtCikisTarihi.Name = "TxtCikisTarihi";
            this.TxtCikisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtCikisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtCikisTarihi.Properties.DisplayFormat.FormatString = "";
            this.TxtCikisTarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtCikisTarihi.Properties.EditFormat.FormatString = "";
            this.TxtCikisTarihi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtCikisTarihi.Properties.MaskSettings.Set("mask", "");
            this.TxtCikisTarihi.Size = new System.Drawing.Size(175, 20);
            this.TxtCikisTarihi.TabIndex = 1;
            // 
            // BtnOnay
            // 
            this.BtnOnay.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOnay.Appearance.Options.UseFont = true;
            this.BtnOnay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnOnay.ImageOptions.Image")));
            this.BtnOnay.Location = new System.Drawing.Point(112, 109);
            this.BtnOnay.Name = "BtnOnay";
            this.BtnOnay.Size = new System.Drawing.Size(103, 37);
            this.BtnOnay.TabIndex = 2;
            this.BtnOnay.Text = "TAMAM";
            this.BtnOnay.Click += new System.EventHandler(this.BtnOnay_Click);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(73, 171);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 3;
            this.TxtID.Visible = false;
            // 
            // FrmCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 203);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtnOnay);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TxtCikisTarihi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCikis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÇIKIŞ";
            this.Load += new System.EventHandler(this.FrmCikis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtCikisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCikisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit TxtCikisTarihi;
        private DevExpress.XtraEditors.SimpleButton BtnOnay;
        private DevExpress.XtraEditors.TextEdit TxtID;
    }
}