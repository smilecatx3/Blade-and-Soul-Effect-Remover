using System;
using System.Windows.Forms;

namespace GitHub.Smilecatx3.BladeAndSoul.EffectRemover {
    static class Program {
        [STAThread]
        static void Main() {
            Logger.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
