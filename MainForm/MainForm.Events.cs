using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GitHub.Smilecatx3.BladeAndSoul.EffectRemover {
    public partial class MainForm {
        private void OnFormClosing(object sender, FormClosingEventArgs args) {
            Log.Info("程式關閉中...");
            if (ToolStripMenuItemSaveSettings.Checked) {
                Log.Debug("儲存所有設定...");
                Settings.SaveSettings.Save("1");
                Settings.GamePath.Save(TextBoxGamePath.Text);
                Settings.KeptClassNames.Save(GetKeptClassNames());
            } else {
                Log.Debug("刪除所有設定...");
                Settings.SaveSettings.Save("0");
                Settings.GamePath.Delete();
                Settings.KeptClassNames.Delete();
            }
        }

        private string GetKeptClassNames() {
            var keptClassNames = new HashSet<string>();
            foreach (var classInfo in ClassTable.Get().Values) {
                if (keptClassTexts.Contains(classInfo.Text)) {
                    keptClassNames.Add(classInfo.Name);
                }
            }
            return String.Join(",", keptClassNames);
        }

        private void OnButtonSelectGamePathClicked(object sender, EventArgs args) {
            if (SelectGamePathDialog.ShowDialog() != DialogResult.OK) {
                return;
            }
            var gamePath = new GamePath(SelectGamePathDialog.SelectedPath);
            if (gamePath.IsValid) {
                this.gamePath = gamePath;
                TextBoxGamePath.Text = gamePath.RootDir;
                Log.Info("遊戲路徑設定為: " + gamePath.RootDir);
            } else {
                var text = "此資料夾不存在: " + gamePath.UpkDir;
                var caption = "遊戲路徑不正確";
                MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnClassIconClicked(object sender, EventArgs args) {
            var classIcon = sender as PictureBox;
            var classText = (classIcon.Tag as ClassInfo).Text;
            var state = keptClassTexts.Contains(classText);
            DrawClassIcon(classIcon, !state); // toggle the state
        }

        private void OnClassIconChanged(object sender, EventArgs args) {
            var classIcon = sender as PictureBox;
            var classText = (classIcon.Tag as ClassInfo).Text;
            if (keptClassTexts.Contains(classText)) {
                keptClassTexts.Remove(classText);
                removedClassTexts.Add(classText);
            } else {
                keptClassTexts.Add(classText);
                removedClassTexts.Remove(classText);
            }
            TextBoxKeptClasses.Text = String.Join(", ", keptClassTexts);
            TextBoxRemovedClasses.Text = String.Join(", ", removedClassTexts);
        }

        private void OnButtonRemoveAllClicked(object sender, EventArgs args) {
            foreach (var classIcon in classIcons) {
                var classText = (classIcon.Tag as ClassInfo).Text;
                if (keptClassTexts.Contains(classText)) {
                    OnClassIconClicked(classIcon, args);
                }
            }
        }

        private void OnButtonKeepAllClicked(object sender, EventArgs args) {
            foreach (var classIcon in classIcons) {
                var classText = (classIcon.Tag as ClassInfo).Text;
                if (removedClassTexts.Contains(classText)) {
                    OnClassIconClicked(classIcon, args);
                }
            }
        }

        private void OnButtonDoActionClicked(object sender, EventArgs args) {
            if (!gamePath.IsValid) {
                var text = "請先選擇遊戲資料夾";
                var caption = "遊戲路徑未設定";
                MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!CreateBackupDirectory() || !RestoreAllEffects()) {
                return;
            }
            // TODO
            Log.Info("保留職業: " + String.Join(",", keptClassTexts));
            Log.Info("移除職業: " + String.Join(",", removedClassTexts));
            foreach (var classInfo in ClassTable.Get().Values) {
                if (keptClassTexts.Contains(classInfo.Text)) {
                    continue;
                }
                if (!RemoveEffect(classInfo)) {
                    MessageBox.Show("無法移動遊戲資料夾內的檔案。請確認遊戲是否已完全關閉。", "刪除特效失敗",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (RestoreAllEffects()) {
                        MessageBox.Show("已成功還原所有職業特效。", "還原特效成功",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }
            }
            MessageBox.Show("操作已完成", "執行成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CreateBackupDirectory() {
            var dir = gamePath.BackupDir;
            if (!Directory.Exists(dir)) {
                try {
                    Directory.CreateDirectory(dir);
                } catch (Exception e) {
                    Log.Error(e.Message);
                    MessageBox.Show(e.Message, "建立備份目錄失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            Log.Info("建立備份目錄於: " + dir);
            return true;
        }

        private bool RestoreAllEffects() {
            Log.Info("還原所有特效...");
            foreach (var src in Directory.GetFiles(gamePath.BackupDir)) {
                var fileName = new FileInfo(src).Name;
                var dst = Path.Combine(gamePath.UpkDir, fileName);
                try {
                    if (!File.Exists(dst)) {
                        File.Move(src, dst);
                    } else {
                        Log.Warn("遊戲資料夾內已存在此檔案: " + fileName);
                    }
                } catch (Exception e) {
                    var message = String.Format("無法還原檔案: '{0}'。原因: {1}", fileName, e.Message);
                    Log.Error(message);
                    MessageBox.Show(message, "還原失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool RemoveEffect(ClassInfo classInfo) {
            foreach (var upkName in classInfo.UpkSet) {
                var fileName = upkName + ".upk";
                var src = Path.Combine(gamePath.UpkDir, fileName);
                var dst = Path.Combine(gamePath.BackupDir, fileName);
                try {
                    if (File.Exists(src)) {
                        if (File.Exists(dst)) {
                            Log.Warn("刪除已位於備份資料夾裡的檔案: " + dst);
                            File.Delete(dst);
                        }
                        File.Move(src, dst);
                    } else {
                        Log.Warn("原始檔案不存在: " + src);
                    }
                } catch (Exception e) {
                    Log.Error(String.Format("無法移動檔案: '{0}'。原因: {1}", fileName, e.Message));
                    return false;
                }
            }
            return true;
        }
    }
}
