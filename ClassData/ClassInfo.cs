using System.Collections.Generic;
using System.Drawing;

namespace GitHub.Smilecatx3.BladeAndSoul.EffectRemover {
    public class ClassInfo {
        public string Name { get; internal set; }
        public string Text { get; internal set; }
        public ISet<string> UpkSet { get; internal set; }
        public Image Icon { get; internal set; }
    }
}
