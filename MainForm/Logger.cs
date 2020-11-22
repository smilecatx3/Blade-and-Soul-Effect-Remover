using log4net;
using log4net.Config;
using log4net.Core;
using log4net.Repository.Hierarchy;
using Microsoft.Win32;
using System;
using System.Reflection;

namespace GitHub.Smilecatx3.BladeAndSoul.EffectRemover {
    static class Logger {
        private const string ConfigName = "GitHub.Smilecatx3.BladeAndSoul.EffectRemover.Resources.log4net.xml";

        public static void Initialize() {
            try {
                var assembly = Assembly.GetCallingAssembly();
                var repository = LogManager.GetRepository(assembly);
                using (var stream = assembly.GetManifestResourceStream(ConfigName)) {
                    XmlConfigurator.Configure(repository, stream);
                }
                (repository as Hierarchy).Root.Level = GetLevel();
            } catch (Exception e) {
                Console.Error.WriteLine(e);
            }
        }

        private static Level GetLevel() {
            using (var key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
            using (var subkey = key.OpenSubKey(@"SOFTWARE\GitHub\smilecatx3\BladeAndSoul\EffectRemover")) {
                if (subkey != null && subkey.GetValue("Debug", "0").Equals("1")) {
                    return Level.Debug;
                }
            }
            return Level.Info;
        }
    }
}
