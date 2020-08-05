using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace GitHub.Smilecatx3.BladeAndSoul.EffectRemover {
    static class Program {
        [STAThread]
        static void Main() {
            var repository = LogManager.GetRepository(Assembly.GetCallingAssembly());
            XmlConfigurator.Configure(repository, new FileInfo("log4net.config"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
