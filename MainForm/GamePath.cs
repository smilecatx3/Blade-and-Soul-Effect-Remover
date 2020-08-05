using System.IO;

namespace GitHub.Smilecatx3.BladeAndSoul.EffectRemover {
    internal class GamePath {
        public string RootDir { get; }
        public string UpkDir { get; }
        public string BackupDir { get; }
        public bool IsValid { get; }

        public GamePath(string root) {
            RootDir = root;
            UpkDir = Path.Combine(root, "contents", "bns", "CookedPC");
            BackupDir = Path.Combine(root, "contents", "bns", "EffectRemoverBackup");
            IsValid = Directory.Exists(UpkDir);
        }
    }
}
