using System;
using System.Windows.Forms;

using PhotoEditor.Classes;

namespace PhotoEditor.Forms {
    public partial class FrmHotkey : Form {

        public Keys Hotkey { get; set; }
        private GlobalKeyboardHook _globalKeyboardHook;

        public FrmHotkey() {
            InitializeComponent();
            InstallKeyboardHook();
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
        }

        private void InstallKeyboardHook() {

            UninstallKeyboardHook();

            _globalKeyboardHook = new GlobalKeyboardHook();
            _globalKeyboardHook.KeyDown += new KeyEventHandler(GlobalKeyboardHook_KeyDown);

            foreach (Keys key in Enum.GetValues(typeof(Keys))) {
                _globalKeyboardHook.HookedKeys.Add(key);
            }

            _globalKeyboardHook.Install();
        }

        private void UninstallKeyboardHook() {
            if (_globalKeyboardHook != null) {
                _globalKeyboardHook.KeyDown -= new KeyEventHandler(GlobalKeyboardHook_KeyDown);
                _globalKeyboardHook.Uninstall();
            }
        }

        private void GlobalKeyboardHook_KeyDown(object sender, KeyEventArgs e) {
            Hotkey = e.KeyData;
            TxtHotkeyPreview.Text = Hotkey.ToString();
        }

        private void BtnSaveHotkey_Click(object sender, EventArgs e) {
            if (Hotkey != Keys.None) {
                DialogResult = DialogResult.OK;
            } else {
                MessageBox.Show("Hotkey tanımlaması yapmadınız! Lütfen önce bir hotkey tanımlayın. İşlemden vazgeçmek için ekranı kapatın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmHotkey_FormClosing(object sender, FormClosingEventArgs e) {
            UninstallKeyboardHook();
        }

        private void OnApplicationExit(object sender, EventArgs e) {
            UninstallKeyboardHook();
        }

    }
}