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
            this.Panel = new System.Windows.Forms.Panel();
            this.Button_SelectGamePath = new System.Windows.Forms.Button();
            this.Button_Restore = new System.Windows.Forms.Button();
            this.Button_Remove = new System.Windows.Forms.Button();
            this.ComboBox_ExcludedClass = new System.Windows.Forms.ComboBox();
            this.Label_KeepClassEffect = new System.Windows.Forms.Label();
            this.Label_GameDirectory = new System.Windows.Forms.Label();
            this.TextBox_GamePath = new System.Windows.Forms.TextBox();
            this.SelectGamePathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Option = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SaveSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel.Controls.Add(this.Button_SelectGamePath);
            this.Panel.Controls.Add(this.Button_Restore);
            this.Panel.Controls.Add(this.Button_Remove);
            this.Panel.Controls.Add(this.ComboBox_ExcludedClass);
            this.Panel.Controls.Add(this.Label_KeepClassEffect);
            this.Panel.Controls.Add(this.Label_GameDirectory);
            this.Panel.Controls.Add(this.TextBox_GamePath);
            this.Panel.Location = new System.Drawing.Point(12, 27);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(410, 89);
            this.Panel.TabIndex = 0;
            // 
            // Button_SelectGamePath
            // 
            this.Button_SelectGamePath.Location = new System.Drawing.Point(368, 8);
            this.Button_SelectGamePath.Name = "Button_SelectGamePath";
            this.Button_SelectGamePath.Size = new System.Drawing.Size(35, 23);
            this.Button_SelectGamePath.TabIndex = 6;
            this.Button_SelectGamePath.Text = "...";
            this.Button_SelectGamePath.UseVisualStyleBackColor = true;
            this.Button_SelectGamePath.Click += new System.EventHandler(this.Button_SelectGamePath_Click);
            // 
            // Button_Restore
            // 
            this.Button_Restore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Restore.Location = new System.Drawing.Point(333, 39);
            this.Button_Restore.Name = "Button_Restore";
            this.Button_Restore.Size = new System.Drawing.Size(70, 35);
            this.Button_Restore.TabIndex = 5;
            this.Button_Restore.Text = "還原特效";
            this.Button_Restore.UseVisualStyleBackColor = false;
            this.Button_Restore.Click += new System.EventHandler(this.Button_Restore_Click);
            // 
            // Button_Remove
            // 
            this.Button_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Button_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Remove.Location = new System.Drawing.Point(243, 39);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Size = new System.Drawing.Size(70, 35);
            this.Button_Remove.TabIndex = 4;
            this.Button_Remove.Text = "移除特效";
            this.Button_Remove.UseVisualStyleBackColor = false;
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // ComboBox_ExcludedClass
            // 
            this.ComboBox_ExcludedClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_ExcludedClass.FormattingEnabled = true;
            this.ComboBox_ExcludedClass.Items.AddRange(new object[] {
            "全部移除"});
            this.ComboBox_ExcludedClass.Location = new System.Drawing.Point(86, 47);
            this.ComboBox_ExcludedClass.Name = "ComboBox_ExcludedClass";
            this.ComboBox_ExcludedClass.Size = new System.Drawing.Size(137, 20);
            this.ComboBox_ExcludedClass.TabIndex = 3;
            // 
            // Label_KeepClassEffect
            // 
            this.Label_KeepClassEffect.AutoSize = true;
            this.Label_KeepClassEffect.Location = new System.Drawing.Point(15, 50);
            this.Label_KeepClassEffect.Name = "Label_KeepClassEffect";
            this.Label_KeepClassEffect.Size = new System.Drawing.Size(65, 12);
            this.Label_KeepClassEffect.TabIndex = 2;
            this.Label_KeepClassEffect.Text = "保留職業：";
            // 
            // Label_GameDirectory
            // 
            this.Label_GameDirectory.AutoSize = true;
            this.Label_GameDirectory.Location = new System.Drawing.Point(3, 13);
            this.Label_GameDirectory.Name = "Label_GameDirectory";
            this.Label_GameDirectory.Size = new System.Drawing.Size(77, 12);
            this.Label_GameDirectory.TabIndex = 1;
            this.Label_GameDirectory.Text = "遊戲資料夾：";
            // 
            // TextBox_GamePath
            // 
            this.TextBox_GamePath.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_GamePath.Location = new System.Drawing.Point(86, 8);
            this.TextBox_GamePath.Name = "TextBox_GamePath";
            this.TextBox_GamePath.ReadOnly = true;
            this.TextBox_GamePath.Size = new System.Drawing.Size(276, 22);
            this.TextBox_GamePath.TabIndex = 0;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Option});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(434, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Option
            // 
            this.ToolStripMenuItem_Option.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_SaveSettings});
            this.ToolStripMenuItem_Option.Name = "ToolStripMenuItem_Option";
            this.ToolStripMenuItem_Option.Size = new System.Drawing.Size(43, 20);
            this.ToolStripMenuItem_Option.Text = "選項";
            // 
            // ToolStripMenuItem_SaveSettings
            // 
            this.ToolStripMenuItem_SaveSettings.Checked = true;
            this.ToolStripMenuItem_SaveSettings.CheckOnClick = true;
            this.ToolStripMenuItem_SaveSettings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItem_SaveSettings.Name = "ToolStripMenuItem_SaveSettings";
            this.ToolStripMenuItem_SaveSettings.Size = new System.Drawing.Size(182, 22);
            this.ToolStripMenuItem_SaveSettings.Text = "結束時儲存目前設定";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 121);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "劍靈技能特效移除程式";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.TextBox TextBox_GamePath;
        private System.Windows.Forms.Label Label_GameDirectory;
        private System.Windows.Forms.Label Label_KeepClassEffect;
        private System.Windows.Forms.ComboBox ComboBox_ExcludedClass;
        private System.Windows.Forms.Button Button_Restore;
        private System.Windows.Forms.Button Button_Remove;
        private System.Windows.Forms.Button Button_SelectGamePath;
        private System.Windows.Forms.FolderBrowserDialog SelectGamePathDialog;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Option;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveSettings;
    }
}
