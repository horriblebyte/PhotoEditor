using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Emgu.CV;
using Emgu.CV.Structure;

using PhotoEditor.Classes;

namespace PhotoEditor.Forms {

    public partial class FrmMain : Form {

        #region Variables

        #region WinAPI Mouse Actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        #endregion

        #region Session Settings
        private ushort _resolutionWidth = 0;
        private ushort _resolutionHeight = 0;

        private ushort _focusAreaWidth = 0;
        private ushort _focusAreaHeight = 0;

        private ushort _timerInterval = 1;
        private ushort _minimumDifferencePercentage = 0;
        #endregion

        private bool _showDetail = false;
        private bool _isHotkeyPressed = false;

        private Keys _triggerHotkey = Keys.F;

        private Point _focusArea;
        private Timer _triggerTimer;
        private GlobalKeyboardHook _globalKeyboardHook;

        private Bitmap _screenBitmap = null;
        private Graphics _screenGraphics = null;

        private Bitmap _firstImage = null;
        private Bitmap _secondImage = null;
        private Bitmap _resultImage = null;

        private double _differencePercentage = 0;

        private int _tickCount = 0;
        #endregion

        #region WinAPI Methods
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        #endregion

        public FrmMain() {
            InitializeComponent();
            PrepareSettings();
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
        }

