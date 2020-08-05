using Microsoft.Win32;

namespace GitHub.Smilecatx3.BladeAndSoul.EffectRemover {
    internal class Settings {
        public const string SaveSettings = "SaveSettings";
        public const string GamePath = "GamePath";
        public const string ExcludedClass = "ExcludedClass";
        private const string SubKey = @"SOFTWARE\GitHub\smilecatx3\BladeAndSoul\EffectRemover";

        static Settings() {
            Registry.CurrentUser.CreateSubKey(SubKey);
        }

        public static string Load(string name) {
            using (var key = Registry.CurrentUser.OpenSubKey(SubKey)) {
                return (key != null) ? key.GetValue(name, "").ToString() : "";
            }
        }

        public static void Save(string name, string value) {
            using (var key = Registry.CurrentUser.OpenSubKey(SubKey, true)) {
                if (key != null) {
                    key.SetValue(name, value);
                }
            }
        }

        public static void Delete(string name) {
            using (var key = Registry.CurrentUser.OpenSubKey(SubKey, true)) {
                if (key != null) {
                    key.DeleteValue(name, false);
                }
            }
        }
    }
}
