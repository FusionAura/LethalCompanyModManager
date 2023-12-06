namespace LCModLoader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SavePlayBtn = new System.Windows.Forms.Button();
            this.ModListSaveBtn = new System.Windows.Forms.Button();
            this.AddModBtn = new System.Windows.Forms.Button();
            this.ProfileList = new System.Windows.Forms.ComboBox();
            this.ProfileListLabel = new System.Windows.Forms.Label();
            this.ModUpdateBtn = new System.Windows.Forms.Button();
            this.ModRemoveBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
            this.dataGridBoolColumn2 = new System.Windows.Forms.DataGridBoolColumn();
            this.dataGridBoolColumn3 = new System.Windows.Forms.DataGridBoolColumn();
            this.ModListLabel = new System.Windows.Forms.Label();
            this.dataGridBoolColumn4 = new System.Windows.Forms.DataGridBoolColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnProfileEditor = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubRepoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitBugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ModName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modDescription = new System.Windows.Forms.GroupBox();
            this.BtnNewProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SavePlayBtn
            // 
            this.SavePlayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SavePlayBtn.Location = new System.Drawing.Point(12, 526);
            this.SavePlayBtn.MinimumSize = new System.Drawing.Size(92, 24);
            this.SavePlayBtn.Name = "SavePlayBtn";
            this.SavePlayBtn.Size = new System.Drawing.Size(92, 24);
            this.SavePlayBtn.TabIndex = 0;
            this.SavePlayBtn.Text = "Save and Play";
            this.SavePlayBtn.UseVisualStyleBackColor = true;
            // 
            // ModListSaveBtn
            // 
            this.ModListSaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ModListSaveBtn.Location = new System.Drawing.Point(110, 526);
            this.ModListSaveBtn.MinimumSize = new System.Drawing.Size(92, 24);
            this.ModListSaveBtn.Name = "ModListSaveBtn";
            this.ModListSaveBtn.Size = new System.Drawing.Size(92, 24);
            this.ModListSaveBtn.TabIndex = 1;
            this.ModListSaveBtn.Text = "Save Mod List";
            this.ModListSaveBtn.UseVisualStyleBackColor = true;
            // 
            // AddModBtn
            // 
            this.AddModBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddModBtn.Location = new System.Drawing.Point(11, 351);
            this.AddModBtn.MinimumSize = new System.Drawing.Size(92, 25);
            this.AddModBtn.Name = "AddModBtn";
            this.AddModBtn.Size = new System.Drawing.Size(92, 25);
            this.AddModBtn.TabIndex = 7;
            this.AddModBtn.Text = "Add Mod";
            this.AddModBtn.UseVisualStyleBackColor = true;
            this.AddModBtn.Click += new System.EventHandler(this.AddModBtn_Click);
            // 
            // ProfileList
            // 
            this.ProfileList.FormattingEnabled = true;
            this.ProfileList.Location = new System.Drawing.Point(12, 46);
            this.ProfileList.MinimumSize = new System.Drawing.Size(167, 0);
            this.ProfileList.Name = "ProfileList";
            this.ProfileList.Size = new System.Drawing.Size(167, 21);
            this.ProfileList.TabIndex = 10;
            // 
            // ProfileListLabel
            // 
            this.ProfileListLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileListLabel.Location = new System.Drawing.Point(12, 24);
            this.ProfileListLabel.Name = "ProfileListLabel";
            this.ProfileListLabel.Size = new System.Drawing.Size(130, 19);
            this.ProfileListLabel.TabIndex = 11;
            this.ProfileListLabel.Text = "Current Profile";
            this.ProfileListLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ModUpdateBtn
            // 
            this.ModUpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModUpdateBtn.Location = new System.Drawing.Point(186, 93);
            this.ModUpdateBtn.MinimumSize = new System.Drawing.Size(112, 25);
            this.ModUpdateBtn.Name = "ModUpdateBtn";
            this.ModUpdateBtn.Size = new System.Drawing.Size(112, 25);
            this.ModUpdateBtn.TabIndex = 13;
            this.ModUpdateBtn.Text = "Check For Updates";
            this.ModUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // ModRemoveBtn
            // 
            this.ModRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ModRemoveBtn.Location = new System.Drawing.Point(205, 351);
            this.ModRemoveBtn.MinimumSize = new System.Drawing.Size(92, 25);
            this.ModRemoveBtn.Name = "ModRemoveBtn";
            this.ModRemoveBtn.Size = new System.Drawing.Size(92, 25);
            this.ModRemoveBtn.TabIndex = 14;
            this.ModRemoveBtn.Text = "Remove Mod";
            this.ModRemoveBtn.UseVisualStyleBackColor = true;
            this.ModRemoveBtn.Click += new System.EventHandler(this.ModRemoveBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(217, 523);
            this.label3.MinimumSize = new System.Drawing.Size(81, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mods Active";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 24);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(113, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridBoolColumn1
            // 
            this.dataGridBoolColumn1.Width = -1;
            // 
            // dataGridBoolColumn2
            // 
            this.dataGridBoolColumn2.Width = -1;
            // 
            // dataGridBoolColumn3
            // 
            this.dataGridBoolColumn3.Width = -1;
            // 
            // ModListLabel
            // 
            this.ModListLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModListLabel.Location = new System.Drawing.Point(12, 99);
            this.ModListLabel.Name = "ModListLabel";
            this.ModListLabel.Size = new System.Drawing.Size(295, 20);
            this.ModListLabel.TabIndex = 12;
            this.ModListLabel.Text = "ModList";
            // 
            // dataGridBoolColumn4
            // 
            this.dataGridBoolColumn4.Width = -1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(107, 351);
            this.button1.MinimumSize = new System.Drawing.Size(92, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "Mod Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(211, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "5";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnProfileEditor
            // 
            this.BtnProfileEditor.Location = new System.Drawing.Point(115, 72);
            this.BtnProfileEditor.MinimumSize = new System.Drawing.Size(65, 24);
            this.BtnProfileEditor.Name = "BtnProfileEditor";
            this.BtnProfileEditor.Size = new System.Drawing.Size(65, 24);
            this.BtnProfileEditor.TabIndex = 19;
            this.BtnProfileEditor.Text = "Edit Profile\r\ns";
            this.BtnProfileEditor.UseVisualStyleBackColor = true;
            this.BtnProfileEditor.Click += new System.EventHandler(this.button2_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExplorerToolStripMenuItem,
            this.addModToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openExplorerToolStripMenuItem
            // 
            this.openExplorerToolStripMenuItem.Name = "openExplorerToolStripMenuItem";
            this.openExplorerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openExplorerToolStripMenuItem.Text = "Open Explorer";
            // 
            // addModToolStripMenuItem
            // 
            this.addModToolStripMenuItem.Name = "addModToolStripMenuItem";
            this.addModToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addModToolStripMenuItem.Text = "Add Mod";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.profileListToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // profileListToolStripMenuItem
            // 
            this.profileListToolStripMenuItem.Name = "profileListToolStripMenuItem";
            this.profileListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profileListToolStripMenuItem.Text = "Profile List";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubRepoToolStripMenuItem,
            this.submitBugsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // githubRepoToolStripMenuItem
            // 
            this.githubRepoToolStripMenuItem.Name = "githubRepoToolStripMenuItem";
            this.githubRepoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.githubRepoToolStripMenuItem.Text = "Github Repo";
            // 
            // submitBugsToolStripMenuItem
            // 
            this.submitBugsToolStripMenuItem.Name = "submitBugsToolStripMenuItem";
            this.submitBugsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.submitBugsToolStripMenuItem.Text = "Submit Bugs";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ModName,
            this.Author,
            this.Version});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 122);
            this.listView1.MinimumSize = new System.Drawing.Size(286, 215);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 223);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ModName
            // 
            this.ModName.Text = "Mod Name";
            this.ModName.Width = 128;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 72;
            // 
            // Version
            // 
            this.Version.Text = "Version";
            // 
            // modDescription
            // 
            this.modDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modDescription.Location = new System.Drawing.Point(12, 382);
            this.modDescription.Name = "modDescription";
            this.modDescription.Size = new System.Drawing.Size(286, 138);
            this.modDescription.TabIndex = 21;
            this.modDescription.TabStop = false;
            this.modDescription.Text = "Description";
            this.modDescription.Enter += new System.EventHandler(this.modDescription_Enter);
            // 
            // BtnNewProfile
            // 
            this.BtnNewProfile.Location = new System.Drawing.Point(11, 72);
            this.BtnNewProfile.MinimumSize = new System.Drawing.Size(65, 24);
            this.BtnNewProfile.Name = "BtnNewProfile";
            this.BtnNewProfile.Size = new System.Drawing.Size(65, 24);
            this.BtnNewProfile.TabIndex = 22;
            this.BtnNewProfile.Text = "Create Profile\r\n";
            this.BtnNewProfile.UseVisualStyleBackColor = true;
            this.BtnNewProfile.Click += new System.EventHandler(this.BtnNewProfile_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 561);
            this.Controls.Add(this.BtnNewProfile);
            this.Controls.Add(this.ModRemoveBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddModBtn);
            this.Controls.Add(this.modDescription);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnProfileEditor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModUpdateBtn);
            this.Controls.Add(this.ModListLabel);
            this.Controls.Add(this.ProfileListLabel);
            this.Controls.Add(this.ProfileList);
            this.Controls.Add(this.ModListSaveBtn);
            this.Controls.Add(this.SavePlayBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(320, 600);
            this.Name = "MainForm";
            this.Text = "Lethal Company Mod Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button BtnProfileEditor;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn4;

        private System.Windows.Forms.ToolStripMenuItem submitBugsToolStripMenuItem;
        private System.Windows.Forms.Label ModListLabel;

        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn3;

        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn1;
        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn2;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubRepoToolStripMenuItem;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ComboBox ProfileList;

        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;

        private System.Windows.Forms.Button ModRemoveBtn;

        private System.Windows.Forms.Button AddModBtn;
        private System.Windows.Forms.Button ModUpdateBtn;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;

        private System.Windows.Forms.Button SavePlayBtn;
        private System.Windows.Forms.Button ModListSaveBtn;
        private System.Windows.Forms.Label ProfileListLabel;

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ModName;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Version;
        private System.Windows.Forms.GroupBox modDescription;
        private System.Windows.Forms.Button BtnNewProfile;
    }
}