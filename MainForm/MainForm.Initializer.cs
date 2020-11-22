using GitHub.Smilecatx3.BladeAndSoul.EffectRemover.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GitHub.Smilecatx3.BladeAndSoul.EffectRemover {
    public partial class MainForm {
        private HashSet<string> initKeptClassNames = new HashSet<string>(Settings.KeptClassNames.Load().Split(','));

        private void Initialize() {
            try {
                Log.Info("程式初始化中...");
                InitializeComponent();
                InitializeMenuItems();
                InitializeGamePath();
                InitializeClassIcons();
                Icon = Resources.icon;
                ActiveControl = LabelGameDirectory;
            } catch (Exception e) {
                Log.Error(e);
                MessageBox.Show(e.Message, "程式初始化失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
        }

        private void InitializeMenuItems() {
            var setting = Settings.SaveSettings.Load();
            ToolStripMenuItemSaveSettings.Checked = String.IsNullOrEmpty(setting) || setting.Equals("1");
        }

        private void InitializeGamePath() {
            gamePath = new GamePath(Settings.GamePath.Load());
            if (gamePath.IsValid) {
                TextBoxGamePath.Text = gamePath.RootDir;
                Log.Info("遊戲路徑: " + gamePath.RootDir);
            } else if (!String.IsNullOrEmpty(gamePath.RootDir)) {
                Log.Warn("Invalid game path loaded from registry.");
                Settings.GamePath.Delete();
            }
        }

        private void InitializeClassIcons() {
            InitializeClassIcon(PictureBoxBladeMaster, "BladeMaster");
            InitializeClassIcon(PictureBoxBladeDancer, "BladeDancer");
            InitializeClassIcon(PictureBoxSoulFighter, "SoulFighter");
            InitializeClassIcon(PictureBoxWarrior, "Warrior");
            InitializeClassIcon(PictureBoxKungFuFighter, "KungFuFighter");
            InitializeClassIcon(PictureBoxDestroyer, "Destroyer");
            InitializeClassIcon(PictureBoxAssassin, "Assassin");
            InitializeClassIcon(PictureBoxGunslinger, "Gunslinger");
            InitializeClassIcon(PictureBoxAstromancer, "Astromancer");
            InitializeClassIcon(PictureBoxForceMaster, "ForceMaster");
            InitializeClassIcon(PictureBoxSummoner, "Summoner");
            InitializeClassIcon(PictureBoxWarlock, "Warlock");
            InitializeClassIcon(PictureBoxArcher, "Archer");
        }

        private void InitializeClassIcon(PictureBox classIcon, string className) {
            var classInfo = ClassTable.Get()[className];
            classIcon.Tag = classInfo;
            if (initKeptClassNames.Contains(className)) {
                removedClassTexts.Add(classInfo.Text);
                DrawClassIcon(classIcon, true);
            } else {
                keptClassTexts.Add(classInfo.Text);
                DrawClassIcon(classIcon, false);
            }
            classIcons.Add(classIcon);
        }
    }
}
