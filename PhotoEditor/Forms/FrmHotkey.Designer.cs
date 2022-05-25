
namespace PhotoEditor.Forms {
    partial class FrmHotkey {
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
            this.LblHotkeyInfo = new System.Windows.Forms.Label();
            this.TxtHotkeyPreview = new System.Windows.Forms.TextBox();
            this.BtnSaveHotkey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHotkeyInfo
            // 
            this.LblHotkeyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHotkeyInfo.Location = new System.Drawing.Point(12, 9);
            this.LblHotkeyInfo.Name = "LblHotkeyInfo";
            this.LblHotkeyInfo.Size = new System.Drawing.Size(208, 56);
            this.LblHotkeyInfo.TabIndex = 0;
            this.LblHotkeyInfo.Text = "Tetikleme için bir hotkey tanımlayın. Tuş kombinasyonlarına (Ctrl+C gibi) izin ve" +
    "rilmez.";
            // 
            // TxtHotkeyPreview
            // 
            this.TxtHotkeyPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtHotkeyPreview.Location = new System.Drawing.Point(12, 68);
            this.TxtHotkeyPreview.Name = "TxtHotkeyPreview";
            this.TxtHotkeyPreview.ReadOnly = true;
            this.TxtHotkeyPreview.Size = new System.Drawing.Size(208, 22);
            this.TxtHotkeyPreview.TabIndex = 1;
            // 
            // BtnSaveHotkey
            // 
            this.BtnSaveHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaveHotkey.Location = new System.Drawing.Point(11, 96);
            this.BtnSaveHotkey.Name = "BtnSaveHotkey";
            this.BtnSaveHotkey.Size = new System.Drawing.Size(210, 30);
            this.BtnSaveHotkey.TabIndex = 2;
            this.BtnSaveHotkey.Text = "Onayla";
            this.BtnSaveHotkey.UseVisualStyleBackColor = true;
            this.BtnSaveHotkey.Click += new System.EventHandler(this.BtnSaveHotkey_Click);
            // 
            // FrmHotkey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 138);
            this.Controls.Add(this.BtnSaveHotkey);
            this.Controls.Add(this.TxtHotkeyPreview);
            this.Controls.Add(this.LblHotkeyInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHotkey";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotkey Tanımla";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHotkey_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHotkeyInfo;
        private System.Windows.Forms.TextBox TxtHotkeyPreview;
        private System.Windows.Forms.Button BtnSaveHotkey;
    }
}