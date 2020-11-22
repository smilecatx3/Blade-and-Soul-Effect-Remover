using GitHub.Smilecatx3.BladeAndSoul.EffectRemover.Properties;
using System.Collections.Generic;

namespace GitHub.Smilecatx3.BladeAndSoul.EffectRemover {
    public static class ClassTable {
        private static readonly Dictionary<string, ClassInfo> Data = new Dictionary<string, ClassInfo>();

        static ClassTable() {
            Data["BladeMaster"] = new ClassInfo {
                Name = "BladeMaster",
                Text = "劍",
                UpkSet = new HashSet<string> { "00007911", "00056567", "00056578", "00060548" },
                Icon = Resources.BladeMaster
            };
            Data["BladeDancer"] = new ClassInfo {
                Name = "BladeDancer",
                Text = "燐劍",
                UpkSet = new HashSet<string> { "00018601", "00031769", "00056574", "00056585", "00060555" },
                Icon = Resources.BladeDancer
            };
            Data["SoulFighter"] = new ClassInfo {
                Name = "SoulFighter",
                Text = "乾坤",
                UpkSet = new HashSet<string> { "00034408", "00034433", "00056576", "00056587", "00060557" },
                Icon = Resources.SoulFighter
            };
            Data["Warrior"] = new ClassInfo {
                Name = "Warrior",
                Text = "鬥",
                UpkSet = new HashSet<string> { "00056126", "00056127", "00056566", "00056577", "00056588", "00060558" },
                Icon = Resources.Warrior
            };
            Data["KungFuFighter"] = new ClassInfo {
                Name = "KungFuFighter",
                Text = "拳",
                UpkSet = new HashSet<string> { "00007912", "00010771", "00056568", "00056579", "00060549", "00064821" },
                Icon = Resources.KungFuFighter
            };
            Data["Destroyer"] = new ClassInfo {
                Name = "Destroyer",
                Text = "力",
                UpkSet = new HashSet<string> { "00007914", "00008841", "00056570", "00056581", "00060551", "00067307" },
                Icon = Resources.Destroyer
            };
            Data["Assassin"] = new ClassInfo {
                Name = "Assassin",
                Text = "刺",
                UpkSet = new HashSet<string> { "00007916", "00010504", "00056572", "00056583", "00060553", "00069254" },
                Icon = Resources.Assassin
            };
            Data["Gunslinger"] = new ClassInfo {
                Name = "Gunslinger",
                Text = "槍",
                UpkSet = new HashSet<string> { "00007307", "00007915", "00056571", "00056582", "00060552" },
                Icon = Resources.Gunslinger
            };
            Data["Astromancer"] = new ClassInfo {
                Name = "Astromancer",
                Text = "天道",
                UpkSet = new HashSet<string> { "00072639", "00072642" },
                Icon = Resources.Astromancer
            };
            Data["ForceMaster"] = new ClassInfo {
                Name = "ForceMaster",
                Text = "氣",
                UpkSet = new HashSet<string> { "00007913", "00009801", "00056569", "00056580", "00060550", "00068626", "00072638" },
                Icon = Resources.ForceMaster
            };
            Data["Summoner"] = new ClassInfo {
                Name = "Summoner",
                Text = "召",
                UpkSet = new HashSet<string> { "00006660", "00007917", "00010869", "00056573", "00056584", "00060554" },
                Icon = Resources.Summoner
            };
            Data["Warlock"] = new ClassInfo {
                Name = "Warlock",
                Text = "咒",
                UpkSet = new HashSet<string> { "00023411", "00023439", "00056575", "00056586", "00060556" },
                Icon = Resources.Warlock
            };
            Data["Archer"] = new ClassInfo {
                Name = "Archer",
                Text = "弓",
                UpkSet = new HashSet<string> { "00064738" },
                Icon = Resources.Archer
            };
        }

        public static IDictionary<string, ClassInfo> Get() {
            return Data;
        }
    }
}