        private bool PrepareSettings() {
            try {

                if (_triggerTimer != null) {
                    _triggerTimer.Stop();
                    _triggerTimer = null;
                }

                InstallKeyboardHook();

                if (!ushort.TryParse(TxtResolutionWidth.Text, out _resolutionWidth)) {
                    TxtResolutionWidth.Focus();
                    throw new Exception("\"Çözünürlük Genişliği\" değerini kontrol edip tekrar deneyiniz.");
                }

                if (!ushort.TryParse(TxtResolutionHeight.Text, out _resolutionHeight)) {
                    TxtResolutionHeight.Focus();
                    throw new Exception("\"Çözünürlük Yüksekliği\" değerini kontrol edip tekrar deneyiniz.");
                }

                if (!ushort.TryParse(TxtFocusAreaWidth.Text, out _focusAreaWidth)) {
                    TxtFocusAreaWidth.Focus();
                    throw new Exception("\"Odak Alanı Genişliği\" değerini kontrol edip tekrar deneyiniz.");
                }

                if (!ushort.TryParse(TxtFocusAreaHeight.Text, out _focusAreaHeight)) {
                    TxtFocusAreaHeight.Focus();
                    throw new Exception("\"Odak Alanı Yüksekliği\" değerini kontrol edip tekrar deneyiniz.");
                }

                if (!ushort.TryParse(TxtTimerInterval.Text, out _timerInterval) || _timerInterval <= 0) {
                    TxtTimerInterval.Focus();
                    throw new Exception("\"Yenileme\" değerini kontrol edip tekrar deneyiniz.");
                }

                if (!ushort.TryParse(TxtMinimumDifferencePercentage.Text, out _minimumDifferencePercentage) || _minimumDifferencePercentage > 100 || _minimumDifferencePercentage < 0) {
                    TxtMinimumDifferencePercentage.Focus();
                    throw new Exception("\"Minimum Değişim (%)\" değerini kontrol edip tekrar deneyiniz.");
                }

                ResetVariables();

                TxtHotkey.Text = _triggerHotkey.ToString();

                _showDetail = CbShowDetail.Checked;

                _focusArea = CalculateCenterPoint(new Size(_resolutionWidth, _resolutionHeight), new Size(_focusAreaWidth, _focusAreaHeight));

                _triggerTimer = new Timer {
                    Interval = _timerInterval
                };

                _triggerTimer.Tick += new EventHandler(triggerTimer_Tick);

                return true;

            } catch (Exception ex) {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void InstallKeyboardHook() {

            UninstallKeyboardHook();

            _globalKeyboardHook = new GlobalKeyboardHook();

            _globalKeyboardHook.KeyDown += new KeyEventHandler(GlobalKeyboardHook_KeyDown);
            _globalKeyboardHook.KeyUp += new KeyEventHandler(GlobalKeyboardHook_KeyUp);

            _globalKeyboardHook.HookedKeys.Add(_triggerHotkey);

            _globalKeyboardHook.Install();
        }

        private void UninstallKeyboardHook() {
            if (_globalKeyboardHook != null) {
                _globalKeyboardHook.KeyDown -= new KeyEventHandler(GlobalKeyboardHook_KeyDown);
                _globalKeyboardHook.KeyUp -= new KeyEventHandler(GlobalKeyboardHook_KeyUp);
                _globalKeyboardHook.Uninstall();
            }
        }

        private Bitmap CopyScreen() {
            _screenBitmap = new Bitmap(_focusAreaWidth, _focusAreaHeight);
            _screenGraphics = Graphics.FromImage(_screenBitmap);
            _screenGraphics.CopyFromScreen(_focusArea.X, _focusArea.Y, 0, 0, _screenBitmap.Size);
            return _screenBitmap;
        }

        private double DetectDifference(Bitmap firstImage, Bitmap secondImage) {
            using (Image<Gray, byte> sourceImage = new Image<Gray, byte>(firstImage)) {
                using (Image<Gray, byte> templateImage = new Image<Gray, byte>(secondImage)) {
                    using (Image<Gray, byte> resultImage = new Image<Gray, byte>(templateImage.Width, templateImage.Height)) {
                        CvInvoke.AbsDiff(sourceImage, templateImage, resultImage);
                        if (_showDetail) {
                            _resultImage = resultImage.ToBitmap();
                        }
                        _differencePercentage = CvInvoke.CountNonZero(resultImage);
                        _differencePercentage = _differencePercentage / (templateImage.Width * templateImage.Height) * 100;
                        return _differencePercentage;
                    }
                }
            }
        }

        private void ResetVariables() {

            _firstImage = null;
            _secondImage = null;

            _differencePercentage = 0;

            _screenBitmap = null;
            _screenGraphics = null;

            _tickCount = 0;

            if (_showDetail) {
                _resultImage = null;
                PbFirstImage.Image = null;
                PbSecondImage.Image = null;
                PbResultImage.Image = null;
                SetResultText("Komut bekleniyor...", SystemColors.ControlText);
            }

        }

        public static Point CalculateCenterPoint(Size screen, Size cropArea) {
            return new Point((screen.Width / 2) - (cropArea.Width / 2), (screen.Height / 2) - (cropArea.Height / 2));
        }

        private void SetResultText(string text, Color color) {
            LblResult.Text = text;
            LblResult.ForeColor = color;
        }

        private void BtnConfigure_Click(object sender, EventArgs e) {
            if (!PrepareSettings()) {
                SetResultText("Ayarlarınızda hata var! Kontrol edip tekrar deneyiniz.", Color.Red);
            } else {
                SetResultText("Ayarlarınız bu oturum için kaydedilmiştir.", Color.Green);
            }
        }

        private void triggerTimer_Tick(object sender, EventArgs e) {
            if (_isHotkeyPressed) {

                try {

                    _tickCount++;

                    if (_tickCount == 1) {
                        _firstImage = CopyScreen();
                        if (_showDetail) {
                            PbFirstImage.Image = _firstImage;
                            SetResultText("1. görsel alındı, 2. görsel bekleniyor...", SystemColors.ControlText);
                        }
                    }

                    if (_tickCount == 2) {
                        _secondImage = CopyScreen();
                        if (_showDetail) {
                            PbSecondImage.Image = _secondImage;
                            SetResultText("2. görsel alındı, fark hesaplaması yapılıyor...", SystemColors.ControlText);
                        }

                        double detectionPercentage = DetectDifference(_firstImage, _secondImage);

                        if (_showDetail) {
                            PbResultImage.Image = _resultImage;
                        }

                        if (detectionPercentage == 0) {
                            if (_showDetail) {
                                SetResultText("Görseller birebir aynıdır.", Color.Green);
                            }
                        } else {
                            if (detectionPercentage > _minimumDifferencePercentage) {
                                if (_showDetail) {
                                    SetResultText($"Görseller %{detectionPercentage} oranında farklıdır!", Color.Red);
                                }
                                mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                                mouse_event(MOUSEEVENTF_LEFTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                            } else {
                                if (_showDetail) {
                                    SetResultText($"Görseller %{detectionPercentage} oranında farklıdır.", SystemColors.ControlText);
                                }
                            }

                            if (!_showDetail) {
                                ResetVariables();
                            }

                        }

                    }

                    if (_showDetail) {
                        if (_tickCount == 3) {
                            ResetVariables();
                        }
                    }

                } catch (Exception ex) {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void GlobalKeyboardHook_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == _triggerHotkey) {
                if (!_isHotkeyPressed) {
                    ResetVariables();
                    _isHotkeyPressed = true;
                }

                if (_triggerTimer != null) {
                    _triggerTimer.Start();
                } else {
                    SetResultText("Ayarlarınızda hata var! Kontrol edip tekrar deneyiniz.", Color.Red);
                }
            }
        }

        private void GlobalKeyboardHook_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyData == _triggerHotkey) {
                if (_isHotkeyPressed) {
                    _isHotkeyPressed = false;
                }
                if (_triggerTimer != null) {
                    _triggerTimer.Stop();
                }
            }
        }

        private void TsAbout_Click(object sender, EventArgs e) {
            MessageBox.Show("Emgu CV teknolojisini kullanarak iki görüntü arasındaki farkı hesaplayabilen örnek bir uygulamadır.\n\nAyarlamalar sonrasında hotkey tuşuna basılı tutulduğu müddetçe belirlenen alandan iki görüntü alır ve karşılaştırır.\n\nAçık kaynak olarak sunulmuştur.", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtHotkey_DoubleClick(object sender, EventArgs e) {
            UninstallKeyboardHook();
            using (FrmHotkey frmHotkey = new FrmHotkey()) {
                if (frmHotkey.ShowDialog() == DialogResult.OK) {
                    _triggerHotkey = frmHotkey.Hotkey;
                    TxtHotkey.Text = _triggerHotkey.ToString();
                    SetResultText("Değişikliklerin etkili olabilmesi için ayarları kaydediniz.", Color.OrangeRed);
                } else {
                    InstallKeyboardHook();
                }
            }
        }

        private void OnApplicationExit(object sender, EventArgs e) {
            UninstallKeyboardHook();
        }

    }
}