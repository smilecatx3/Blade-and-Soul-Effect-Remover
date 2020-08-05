using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GitHub.Smilecatx3.BladeAndSoul.EffectRemover {
    public partial class MainForm : Form {
        private static readonly ILog Log = LogManager.GetLogger(typeof(MainForm));
        private GamePath gamePath = new GamePath(Settings.Load(Settings.GamePath));

        public MainForm() {
            InitializeComponent();
            Initialize();
        }

        private void Initialize() {
            ActiveControl = Label_GameDirectory;

            var saveSettings = !Settings.Load(Settings.SaveSettings).Equals("0");
            ToolStripMenuItem_SaveSettings.Checked = saveSettings;

            if (gamePath.IsValid) {
                TextBox_GamePath.Text = gamePath.RootDir;
            } else if (!String.IsNullOrEmpty(gamePath.RootDir)) {
                Log.Warn("Invalid game path loaded from registry.");
                Settings.Delete(Settings.GamePath);
            }

            foreach (var classInfo in ClassList.Get()) {
                ComboBox_ExcludedClass.Items.Add(classInfo.Text);
            }
            var excludedClass = Settings.Load(Settings.ExcludedClass);
            if (ComboBox_ExcludedClass.Items.Contains(excludedClass)) {
                ComboBox_ExcludedClass.Text = excludedClass;
            } else {
                ComboBox_ExcludedClass.SelectedIndex = 0;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs args) {
            if (ToolStripMenuItem_SaveSettings.Checked) {
                Settings.Save(Settings.SaveSettings, "1");
                Settings.Save(Settings.GamePath, TextBox_GamePath.Text);
                Settings.Save(Settings.ExcludedClass, ComboBox_ExcludedClass.Text);
            } else {
                Settings.Save(Settings.SaveSettings, "0");
                Settings.Delete(Settings.GamePath);
                Settings.Delete(Settings.ExcludedClass);
            }
        }

        private void Button_SelectGamePath_Click(object sender, EventArgs args) {
            if (SelectGamePathDialog.ShowDialog() != DialogResult.OK) {
                return;
            }
            var gamePath = new GamePath(SelectGamePathDialog.SelectedPath);
            if (gamePath.IsValid) {
                this.gamePath = gamePath;
                TextBox_GamePath.Text = gamePath.RootDir;
                return;
            }
            var text = "資料夾路徑不存在: " + gamePath.UpkDir;
            var caption = "遊戲路徑不正確";
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Button_Remove_Click(object sender, EventArgs args) {
            if (!IsButtonClickable()) {
                return;
            }
            Directory.CreateDirectory(gamePath.BackupDir);
            var failures = new HashSet<string>();
            foreach (var classInfo in ClassList.Get()) {
                if (classInfo.Text.Equals(ComboBox_ExcludedClass.Text)) {
                    continue;
                }
                foreach (var upkName in classInfo.UpkSet) {
                    var fileName = upkName + ".upk";
                    var src = Path.Combine(gamePath.UpkDir, fileName);
                    var dst = Path.Combine(gamePath.BackupDir, fileName);
                    try {
                        if (File.Exists(src)) {
                            if (File.Exists(dst)) {
                                File.Delete(dst);
                            }
                            File.Move(src, dst);
                        }
                    } catch (Exception e) {
                        Log.Error(e);
                        failures.Add(fileName);
                    }
                }
            }
            var caption = Button_Remove.Text;
            ShowFailures(failures, caption);
            MessageBox.Show("操作已完成", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_Restore_Click(object sender, EventArgs args) {
            if (!IsButtonClickable()) {
                return;
            }
            var failures = new HashSet<string>();
            foreach (var src in Directory.GetFiles(gamePath.BackupDir)) {
                var fileName = new FileInfo(src).Name;
                var dst = Path.Combine(gamePath.UpkDir, fileName);
                try {
                    if (!File.Exists(dst)) {
                        File.Move(src, dst);
                    }
                } catch (Exception e) {
                    Log.Error(e);
                    failures.Add(fileName);
                }
            }
            var caption = Button_Restore.Text;
            ShowFailures(failures, caption);
            MessageBox.Show("操作已完成", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsButtonClickable() {
            if (gamePath.IsValid) {
                return true;
            }
            var text = "請先選擇遊戲資料夾";
            var caption = "遊戲路徑未設定";
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private void ShowFailures(ISet<string> failures, string caption) {
            if (failures.Count != 0) {
                var text = new StringBuilder("無法移動以下檔案: \n");
                foreach (var fileName in failures) {
                    text.AppendLine(fileName);
                }
                MessageBox.Show(text.ToString().Trim(), caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
