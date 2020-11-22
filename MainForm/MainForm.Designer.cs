namespace GitHub.Smilecatx3.BladeAndSoul.EffectRemover {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelAction = new System.Windows.Forms.Panel();
            this.LabelRemovedClasses = new System.Windows.Forms.Label();
            this.TextBoxRemovedClasses = new System.Windows.Forms.TextBox();
            this.TextBoxKeptClasses = new System.Windows.Forms.TextBox();
            this.ButtonDoAction = new System.Windows.Forms.Button();
            this.LabelKeptClasses = new System.Windows.Forms.Label();
            this.PanelClassIcons = new System.Windows.Forms.Panel();
            this.ButtonKeepAll = new System.Windows.Forms.Button();
            this.ButtonRemoveAll = new System.Windows.Forms.Button();
            this.PictureBoxArcher = new System.Windows.Forms.PictureBox();
            this.PictureBoxBladeMaster = new System.Windows.Forms.PictureBox();
            this.PictureBoxAstromancer = new System.Windows.Forms.PictureBox();
            this.PictureBoxKungFuFighter = new System.Windows.Forms.PictureBox();
            this.PictureBoxWarrior = new System.Windows.Forms.PictureBox();
            this.PictureBoxWarlock = new System.Windows.Forms.PictureBox();
            this.PictureBoxForceMaster = new System.Windows.Forms.PictureBox();
            this.PictureBoxBladeDancer = new System.Windows.Forms.PictureBox();
            this.PictureBoxSummoner = new System.Windows.Forms.PictureBox();
            this.PictureBoxSoulFighter = new System.Windows.Forms.PictureBox();
            this.PictureBoxGunslinger = new System.Windows.Forms.PictureBox();
            this.PictureBoxDestroyer = new System.Windows.Forms.PictureBox();
            this.PictureBoxAssassin = new System.Windows.Forms.PictureBox();
            this.PanelGameDirectory = new System.Windows.Forms.Panel();
            this.LabelGameDirectory = new System.Windows.Forms.Label();
            this.ButtonSelectGamePath = new System.Windows.Forms.Button();
            this.TextBoxGamePath = new System.Windows.Forms.TextBox();
            this.SelectGamePathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemOption = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelMain.SuspendLayout();
            this.PanelAction.SuspendLayout();
            this.PanelClassIcons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBladeMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAstromancer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxKungFuFighter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWarrior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWarlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxForceMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBladeDancer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSummoner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSoulFighter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGunslinger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDestroyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAssassin)).BeginInit();
            this.PanelGameDirectory.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelMain.Controls.Add(this.PanelAction);
            this.PanelMain.Controls.Add(this.PanelClassIcons);
            this.PanelMain.Controls.Add(this.PanelGameDirectory);
            this.PanelMain.Location = new System.Drawing.Point(12, 27);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(424, 203);
            this.PanelMain.TabIndex = 0;
            // 
            // PanelAction
            // 
            this.PanelAction.Controls.Add(this.LabelRemovedClasses);
            this.PanelAction.Controls.Add(this.TextBoxRemovedClasses);
            this.PanelAction.Controls.Add(this.TextBoxKeptClasses);
            this.PanelAction.Controls.Add(this.ButtonDoAction);
            this.PanelAction.Controls.Add(this.LabelKeptClasses);
            this.PanelAction.Location = new System.Drawing.Point(3, 137);
            this.PanelAction.Name = "PanelAction";
            this.PanelAction.Size = new System.Drawing.Size(408, 57);
            this.PanelAction.TabIndex = 12;
            // 
            // LabelRemovedClasses
            // 
            this.LabelRemovedClasses.AutoSize = true;
            this.LabelRemovedClasses.Location = new System.Drawing.Point(3, 36);
            this.LabelRemovedClasses.Name = "LabelRemovedClasses";
            this.LabelRemovedClasses.Size = new System.Drawing.Size(41, 12);
            this.LabelRemovedClasses.TabIndex = 9;
            this.LabelRemovedClasses.Text = "移除：";
            // 
            // TextBoxRemovedClasses
            // 
            this.TextBoxRemovedClasses.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxRemovedClasses.Location = new System.Drawing.Point(50, 31);
            this.TextBoxRemovedClasses.Name = "TextBoxRemovedClasses";
            this.TextBoxRemovedClasses.ReadOnly = true;
            this.TextBoxRemovedClasses.Size = new System.Drawing.Size(269, 22);
            this.TextBoxRemovedClasses.TabIndex = 8;
            // 
            // TextBoxKeptClasses
            // 
            this.TextBoxKeptClasses.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxKeptClasses.Location = new System.Drawing.Point(50, 3);
            this.TextBoxKeptClasses.Name = "TextBoxKeptClasses";
            this.TextBoxKeptClasses.ReadOnly = true;
            this.TextBoxKeptClasses.Size = new System.Drawing.Size(269, 22);
            this.TextBoxKeptClasses.TabIndex = 7;
            // 
            // ButtonDoAction
            // 
            this.ButtonDoAction.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ButtonDoAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDoAction.Location = new System.Drawing.Point(327, 3);
            this.ButtonDoAction.Name = "ButtonDoAction";
            this.ButtonDoAction.Size = new System.Drawing.Size(75, 50);
            this.ButtonDoAction.TabIndex = 6;
            this.ButtonDoAction.Text = "執行";
            this.ButtonDoAction.UseVisualStyleBackColor = false;
            this.ButtonDoAction.Click += new System.EventHandler(this.OnButtonDoActionClicked);
            // 
            // LabelKeptClasses
            // 
            this.LabelKeptClasses.AutoSize = true;
            this.LabelKeptClasses.Location = new System.Drawing.Point(3, 8);
            this.LabelKeptClasses.Name = "LabelKeptClasses";
            this.LabelKeptClasses.Size = new System.Drawing.Size(41, 12);
            this.LabelKeptClasses.TabIndex = 0;
            this.LabelKeptClasses.Text = "保留：";
            // 
            // PanelClassIcons
            // 
            this.PanelClassIcons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelClassIcons.Controls.Add(this.ButtonKeepAll);
            this.PanelClassIcons.Controls.Add(this.ButtonRemoveAll);
            this.PanelClassIcons.Controls.Add(this.PictureBoxArcher);
            this.PanelClassIcons.Controls.Add(this.PictureBoxBladeMaster);
            this.PanelClassIcons.Controls.Add(this.PictureBoxAstromancer);
            this.PanelClassIcons.Controls.Add(this.PictureBoxKungFuFighter);
            this.PanelClassIcons.Controls.Add(this.PictureBoxWarrior);
            this.PanelClassIcons.Controls.Add(this.PictureBoxWarlock);
            this.PanelClassIcons.Controls.Add(this.PictureBoxForceMaster);
            this.PanelClassIcons.Controls.Add(this.PictureBoxBladeDancer);
            this.PanelClassIcons.Controls.Add(this.PictureBoxSummoner);
            this.PanelClassIcons.Controls.Add(this.PictureBoxSoulFighter);
            this.PanelClassIcons.Controls.Add(this.PictureBoxGunslinger);
            this.PanelClassIcons.Controls.Add(this.PictureBoxDestroyer);
            this.PanelClassIcons.Controls.Add(this.PictureBoxAssassin);
            this.PanelClassIcons.Location = new System.Drawing.Point(3, 42);
            this.PanelClassIcons.Name = "PanelClassIcons";
            this.PanelClassIcons.Size = new System.Drawing.Size(408, 89);
            this.PanelClassIcons.TabIndex = 11;
            // 
            // ButtonKeepAll
            // 
            this.ButtonKeepAll.BackColor = System.Drawing.Color.LightYellow;
            this.ButtonKeepAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonKeepAll.Location = new System.Drawing.Point(325, 50);
            this.ButtonKeepAll.Name = "ButtonKeepAll";
            this.ButtonKeepAll.Size = new System.Drawing.Size(75, 25);
            this.ButtonKeepAll.TabIndex = 18;
            this.ButtonKeepAll.Text = "全部保留";
            this.ButtonKeepAll.UseVisualStyleBackColor = false;
            this.ButtonKeepAll.Click += new System.EventHandler(this.OnButtonKeepAllClicked);
            // 
            // ButtonRemoveAll
            // 
            this.ButtonRemoveAll.BackColor = System.Drawing.Color.LightYellow;
            this.ButtonRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveAll.Location = new System.Drawing.Point(325, 10);
            this.ButtonRemoveAll.Name = "ButtonRemoveAll";
            this.ButtonRemoveAll.Size = new System.Drawing.Size(75, 25);
            this.ButtonRemoveAll.TabIndex = 17;
            this.ButtonRemoveAll.Text = "全部移除";
            this.ButtonRemoveAll.UseVisualStyleBackColor = false;
            this.ButtonRemoveAll.Click += new System.EventHandler(this.OnButtonRemoveAllClicked);
            // 
            // PictureBoxArcher
            // 
            this.PictureBoxArcher.ErrorImage = null;
            this.PictureBoxArcher.InitialImage = null;
            this.PictureBoxArcher.Location = new System.Drawing.Point(213, 45);
            this.PictureBoxArcher.Name = "PictureBoxArcher";
            this.PictureBoxArcher.Size = new System.Drawing.Size(36, 36);
            this.PictureBoxArcher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxArcher.TabIndex = 14;
            this.PictureBoxArcher.TabStop = false;
            this.PictureBoxArcher.Tag = "弓箭手=1";
            this.PictureBoxArcher.BackgroundImageChanged += new System.EventHandler(this.OnClassIconChanged);
            this.PictureBoxArcher.Click += new System.EventHandler(this.OnClassIconClicked);
            // 
            // PictureBoxBladeMaster
            // 
            this.PictureBoxBladeMaster.ErrorImage = null;
            this.PictureBoxBladeMaster.InitialImage = null;
            this.PictureBoxBladeMaster.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxBladeMaster.Name = "PictureBoxBladeMaster";
            this.PictureBoxBladeMaster.Size = new System.Drawing.Size(36, 36);
            this.PictureBoxBladeMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxBladeMaster.TabIndex = 6;
            this.PictureBoxBladeMaster.TabStop = false;
            this.PictureBoxBladeMaster.Tag = "劍士=1";
            this.PictureBoxBladeMaster.BackgroundImageChanged += new System.EventHandler(this.OnClassIconChanged);
            this.PictureBoxBladeMaster.Click += new System.EventHandler(this.OnClassIconClicked);
            // 
            // PictureBoxAstromancer
            // 
            this.PictureBoxAstromancer.ErrorImage = null;
            this.PictureBoxAstromancer.InitialImage = null;
            this.PictureBoxAstromancer.Location = new System.Drawing.Point(45, 45);
            this.PictureBoxAstromancer.Name = "PictureBoxAstromancer";
            this.PictureBoxAstromancer.Size = new System.Drawing.Size(36, 36);
            this.PictureBoxAstromancer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxAstromancer.TabIndex = 13;
            this.PictureBoxAstromancer.TabStop = false;
            this.PictureBoxAstromancer.Tag = "天道士=1";
            this.PictureBoxAstromancer.BackgroundImageChanged += new System.EventHandler(this.OnClassIconChanged);
            this.PictureBoxAstromancer.Click += new System.EventHandler(this.OnClassIconClicked);
            // 
            // PictureBoxKungFuFighter
            // 
            this.PictureBoxKungFuFighter.ErrorImage = null;
            this.PictureBoxKungFuFighter.InitialImage = null;
            this.PictureBoxKungFuFighter.Location = new System.Drawing.Point(171, 3);
            this.PictureBoxKungFuFighter.Name = "PictureBoxKungFuFighter";
            this.PictureBoxKungFuFighter.Size = new System.Drawing.Size(36, 36);
            this.PictureBoxKungFuFighter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxKungFuFighter.TabIndex = 9;
            this.PictureBoxKungFuFighter.TabStop = false;
            this.PictureBoxKungFuFighter.Tag = "拳士=1";
            this.PictureBoxKungFuFighter.BackgroundImageChanged += new System.EventHandler(this.OnClassIconChanged);
            this.PictureBoxKungFuFighter.Click += new System.EventHandler(this.OnClassIconClicked);
            // 
            // PictureBoxWarrior
            // 
            this.PictureBoxWarrior.ErrorImage = null;
            this.PictureBoxWarrior.InitialImage = null;
            this.PictureBoxWarrior.Location = new System.Drawing.Point(129, 3);
            this.PictureBoxWarrior.Name = "PictureBoxWarrior";
            this.PictureBoxWarrior.Size = new System.Drawing.Size(36, 36);
            this.PictureBoxWarrior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxWarrior.TabIndex = 16;
            this.PictureBoxWarrior.TabStop = false;
            this.PictureBoxWarrior.Tag = "鬥士=1";
            this.PictureBoxWarrior.BackgroundImageChanged += new System.EventHandler(this.OnClassIconChanged);
            this.PictureBoxWarrior.Click += new System.EventHandler(this.OnClassIconClicked);
            // 
            // PictureBoxWarlock
            // 
            this.PictureBoxWarlock.ErrorImage = null;
            this.PictureBoxWarlock.InitialImage = null;
            this.PictureBoxWarlock.Location = new System.Drawing.Point(171, 45);
            this.PictureBoxWarlock.Name = "PictureBoxWarlock";
            this.PictureBoxWarlock.Size = new System.Drawing.Size(36, 36);
            this.PictureBoxWarlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxWarlock.TabIndex = 15;
            this.PictureBoxWarlock.TabStop = false;
            this.PictureBoxWarlock.Tag = "咒術師=1";
            this.PictureBoxWarlock.BackgroundImageChanged += new System.EventHandler(this.OnClassIconChanged);
            this.PictureBoxWarlock.Click += new System.EventHandler(this.OnClassIconClicked);
            // 
            // PictureBoxForceMaster
            // 
            this.PictureBoxForceMaster.ErrorImage = null;
            this.PictureBoxForceMaster.InitialImage = null;
            this.PictureBoxForceMaster.Location = new System.Drawing.Point(87, 45);
            this.PictureBoxForceMaster.Name = "PictureBoxForceMaster";
            this.PictureBoxForceMaster.Size = new System.Drawing.Size(36, 36);
            this.PictureBoxForceMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxForceMaster.TabIndex = 8;
            this.PictureBoxForceMaster.TabStop = false;
            this.PictureBoxForceMaster.Tag = "氣功士=1";
            this.PictureBoxForceMaster.BackgroundImageChanged += new System.EventHandler(this.OnClassIconChanged);
            this.PictureBoxForceMaster.Click += new System.EventHandler(this.OnClassIconClicked);
            // 
            // PictureBoxBladeDancer
            // 
            this.PictureBoxBladeDancer.ErrorImage = null;
            this.PictureBoxBladeDancer.InitialImage = null;
            this.PictureBoxBladeDancer.Location = new System.Drawing.Point(45, 3);
            this.PictureBoxBladeDancer.Name = "PictureBoxBladeDancer";
            this.PictureBoxBladeDancer.Size = new System.Drawing.Size(36, 36);
            this.PictureBoxBladeDancer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxBladeDancer.TabIndex = 5;
            this.PictureBoxBladeDancer.TabStop = false;
            this.PictureBoxBladeDancer.Tag = "燐劍士=1";
            this.PictureBoxBladeDancer.BackgroundImageChanged += new System.EventHandler(this.OnClassIconChanged);
            this.PictureBoxBladeDancer.Click += new System.EventHandler(this.OnClassIconClicked);
            // 
            // PictureBoxSummoner
            // 
            this.PictureBoxSummoner.ErrorImage = null;
            this.PictureBoxSummoner.InitialImage = null;
            this.PictureBoxSummoner.Location = new System.Drawing.Point(129, 45);
            this.PictureBoxSummoner.Name = "PictureBoxSummoner";
            this.PictureBoxSummoner.Size = new System.Drawing.Size(36, 36);
            this.PictureBoxSummoner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxSummoner.TabIndex = 12;
            this.PictureBoxSummoner.TabStop = false;
            this.PictureBoxSummoner.Tag = "召喚師=1";
            this.PictureBoxSummoner.BackgroundImageChanged += new System.EventHandler(this.OnClassIconChanged);
            this.PictureBoxSummoner.Click += new System.EventHandler(this.OnClassIconClicked);
            // 
            // PictureBoxSoulFighter
            // 
            this.PictureBoxSoulFighter.ErrorImage = null;
            this.PictureBoxSoulFighter.InitialImage = null;
            this.PictureBoxSoulFighter.Location = new System.Drawing.Point(87, 3);
            this.PictureBoxSoulFighter.Name = "PictureBoxSoulFighter";
            this.PictureBoxSoulFighter.Size = new System.Drawing.Size(36, 36);
            this.PictureBoxSoulFighter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxSoulFighter.TabIndex = 11;
            this.PictureBoxSoulFighter.TabStop = false;
            this.PictureBoxSoulFighter.Tag = "乾坤士=1";
            this.PictureBoxSoulFighter.BackgroundImageChanged += new System.EventHandler(this.OnClassIconChanged);
            this.PictureBoxSoulFighter.Click += new System.EventHandler(this.OnClassIconClicked);
            // 
            // PictureBoxGunslinger
            // 
            this.PictureBoxGunslinger.ErrorImage = null;
            this.PictureBoxGunslinger.InitialImage = null;
            this.PictureBoxGunslinger.Location = new System.Drawing.Point(3, 45);
            this.PictureBoxGunslinger.Name = "PictureBoxGunslinger";
            this.PictureBoxGunslinger.Size = new System.Drawing.Size(36, 36);
            this.PictureBoxGunslinger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxGunslinger.TabIndex = 10;
            this.PictureBoxGunslinger.TabStop = false;
            this.PictureBoxGunslinger.Tag = "槍擊士=1";
            this.PictureBoxGunslinger.BackgroundImageChanged += new System.EventHandler(this.OnClassIconChanged);
            this.PictureBoxGunslinger.Click += new System.EventHandler(this.OnClassIconClicked);
            // 
            // PictureBoxDestroyer
            // 
            this.PictureBoxDestroyer.ErrorImage = null;
            this.PictureBoxDestroyer.InitialImage = null;
            this.PictureBoxDestroyer.Location = new System.Drawing.Point(213, 3);
            this.PictureBoxDestroyer.Name = "PictureBoxDestroyer";
            this.PictureBoxDestroyer.Size = new System.Drawing.Size(36, 36);
            this.PictureBoxDestroyer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxDestroyer.TabIndex = 7;
            this.PictureBoxDestroyer.TabStop = false;
            this.PictureBoxDestroyer.Tag = "力士=1";
            this.PictureBoxDestroyer.BackgroundImageChanged += new System.EventHandler(this.OnClassIconChanged);
            this.PictureBoxDestroyer.Click += new System.EventHandler(this.OnClassIconClicked);
            // 
            // PictureBoxAssassin
            // 
            this.PictureBoxAssassin.ErrorImage = null;
            this.PictureBoxAssassin.InitialImage = null;
            this.PictureBoxAssassin.Location = new System.Drawing.Point(255, 3);
            this.PictureBoxAssassin.Name = "PictureBoxAssassin";
            this.PictureBoxAssassin.Size = new System.Drawing.Size(36, 36);
            this.PictureBoxAssassin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxAssassin.TabIndex = 4;
            this.PictureBoxAssassin.TabStop = false;
            this.PictureBoxAssassin.Tag = "刺客=1";
            this.PictureBoxAssassin.BackgroundImageChanged += new System.EventHandler(this.OnClassIconChanged);
            this.PictureBoxAssassin.Click += new System.EventHandler(this.OnClassIconClicked);
            // 
            // PanelGameDirectory
            // 
            this.PanelGameDirectory.Controls.Add(this.LabelGameDirectory);
            this.PanelGameDirectory.Controls.Add(this.ButtonSelectGamePath);
            this.PanelGameDirectory.Controls.Add(this.TextBoxGamePath);
            this.PanelGameDirectory.Location = new System.Drawing.Point(3, 3);
            this.PanelGameDirectory.Name = "PanelGameDirectory";
            this.PanelGameDirectory.Size = new System.Drawing.Size(408, 33);
            this.PanelGameDirectory.TabIndex = 10;
            // 
            // LabelGameDirectory
            // 
            this.LabelGameDirectory.AutoSize = true;
            this.LabelGameDirectory.Location = new System.Drawing.Point(3, 11);
            this.LabelGameDirectory.Name = "LabelGameDirectory";
            this.LabelGameDirectory.Size = new System.Drawing.Size(77, 12);
            this.LabelGameDirectory.TabIndex = 1;
            this.LabelGameDirectory.Text = "遊戲資料夾：";
            // 
            // ButtonSelectGamePath
            // 
            this.ButtonSelectGamePath.Location = new System.Drawing.Point(368, 6);
            this.ButtonSelectGamePath.Name = "ButtonSelectGamePath";
            this.ButtonSelectGamePath.Size = new System.Drawing.Size(35, 23);
            this.ButtonSelectGamePath.TabIndex = 6;
            this.ButtonSelectGamePath.Text = "...";
            this.ButtonSelectGamePath.UseVisualStyleBackColor = true;
            this.ButtonSelectGamePath.Click += new System.EventHandler(this.OnButtonSelectGamePathClicked);
            // 
            // TextBoxGamePath
            // 
            this.TextBoxGamePath.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxGamePath.Location = new System.Drawing.Point(86, 6);
            this.TextBoxGamePath.Name = "TextBoxGamePath";
            this.TextBoxGamePath.ReadOnly = true;
            this.TextBoxGamePath.Size = new System.Drawing.Size(276, 22);
            this.TextBoxGamePath.TabIndex = 0;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOption});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(444, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItemOption
            // 
            this.ToolStripMenuItemOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSaveSettings});
            this.ToolStripMenuItemOption.Name = "ToolStripMenuItemOption";
            this.ToolStripMenuItemOption.Size = new System.Drawing.Size(43, 20);
            this.ToolStripMenuItemOption.Text = "選項";
            // 
            // ToolStripMenuItemSaveSettings
            // 
            this.ToolStripMenuItemSaveSettings.Checked = true;
            this.ToolStripMenuItemSaveSettings.CheckOnClick = true;
            this.ToolStripMenuItemSaveSettings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItemSaveSettings.Name = "ToolStripMenuItemSaveSettings";
            this.ToolStripMenuItemSaveSettings.Size = new System.Drawing.Size(182, 22);
            this.ToolStripMenuItemSaveSettings.Text = "結束時儲存目前設定";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(444, 241);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "劍靈技能特效移除程式";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.PanelMain.ResumeLayout(false);
            this.PanelAction.ResumeLayout(false);
            this.PanelAction.PerformLayout();
            this.PanelClassIcons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBladeMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAstromancer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxKungFuFighter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWarrior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWarlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxForceMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBladeDancer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSummoner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSoulFighter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGunslinger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDestroyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAssassin)).EndInit();
            this.PanelGameDirectory.ResumeLayout(false);
            this.PanelGameDirectory.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.TextBox TextBoxGamePath;
        private System.Windows.Forms.Label LabelGameDirectory;
        private System.Windows.Forms.Button ButtonSelectGamePath;
        private System.Windows.Forms.FolderBrowserDialog SelectGamePathDialog;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOption;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveSettings;
        private System.Windows.Forms.PictureBox PictureBoxAssassin;
        private System.Windows.Forms.Panel PanelGameDirectory;
        private System.Windows.Forms.PictureBox PictureBoxBladeDancer;
        private System.Windows.Forms.PictureBox PictureBoxBladeMaster;
        private System.Windows.Forms.PictureBox PictureBoxDestroyer;
        private System.Windows.Forms.PictureBox PictureBoxForceMaster;
        private System.Windows.Forms.PictureBox PictureBoxKungFuFighter;
        private System.Windows.Forms.PictureBox PictureBoxGunslinger;
        private System.Windows.Forms.PictureBox PictureBoxSoulFighter;
        private System.Windows.Forms.PictureBox PictureBoxSummoner;
        private System.Windows.Forms.PictureBox PictureBoxAstromancer;
        private System.Windows.Forms.PictureBox PictureBoxWarlock;
        private System.Windows.Forms.PictureBox PictureBoxWarrior;
        private System.Windows.Forms.Panel PanelClassIcons;
        private System.Windows.Forms.Button ButtonRemoveAll;
        private System.Windows.Forms.PictureBox PictureBoxArcher;
        private System.Windows.Forms.Button ButtonKeepAll;
        private System.Windows.Forms.Panel PanelAction;
        private System.Windows.Forms.Label LabelRemovedClasses;
        private System.Windows.Forms.TextBox TextBoxRemovedClasses;
        private System.Windows.Forms.TextBox TextBoxKeptClasses;
        private System.Windows.Forms.Button ButtonDoAction;
        private System.Windows.Forms.Label LabelKeptClasses;
    }
}
