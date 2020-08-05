using System.Collections.Generic;

namespace GitHub.Smilecatx3.BladeAndSoul.EffectRemover {
    public class ClassList {
        private static List<ClassInfo> data = new List<ClassInfo> {
            new ClassInfo {
                Text = "劍士",
                UpkSet = new HashSet<string> { "00007911", "00056567", "00056578", "00060548" }
            },
            new ClassInfo {
                Text = "拳士",
                UpkSet = new HashSet<string> { "00007912", "00010771", "00056568", "00056579", "00060549", "00064821" }
            },
            new ClassInfo {
                Text = "力士",
                UpkSet = new HashSet<string> { "00007914", "00008841", "00056570", "00056581", "00060551", "00067307" }
            },
            new ClassInfo {
                Text = "刺客",
                UpkSet = new HashSet<string> { "00007916", "00010504", "00056572", "00056583", "00060553", "00069254" }
            },
            new ClassInfo {
                Text = "氣功士",
                UpkSet = new HashSet<string> { "00007913", "00009801", "00056569", "00056580", "00060550", "00068626", "00072638" }
            },
            new ClassInfo {
                Text = "燐劍士",
                UpkSet = new HashSet<string> { "00018601", "00031769", "00056574", "00056585", "00060555" }
            },
            new ClassInfo {
                Text = "召喚師",
                UpkSet = new HashSet<string> { "00006660", "00007917", "00010869", "00056573", "00056584", "00060554" }
            },
            new ClassInfo {
                Text = "咒術師",
                UpkSet = new HashSet<string> { "00023411", "00023412", "00023439", "00056575", "00056586", "00060556" }
            },
            new ClassInfo {
                Text = "乾坤士",
                UpkSet = new HashSet<string> { "00034408", "00034433", "00056576", "00056587", "00060557" }
            },
            new ClassInfo {
                Text = "槍擊士",
                UpkSet = new HashSet<string> { "00007307", "00007915", "00056571", "00056582", "00060552" }
            },
            new ClassInfo {
                Text = "鬥士",
                UpkSet = new HashSet<string> { "00056126", "00056127", "00056566", "00056577", "00056588", "00060558" }
            },
            new ClassInfo {
                Text = "弓箭手",
                UpkSet = new HashSet<string> { "00064738" }
            }
        };

        public static IList<ClassInfo> Get() {
            return data;
        }
    }
}
