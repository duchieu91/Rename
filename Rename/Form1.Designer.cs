namespace Rename
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.labelComplete = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRename = new System.Windows.Forms.TabPage();
            this.tabResize = new System.Windows.Forms.TabPage();
            this.pBarResize = new System.Windows.Forms.ProgressBar();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonResize = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxHight = new System.Windows.Forms.TextBox();
            this.textBoxWith = new System.Windows.Forms.TextBox();
            this.textBoxSave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLoad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabRename.SuspendLayout();
            this.tabResize.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.Location = new System.Drawing.Point(500, 17);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(64, 29);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "&Broswe";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textBoxDir
            // 
            this.textBoxDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDir.Location = new System.Drawing.Point(11, 21);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(483, 20);
            this.textBoxDir.TabIndex = 2;
            this.textBoxDir.TextChanged += new System.EventHandler(this.textBoxDir_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directory";
            // 
            // pBar1
            // 
            this.pBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pBar1.Location = new System.Drawing.Point(11, 211);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(569, 23);
            this.pBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar1.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(11, 83);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(253, 20);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // btnRename
            // 
            this.btnRename.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRename.Location = new System.Drawing.Point(260, 149);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(98, 34);
            this.btnRename.TabIndex = 6;
            this.btnRename.Text = "&RENAME";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.openFolderToolStripMenuItem.Text = "&Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.resizeToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Op&tion";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.renameToolStripMenuItem.Text = "Re&name";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resizeToolStripMenuItem.Text = "Re&size";
            this.resizeToolStripMenuItem.Click += new System.EventHandler(this.resizeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // useToolStripMenuItem
            // 
            this.useToolStripMenuItem.Name = "useToolStripMenuItem";
            this.useToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.useToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.useToolStripMenuItem.Text = "&Use";
            this.useToolStripMenuItem.Click += new System.EventHandler(this.useToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Length of filename";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLength.Location = new System.Drawing.Point(11, 129);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(31, 20);
            this.textBoxLength.TabIndex = 10;
            this.textBoxLength.Text = "6";
            this.textBoxLength.TextChanged += new System.EventHandler(this.textBoxLength_TextChanged);
            // 
            // labelComplete
            // 
            this.labelComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelComplete.AutoSize = true;
            this.labelComplete.Location = new System.Drawing.Point(11, 195);
            this.labelComplete.Name = "labelComplete";
            this.labelComplete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelComplete.Size = new System.Drawing.Size(50, 13);
            this.labelComplete.TabIndex = 11;
            this.labelComplete.Text = "STATUS";
            this.labelComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabRename);
            this.tabControl1.Controls.Add(this.tabResize);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 266);
            this.tabControl1.TabIndex = 12;
            // 
            // tabRename
            // 
            this.tabRename.Controls.Add(this.btnRename);
            this.tabRename.Controls.Add(this.btnBrowse);
            this.tabRename.Controls.Add(this.label1);
            this.tabRename.Controls.Add(this.label2);
            this.tabRename.Controls.Add(this.textBoxDir);
            this.tabRename.Controls.Add(this.textBoxName);
            this.tabRename.Controls.Add(this.labelComplete);
            this.tabRename.Controls.Add(this.pBar1);
            this.tabRename.Controls.Add(this.label3);
            this.tabRename.Controls.Add(this.textBoxLength);
            this.tabRename.Location = new System.Drawing.Point(4, 22);
            this.tabRename.Name = "tabRename";
            this.tabRename.Padding = new System.Windows.Forms.Padding(3);
            this.tabRename.Size = new System.Drawing.Size(586, 240);
            this.tabRename.TabIndex = 0;
            this.tabRename.Text = "Rename";
            this.tabRename.UseVisualStyleBackColor = true;
            // 
            // tabResize
            // 
            this.tabResize.Controls.Add(this.pBarResize);
            this.tabResize.Controls.Add(this.labelInfo);
            this.tabResize.Controls.Add(this.buttonResize);
            this.tabResize.Controls.Add(this.label9);
            this.tabResize.Controls.Add(this.label8);
            this.tabResize.Controls.Add(this.label7);
            this.tabResize.Controls.Add(this.label6);
            this.tabResize.Controls.Add(this.buttonSave);
            this.tabResize.Controls.Add(this.buttonLoad);
            this.tabResize.Controls.Add(this.textBoxHight);
            this.tabResize.Controls.Add(this.textBoxWith);
            this.tabResize.Controls.Add(this.textBoxSave);
            this.tabResize.Controls.Add(this.label5);
            this.tabResize.Controls.Add(this.textBoxLoad);
            this.tabResize.Controls.Add(this.label4);
            this.tabResize.Location = new System.Drawing.Point(4, 22);
            this.tabResize.Name = "tabResize";
            this.tabResize.Size = new System.Drawing.Size(586, 240);
            this.tabResize.TabIndex = 1;
            this.tabResize.Text = "Resize";
            this.tabResize.UseVisualStyleBackColor = true;
            // 
            // pBarResize
            // 
            this.pBarResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pBarResize.ForeColor = System.Drawing.Color.SeaGreen;
            this.pBarResize.Location = new System.Drawing.Point(23, 210);
            this.pBarResize.Name = "pBarResize";
            this.pBarResize.Size = new System.Drawing.Size(544, 23);
            this.pBarResize.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBarResize.TabIndex = 6;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(20, 187);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(59, 13);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "Information";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonResize
            // 
            this.buttonResize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonResize.Location = new System.Drawing.Point(258, 170);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(75, 30);
            this.buttonResize.TabIndex = 4;
            this.buttonResize.Text = "RESIZE";
            this.buttonResize.UseVisualStyleBackColor = true;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "pixel";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "pixel";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Hight:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "With:";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(492, 46);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Browse";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Location = new System.Drawing.Point(492, 10);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Browse";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxHight
            // 
            this.textBoxHight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxHight.Location = new System.Drawing.Point(71, 115);
            this.textBoxHight.Name = "textBoxHight";
            this.textBoxHight.Size = new System.Drawing.Size(61, 20);
            this.textBoxHight.TabIndex = 1;
            this.textBoxHight.Text = "275";
            // 
            // textBoxWith
            // 
            this.textBoxWith.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxWith.Location = new System.Drawing.Point(71, 89);
            this.textBoxWith.Name = "textBoxWith";
            this.textBoxWith.Size = new System.Drawing.Size(61, 20);
            this.textBoxWith.TabIndex = 1;
            this.textBoxWith.Text = "275";
            // 
            // textBoxSave
            // 
            this.textBoxSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSave.Location = new System.Drawing.Point(76, 47);
            this.textBoxSave.Name = "textBoxSave";
            this.textBoxSave.Size = new System.Drawing.Size(395, 20);
            this.textBoxSave.TabIndex = 1;
            this.textBoxSave.TextChanged += new System.EventHandler(this.textBoxSave_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Save to:";
            // 
            // textBoxLoad
            // 
            this.textBoxLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLoad.Location = new System.Drawing.Point(76, 11);
            this.textBoxLoad.Name = "textBoxLoad";
            this.textBoxLoad.Size = new System.Drawing.Size(395, 20);
            this.textBoxLoad.TabIndex = 1;
            this.textBoxLoad.TextChanged += new System.EventHandler(this.textBoxLoad_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Load from:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(594, 294);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Rename & Resize File";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabRename.ResumeLayout(false);
            this.tabRename.PerformLayout();
            this.tabResize.ResumeLayout(false);
            this.tabResize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label labelComplete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRename;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabResize;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxHight;
        private System.Windows.Forms.TextBox textBoxWith;
        private System.Windows.Forms.TextBox textBoxSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLoad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ProgressBar pBarResize;
    }
}

