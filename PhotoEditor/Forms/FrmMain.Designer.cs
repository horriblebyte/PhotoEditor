
namespace PhotoEditor.Forms {
    partial class FrmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.BtnConfigure = new System.Windows.Forms.Button();
            this.PbFirstImage = new System.Windows.Forms.PictureBox();
            this.TxtResolutionWidth = new System.Windows.Forms.TextBox();
            this.TxtResolutionHeight = new System.Windows.Forms.TextBox();
            this.LblResolutionWidth = new System.Windows.Forms.Label();
            this.LblResolutionHeight = new System.Windows.Forms.Label();
            this.GbResolutionSettings = new System.Windows.Forms.GroupBox();
            this.GbFocusArea = new System.Windows.Forms.GroupBox();
            this.TxtFocusAreaWidth = new System.Windows.Forms.TextBox();
            this.TxtFocusAreaHeight = new System.Windows.Forms.TextBox();
            this.LblFocusAreaHeight = new System.Windows.Forms.Label();
            this.LblFocusAreaWidth = new System.Windows.Forms.Label();
            this.GbResults = new System.Windows.Forms.GroupBox();
            this.GbResultImage = new System.Windows.Forms.GroupBox();
            this.PbResultImage = new System.Windows.Forms.PictureBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.GbSecondImage = new System.Windows.Forms.GroupBox();
            this.PbSecondImage = new System.Windows.Forms.PictureBox();
            this.GbFirstImage = new System.Windows.Forms.GroupBox();
            this.LblInfo = new System.Windows.Forms.Label();
            this.GbSettings = new System.Windows.Forms.GroupBox();
            this.GbOtherSettings = new System.Windows.Forms.GroupBox();
            this.CbShowDetail = new System.Windows.Forms.CheckBox();
            this.TxtHotkey = new System.Windows.Forms.TextBox();
            this.TxtMinimumDifferencePercentage = new System.Windows.Forms.TextBox();
            this.TxtTimerInterval = new System.Windows.Forms.TextBox();
            this.LblHotkey = new System.Windows.Forms.Label();
            this.LblMinimumDifferencePercentage = new System.Windows.Forms.Label();
            this.LblTimerInterval = new System.Windows.Forms.Label();
            this.MsMain = new System.Windows.Forms.MenuStrip();
            this.TsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.TtMain = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbFirstImage)).BeginInit();
            this.GbResolutionSettings.SuspendLayout();
            this.GbFocusArea.SuspendLayout();
            this.GbResults.SuspendLayout();
            this.GbResultImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbResultImage)).BeginInit();
            this.GbSecondImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSecondImage)).BeginInit();
            this.GbFirstImage.SuspendLayout();
            this.GbSettings.SuspendLayout();
            this.GbOtherSettings.SuspendLayout();
            this.MsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnConfigure
            // 
            this.BtnConfigure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfigure.Location = new System.Drawing.Point(167, 143);
            this.BtnConfigure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConfigure.Name = "BtnConfigure";
            this.BtnConfigure.Size = new System.Drawing.Size(147, 32);
            this.BtnConfigure.TabIndex = 0;
            this.BtnConfigure.Text = "Kaydet";
            this.BtnConfigure.UseVisualStyleBackColor = true;
            this.BtnConfigure.Click += new System.EventHandler(this.BtnConfigure_Click);
            // 
            // PbFirstImage
            // 
            this.PbFirstImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbFirstImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbFirstImage.Location = new System.Drawing.Point(6, 20);
            this.PbFirstImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PbFirstImage.Name = "PbFirstImage";
            this.PbFirstImage.Size = new System.Drawing.Size(75, 75);
            this.PbFirstImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbFirstImage.TabIndex = 1;
            this.PbFirstImage.TabStop = false;
            // 
            // TxtResolutionWidth
            // 
            this.TxtResolutionWidth.Location = new System.Drawing.Point(110, 19);
            this.TxtResolutionWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtResolutionWidth.Name = "TxtResolutionWidth";
            this.TxtResolutionWidth.Size = new System.Drawing.Size(40, 22);
            this.TxtResolutionWidth.TabIndex = 2;
            this.TxtResolutionWidth.Text = "1920";
            // 
            // TxtResolutionHeight
            // 
            this.TxtResolutionHeight.Location = new System.Drawing.Point(110, 45);
            this.TxtResolutionHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtResolutionHeight.Name = "TxtResolutionHeight";
            this.TxtResolutionHeight.Size = new System.Drawing.Size(40, 22);
            this.TxtResolutionHeight.TabIndex = 3;
            this.TxtResolutionHeight.Text = "1080";
            // 
            // LblResolutionWidth
            // 
            this.LblResolutionWidth.AutoSize = true;
            this.LblResolutionWidth.Location = new System.Drawing.Point(6, 22);
            this.LblResolutionWidth.Name = "LblResolutionWidth";
            this.LblResolutionWidth.Size = new System.Drawing.Size(72, 13);
            this.LblResolutionWidth.TabIndex = 4;
            this.LblResolutionWidth.Text = "Genişlik (px):";
            // 
            // LblResolutionHeight
            // 
            this.LblResolutionHeight.AutoSize = true;
            this.LblResolutionHeight.Location = new System.Drawing.Point(6, 48);
            this.LblResolutionHeight.Name = "LblResolutionHeight";
            this.LblResolutionHeight.Size = new System.Drawing.Size(78, 13);
            this.LblResolutionHeight.TabIndex = 5;
            this.LblResolutionHeight.Text = "Yükseklik (px):";
            // 
            // GbResolutionSettings
            // 
            this.GbResolutionSettings.Controls.Add(this.TxtResolutionWidth);
            this.GbResolutionSettings.Controls.Add(this.TxtResolutionHeight);
            this.GbResolutionSettings.Controls.Add(this.LblResolutionHeight);
            this.GbResolutionSettings.Controls.Add(this.LblResolutionWidth);
            this.GbResolutionSettings.Location = new System.Drawing.Point(6, 20);
            this.GbResolutionSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbResolutionSettings.Name = "GbResolutionSettings";
            this.GbResolutionSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbResolutionSettings.Size = new System.Drawing.Size(156, 76);
            this.GbResolutionSettings.TabIndex = 6;
            this.GbResolutionSettings.TabStop = false;
            this.GbResolutionSettings.Text = "Çözünürlük Ayarları";
            // 
            // GbFocusArea
            // 
            this.GbFocusArea.Controls.Add(this.TxtFocusAreaWidth);
            this.GbFocusArea.Controls.Add(this.TxtFocusAreaHeight);
            this.GbFocusArea.Controls.Add(this.LblFocusAreaHeight);
            this.GbFocusArea.Controls.Add(this.LblFocusAreaWidth);
            this.GbFocusArea.Location = new System.Drawing.Point(6, 100);
            this.GbFocusArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbFocusArea.Name = "GbFocusArea";
            this.GbFocusArea.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbFocusArea.Size = new System.Drawing.Size(156, 75);
            this.GbFocusArea.TabIndex = 7;
            this.GbFocusArea.TabStop = false;
            this.GbFocusArea.Text = "Odak Alanı Ayarları";
            // 
            // TxtFocusAreaWidth
            // 
            this.TxtFocusAreaWidth.Location = new System.Drawing.Point(110, 19);
            this.TxtFocusAreaWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFocusAreaWidth.Name = "TxtFocusAreaWidth";
            this.TxtFocusAreaWidth.Size = new System.Drawing.Size(40, 22);
            this.TxtFocusAreaWidth.TabIndex = 2;
            this.TxtFocusAreaWidth.Text = "15";
            // 
            // TxtFocusAreaHeight
            // 
            this.TxtFocusAreaHeight.Location = new System.Drawing.Point(110, 45);
            this.TxtFocusAreaHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFocusAreaHeight.Name = "TxtFocusAreaHeight";
            this.TxtFocusAreaHeight.Size = new System.Drawing.Size(40, 22);
            this.TxtFocusAreaHeight.TabIndex = 3;
            this.TxtFocusAreaHeight.Text = "15";
            // 
            // LblFocusAreaHeight
            // 
            this.LblFocusAreaHeight.AutoSize = true;
            this.LblFocusAreaHeight.Location = new System.Drawing.Point(6, 48);
            this.LblFocusAreaHeight.Name = "LblFocusAreaHeight";
            this.LblFocusAreaHeight.Size = new System.Drawing.Size(78, 13);
            this.LblFocusAreaHeight.TabIndex = 5;
            this.LblFocusAreaHeight.Text = "Yükseklik (px):";
            // 
            // LblFocusAreaWidth
            // 
            this.LblFocusAreaWidth.AutoSize = true;
            this.LblFocusAreaWidth.Location = new System.Drawing.Point(6, 22);
            this.LblFocusAreaWidth.Name = "LblFocusAreaWidth";
            this.LblFocusAreaWidth.Size = new System.Drawing.Size(72, 13);
            this.LblFocusAreaWidth.TabIndex = 4;
            this.LblFocusAreaWidth.Text = "Genişlik (px):";
            // 
            // GbResults
            // 
            this.GbResults.Controls.Add(this.GbResultImage);
            this.GbResults.Controls.Add(this.LblResult);
            this.GbResults.Controls.Add(this.GbSecondImage);
            this.GbResults.Controls.Add(this.GbFirstImage);
            this.GbResults.Location = new System.Drawing.Point(12, 235);
            this.GbResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbResults.Name = "GbResults";
            this.GbResults.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbResults.Size = new System.Drawing.Size(319, 150);
            this.GbResults.TabIndex = 8;
            this.GbResults.TabStop = false;
            this.GbResults.Text = "Sonuç";
            // 
            // GbResultImage
            // 
            this.GbResultImage.Controls.Add(this.PbResultImage);
            this.GbResultImage.Location = new System.Drawing.Point(217, 20);
            this.GbResultImage.Name = "GbResultImage";
            this.GbResultImage.Size = new System.Drawing.Size(87, 100);
            this.GbResultImage.TabIndex = 5;
            this.GbResultImage.TabStop = false;
            this.GbResultImage.Text = "Sonuç";
            // 
            // PbResultImage
            // 
            this.PbResultImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbResultImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbResultImage.Location = new System.Drawing.Point(6, 20);
            this.PbResultImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PbResultImage.Name = "PbResultImage";
            this.PbResultImage.Size = new System.Drawing.Size(75, 75);
            this.PbResultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbResultImage.TabIndex = 3;
            this.PbResultImage.TabStop = false;
            // 
            // LblResult
            // 
            this.LblResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblResult.Location = new System.Drawing.Point(6, 123);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(307, 25);
            this.LblResult.TabIndex = 0;
            this.LblResult.Text = "...";
            this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbSecondImage
            // 
            this.GbSecondImage.Controls.Add(this.PbSecondImage);
            this.GbSecondImage.Location = new System.Drawing.Point(116, 20);
            this.GbSecondImage.Name = "GbSecondImage";
            this.GbSecondImage.Size = new System.Drawing.Size(87, 100);
            this.GbSecondImage.TabIndex = 4;
            this.GbSecondImage.TabStop = false;
            this.GbSecondImage.Text = "2. Görüntü";
            // 
            // PbSecondImage
            // 
            this.PbSecondImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbSecondImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbSecondImage.Location = new System.Drawing.Point(6, 20);
            this.PbSecondImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PbSecondImage.Name = "PbSecondImage";
            this.PbSecondImage.Size = new System.Drawing.Size(75, 75);
            this.PbSecondImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbSecondImage.TabIndex = 2;
            this.PbSecondImage.TabStop = false;
            // 
            // GbFirstImage
            // 
            this.GbFirstImage.Controls.Add(this.PbFirstImage);
            this.GbFirstImage.Location = new System.Drawing.Point(15, 20);
            this.GbFirstImage.Name = "GbFirstImage";
            this.GbFirstImage.Size = new System.Drawing.Size(87, 100);
            this.GbFirstImage.TabIndex = 3;
            this.GbFirstImage.TabStop = false;
            this.GbFirstImage.Text = "1. Görüntü";
            // 
            // LblInfo
            // 
            this.LblInfo.Location = new System.Drawing.Point(12, 24);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(319, 23);
            this.LblInfo.TabIndex = 9;
            this.LblInfo.Text = "Canlı görüntü işlemek için hotkey tuşuna basılı tutun.";
            this.LblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbSettings
            // 
            this.GbSettings.Controls.Add(this.GbOtherSettings);
            this.GbSettings.Controls.Add(this.GbResolutionSettings);
            this.GbSettings.Controls.Add(this.GbFocusArea);
            this.GbSettings.Controls.Add(this.BtnConfigure);
            this.GbSettings.Location = new System.Drawing.Point(12, 50);
            this.GbSettings.Name = "GbSettings";
            this.GbSettings.Size = new System.Drawing.Size(319, 180);
            this.GbSettings.TabIndex = 10;
            this.GbSettings.TabStop = false;
            this.GbSettings.Text = "Ayarlar";
            // 
            // GbOtherSettings
            // 
            this.GbOtherSettings.Controls.Add(this.CbShowDetail);
            this.GbOtherSettings.Controls.Add(this.TxtHotkey);
            this.GbOtherSettings.Controls.Add(this.TxtMinimumDifferencePercentage);
            this.GbOtherSettings.Controls.Add(this.TxtTimerInterval);
            this.GbOtherSettings.Controls.Add(this.LblHotkey);
            this.GbOtherSettings.Controls.Add(this.LblMinimumDifferencePercentage);
            this.GbOtherSettings.Controls.Add(this.LblTimerInterval);
            this.GbOtherSettings.Location = new System.Drawing.Point(168, 21);
            this.GbOtherSettings.Name = "GbOtherSettings";
            this.GbOtherSettings.Size = new System.Drawing.Size(145, 121);
            this.GbOtherSettings.TabIndex = 8;
            this.GbOtherSettings.TabStop = false;
            this.GbOtherSettings.Text = "Diğer Ayarlar";
            // 
            // CbShowDetail
            // 
            this.CbShowDetail.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CbShowDetail.Checked = true;
            this.CbShowDetail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbShowDetail.Location = new System.Drawing.Point(5, 98);
            this.CbShowDetail.Name = "CbShowDetail";
            this.CbShowDetail.Size = new System.Drawing.Size(135, 19);
            this.CbShowDetail.TabIndex = 18;
            this.CbShowDetail.Text = "Ayrıntı Göster:";
            this.TtMain.SetToolTip(this.CbShowDetail, "İşlem ayrıntılarını görsel ve metin olarak sunar.\r\nDevre dışı bırakıldığında perf" +
        "ormans artışı sağlanır.");
            this.CbShowDetail.UseVisualStyleBackColor = true;
            // 
            // TxtHotkey
            // 
            this.TxtHotkey.Location = new System.Drawing.Point(99, 70);
            this.TxtHotkey.Name = "TxtHotkey";
            this.TxtHotkey.ReadOnly = true;
            this.TxtHotkey.Size = new System.Drawing.Size(40, 22);
            this.TxtHotkey.TabIndex = 15;
            this.TxtHotkey.TabStop = false;
            this.TtMain.SetToolTip(this.TxtHotkey, "Hotkey tanımlamak için çift tıklatın.");
            this.TxtHotkey.DoubleClick += new System.EventHandler(this.TxtHotkey_DoubleClick);
            // 
            // TxtMinimumDifferencePercentage
            // 
            this.TxtMinimumDifferencePercentage.Location = new System.Drawing.Point(99, 45);
            this.TxtMinimumDifferencePercentage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMinimumDifferencePercentage.Name = "TxtMinimumDifferencePercentage";
            this.TxtMinimumDifferencePercentage.Size = new System.Drawing.Size(40, 22);
            this.TxtMinimumDifferencePercentage.TabIndex = 13;
            this.TxtMinimumDifferencePercentage.Text = "50";
            // 
            // TxtTimerInterval
            // 
            this.TxtTimerInterval.Location = new System.Drawing.Point(99, 20);
            this.TxtTimerInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTimerInterval.Name = "TxtTimerInterval";
            this.TxtTimerInterval.Size = new System.Drawing.Size(40, 22);
            this.TxtTimerInterval.TabIndex = 11;
            this.TxtTimerInterval.Text = "1";
            // 
            // LblHotkey
            // 
            this.LblHotkey.AutoSize = true;
            this.LblHotkey.Location = new System.Drawing.Point(6, 73);
            this.LblHotkey.Name = "LblHotkey";
            this.LblHotkey.Size = new System.Drawing.Size(90, 13);
            this.LblHotkey.TabIndex = 16;
            this.LblHotkey.Text = "Hotkey (tek tuş):";
            // 
            // LblMinimumDifferencePercentage
            // 
            this.LblMinimumDifferencePercentage.AutoSize = true;
            this.LblMinimumDifferencePercentage.Location = new System.Drawing.Point(6, 48);
            this.LblMinimumDifferencePercentage.Name = "LblMinimumDifferencePercentage";
            this.LblMinimumDifferencePercentage.Size = new System.Drawing.Size(95, 13);
            this.LblMinimumDifferencePercentage.TabIndex = 14;
            this.LblMinimumDifferencePercentage.Text = "Min. Değişim (%):";
            // 
            // LblTimerInterval
            // 
            this.LblTimerInterval.AutoSize = true;
            this.LblTimerInterval.Location = new System.Drawing.Point(6, 22);
            this.LblTimerInterval.Name = "LblTimerInterval";
            this.LblTimerInterval.Size = new System.Drawing.Size(77, 13);
            this.LblTimerInterval.TabIndex = 12;
            this.LblTimerInterval.Text = "Yenileme (ms):";
            // 
            // MsMain
            // 
            this.MsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsAbout});
            this.MsMain.Location = new System.Drawing.Point(0, 0);
            this.MsMain.Name = "MsMain";
            this.MsMain.Size = new System.Drawing.Size(343, 24);
            this.MsMain.TabIndex = 11;
            // 
            // TsAbout
            // 
            this.TsAbout.Name = "TsAbout";
            this.TsAbout.Size = new System.Drawing.Size(69, 20);
            this.TsAbout.Text = "Hakkında";
            this.TsAbout.Click += new System.EventHandler(this.TsAbout_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 396);
            this.Controls.Add(this.GbSettings);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.GbResults);
            this.Controls.Add(this.MsMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.MsMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Editor";
            ((System.ComponentModel.ISupportInitialize)(this.PbFirstImage)).EndInit();
            this.GbResolutionSettings.ResumeLayout(false);
            this.GbResolutionSettings.PerformLayout();
            this.GbFocusArea.ResumeLayout(false);
            this.GbFocusArea.PerformLayout();
            this.GbResults.ResumeLayout(false);
            this.GbResultImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbResultImage)).EndInit();
            this.GbSecondImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbSecondImage)).EndInit();
            this.GbFirstImage.ResumeLayout(false);
            this.GbSettings.ResumeLayout(false);
            this.GbOtherSettings.ResumeLayout(false);
            this.GbOtherSettings.PerformLayout();
            this.MsMain.ResumeLayout(false);
            this.MsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConfigure;
        private System.Windows.Forms.PictureBox PbFirstImage;
        private System.Windows.Forms.TextBox TxtResolutionWidth;
        private System.Windows.Forms.TextBox TxtResolutionHeight;
        private System.Windows.Forms.Label LblResolutionWidth;
        private System.Windows.Forms.Label LblResolutionHeight;
        private System.Windows.Forms.GroupBox GbResolutionSettings;
        private System.Windows.Forms.GroupBox GbFocusArea;
        private System.Windows.Forms.TextBox TxtFocusAreaWidth;
        private System.Windows.Forms.Label LblFocusAreaHeight;
        private System.Windows.Forms.TextBox TxtFocusAreaHeight;
        private System.Windows.Forms.Label LblFocusAreaWidth;
        private System.Windows.Forms.GroupBox GbResults;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.GroupBox GbSettings;
        private System.Windows.Forms.GroupBox GbOtherSettings;
        private System.Windows.Forms.TextBox TxtTimerInterval;
        private System.Windows.Forms.Label LblTimerInterval;
        private System.Windows.Forms.PictureBox PbSecondImage;
        private System.Windows.Forms.GroupBox GbResultImage;
        private System.Windows.Forms.GroupBox GbSecondImage;
        private System.Windows.Forms.GroupBox GbFirstImage;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.PictureBox PbResultImage;
        private System.Windows.Forms.Label LblMinimumDifferencePercentage;
        private System.Windows.Forms.TextBox TxtMinimumDifferencePercentage;
        private System.Windows.Forms.MenuStrip MsMain;
        private System.Windows.Forms.ToolStripMenuItem TsAbout;
        private System.Windows.Forms.TextBox TxtHotkey;
        private System.Windows.Forms.Label LblHotkey;
        private System.Windows.Forms.ToolTip TtMain;
        private System.Windows.Forms.CheckBox CbShowDetail;
    }
}

