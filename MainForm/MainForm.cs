using log4net;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GitHub.Smilecatx3.BladeAndSoul.EffectRemover {
    public partial class MainForm : Form {
        private static readonly ILog Log = LogManager.GetLogger(typeof(MainForm));
        private GamePath gamePath;
        private List<PictureBox> classIcons = new List<PictureBox>();
        private HashSet<string> keptClassTexts = new HashSet<string>();
        private HashSet<string> removedClassTexts = new HashSet<string>();

        public MainForm() {
            Initialize();
        }

        private void DrawClassIcon(PictureBox classIcon, bool kept) {
            if (classIcon.BackgroundImage != null) {
                classIcon.BackgroundImage.Dispose();
            }

            var image = new Bitmap((classIcon.Tag as ClassInfo).Icon);
            classIcon.BackgroundImage = image;
            if (!kept) {
                var graphics = Graphics.FromImage(image);
                ControlPaint.DrawImageDisabled(graphics, image, 0, 0, classIcon.BackColor);
            }
        }
    }
}
