using Microsoft.Win32;

namespace GitHub.Smilecatx3.BladeAndSoul.EffectRemover {
    internal class Settings {
        public static readonly Setting SaveSettings = new Setting("SaveSettings");
        public static readonly Setting GamePath = new Setting("GamePath");
        public static readonly Setting KeptClassNames = new Setting("KeptClassNames");
    }

    internal class Setting {
        private const string SubKey = @"SOFTWARE\GitHub\smilecatx3\BladeAndSoul\EffectRemover";
        private string name;

        static Setting() {
            Registry.CurrentUser.CreateSubKey(SubKey);
        }

        public Setting(string name) {
            this.name = name;
        }

        public string Load() {
            using (var key = Registry.CurrentUser.OpenSubKey(SubKey)) {
                return (key != null) ? key.GetValue(name, "").ToString() : "";
            }
        }

        public void Save(string value) {
            using (var key = Registry.CurrentUser.OpenSubKey(SubKey, true)) {
                if (key != null) {
                    key.SetValue(name, value);
                }
            }
        }

        public void Delete() {
            using (var key = Registry.CurrentUser.OpenSubKey(SubKey, true)) {
                if (key != null) {
                    key.DeleteValue(name, false);
                }
            }
        }
    }
}
