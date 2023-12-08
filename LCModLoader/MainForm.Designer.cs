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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            SavePlayBtn = new System.Windows.Forms.Button();
            ModListSaveBtn = new System.Windows.Forms.Button();
            AddModBtn = new System.Windows.Forms.Button();
            ProfileList = new System.Windows.Forms.ComboBox();
            profileBindingSource = new System.Windows.Forms.BindingSource(components);
            profileListBindingSource = new System.Windows.Forms.BindingSource(components);
            settingsBindingSource = new System.Windows.Forms.BindingSource(components);
            ProfileListLabel = new System.Windows.Forms.Label();
            ModUpdateBtn = new System.Windows.Forms.Button();
            ModRemoveBtn = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            dataGridBoolColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            dataGridBoolColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            dataGridBoolColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ModListLabel = new System.Windows.Forms.Label();
            dataGridBoolColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            BtnProfileEditor = new System.Windows.Forms.Button();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            profileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            githubRepoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            submitBugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            listView1 = new System.Windows.Forms.ListView();
            ModName = new System.Windows.Forms.ColumnHeader();
            Author = new System.Windows.Forms.ColumnHeader();
            Version = new System.Windows.Forms.ColumnHeader();
            modDescription = new System.Windows.Forms.GroupBox();
            BtnNewProfile = new System.Windows.Forms.Button();
            activeModListBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)profileBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profileListBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settingsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)activeModListBindingSource).BeginInit();
            SuspendLayout();
            // 
            // SavePlayBtn
            // 
            SavePlayBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            SavePlayBtn.Location = new System.Drawing.Point(14, 607);
            SavePlayBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SavePlayBtn.MinimumSize = new System.Drawing.Size(107, 28);
            SavePlayBtn.Name = "SavePlayBtn";
            SavePlayBtn.Size = new System.Drawing.Size(107, 28);
            SavePlayBtn.TabIndex = 0;
            SavePlayBtn.Text = "Save and Play";
            SavePlayBtn.UseVisualStyleBackColor = true;
            // 
            // ModListSaveBtn
            // 
            ModListSaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            ModListSaveBtn.Location = new System.Drawing.Point(128, 607);
            ModListSaveBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ModListSaveBtn.MinimumSize = new System.Drawing.Size(107, 28);
            ModListSaveBtn.Name = "ModListSaveBtn";
            ModListSaveBtn.Size = new System.Drawing.Size(107, 28);
            ModListSaveBtn.TabIndex = 1;
            ModListSaveBtn.Text = "Save Mod List";
            ModListSaveBtn.UseVisualStyleBackColor = true;
            // 
            // AddModBtn
            // 
            AddModBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            AddModBtn.Location = new System.Drawing.Point(13, 405);
            AddModBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AddModBtn.MinimumSize = new System.Drawing.Size(107, 29);
            AddModBtn.Name = "AddModBtn";
            AddModBtn.Size = new System.Drawing.Size(107, 29);
            AddModBtn.TabIndex = 7;
            AddModBtn.Text = "Add Mod";
            AddModBtn.UseVisualStyleBackColor = true;
            AddModBtn.Click += AddModBtn_Click;
            // 
            // ProfileList
            // 
            ProfileList.DataBindings.Add(new System.Windows.Forms.Binding("Text", profileBindingSource, "ProfileName", true));
            ProfileList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", profileBindingSource, "ProfileName", true));
            ProfileList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", profileBindingSource, "ProfileName", true));
            ProfileList.DataBindings.Add(new System.Windows.Forms.Binding("DataContext", profileBindingSource, "ProfileName", true));
            ProfileList.DataSource = profileListBindingSource;
            ProfileList.DisplayMember = "ProfileName";
            ProfileList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ProfileList.FormattingEnabled = true;
            ProfileList.Location = new System.Drawing.Point(14, 53);
            ProfileList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ProfileList.MinimumSize = new System.Drawing.Size(194, 0);
            ProfileList.Name = "ProfileList";
            ProfileList.Size = new System.Drawing.Size(194, 23);
            ProfileList.TabIndex = 10;
            ProfileList.SelectedIndexChanged += ProfileList_SelectedIndexChanged;
            // 
            // profileBindingSource
            // 
            profileBindingSource.DataSource = typeof(Profile);
            // 
            // profileListBindingSource
            // 
            profileListBindingSource.DataMember = "ProfileList";
            profileListBindingSource.DataSource = settingsBindingSource;
            // 
            // settingsBindingSource
            // 
            settingsBindingSource.DataSource = typeof(Settings);
            settingsBindingSource.CurrentChanged += settingsBindingSource_CurrentChanged;
            // 
            // ProfileListLabel
            // 
            ProfileListLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ProfileListLabel.Location = new System.Drawing.Point(14, 28);
            ProfileListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ProfileListLabel.Name = "ProfileListLabel";
            ProfileListLabel.Size = new System.Drawing.Size(152, 22);
            ProfileListLabel.TabIndex = 11;
            ProfileListLabel.Text = "Current Profile";
            ProfileListLabel.Click += label1_Click_1;
            // 
            // ModUpdateBtn
            // 
            ModUpdateBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ModUpdateBtn.Location = new System.Drawing.Point(217, 107);
            ModUpdateBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ModUpdateBtn.MinimumSize = new System.Drawing.Size(131, 29);
            ModUpdateBtn.Name = "ModUpdateBtn";
            ModUpdateBtn.Size = new System.Drawing.Size(131, 29);
            ModUpdateBtn.TabIndex = 13;
            ModUpdateBtn.Text = "Check For Updates";
            ModUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // ModRemoveBtn
            // 
            ModRemoveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            ModRemoveBtn.Location = new System.Drawing.Point(239, 405);
            ModRemoveBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ModRemoveBtn.MinimumSize = new System.Drawing.Size(107, 29);
            ModRemoveBtn.Name = "ModRemoveBtn";
            ModRemoveBtn.Size = new System.Drawing.Size(107, 29);
            ModRemoveBtn.TabIndex = 14;
            ModRemoveBtn.Text = "Remove Mod";
            ModRemoveBtn.UseVisualStyleBackColor = true;
            ModRemoveBtn.Click += ModRemoveBtn_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Green;
            label3.Location = new System.Drawing.Point(261, 607);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.MinimumSize = new System.Drawing.Size(94, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 18);
            label3.TabIndex = 15;
            label3.Text = "Mods Active";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(216, 28);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.MinimumSize = new System.Drawing.Size(132, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(132, 73);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // dataGridBoolColumn1
            // 
            dataGridBoolColumn1.Name = "dataGridBoolColumn1";
            dataGridBoolColumn1.Width = 5;
            // 
            // dataGridBoolColumn2
            // 
            dataGridBoolColumn2.Name = "dataGridBoolColumn2";
            dataGridBoolColumn2.Width = 5;
            // 
            // dataGridBoolColumn3
            // 
            dataGridBoolColumn3.Name = "dataGridBoolColumn3";
            dataGridBoolColumn3.Width = 5;
            // 
            // ModListLabel
            // 
            ModListLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ModListLabel.Location = new System.Drawing.Point(14, 114);
            ModListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ModListLabel.Name = "ModListLabel";
            ModListLabel.Size = new System.Drawing.Size(344, 23);
            ModListLabel.TabIndex = 12;
            ModListLabel.Text = "ModList";
            // 
            // dataGridBoolColumn4
            // 
            dataGridBoolColumn4.Name = "dataGridBoolColumn4";
            dataGridBoolColumn4.Width = 5;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            button1.Location = new System.Drawing.Point(125, 405);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.MinimumSize = new System.Drawing.Size(107, 29);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(107, 29);
            button1.TabIndex = 17;
            button1.Text = "Mod Settings";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.Desktop;
            label1.Location = new System.Drawing.Point(246, 622);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 27);
            label1.TabIndex = 18;
            label1.Text = "5";
            label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnProfileEditor
            // 
            BtnProfileEditor.Location = new System.Drawing.Point(134, 83);
            BtnProfileEditor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnProfileEditor.MinimumSize = new System.Drawing.Size(76, 28);
            BtnProfileEditor.Name = "BtnProfileEditor";
            BtnProfileEditor.Size = new System.Drawing.Size(76, 28);
            BtnProfileEditor.TabIndex = 19;
            BtnProfileEditor.Text = "Edit Profile\r\ns";
            BtnProfileEditor.UseVisualStyleBackColor = true;
            BtnProfileEditor.Click += button2_Click;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openExplorerToolStripMenuItem, addModToolStripMenuItem, checkForUpdatesToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openExplorerToolStripMenuItem
            // 
            openExplorerToolStripMenuItem.Name = "openExplorerToolStripMenuItem";
            openExplorerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            openExplorerToolStripMenuItem.Text = "Open Explorer";
            openExplorerToolStripMenuItem.Click += openExplorerToolStripMenuItem_Click;
            // 
            // addModToolStripMenuItem
            // 
            addModToolStripMenuItem.Name = "addModToolStripMenuItem";
            addModToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            addModToolStripMenuItem.Text = "Add Mod";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { preferencesToolStripMenuItem, profileListToolStripMenuItem });
            settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // preferencesToolStripMenuItem
            // 
            preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            preferencesToolStripMenuItem.Text = "Preferences";
            preferencesToolStripMenuItem.Click += preferencesToolStripMenuItem_Click;
            // 
            // profileListToolStripMenuItem
            // 
            profileListToolStripMenuItem.Name = "profileListToolStripMenuItem";
            profileListToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            profileListToolStripMenuItem.Text = "Profile List";
            profileListToolStripMenuItem.Click += profileListToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { githubRepoToolStripMenuItem, submitBugsToolStripMenuItem, aboutToolStripMenuItem });
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            infoToolStripMenuItem.Text = "Info";
            // 
            // githubRepoToolStripMenuItem
            // 
            githubRepoToolStripMenuItem.Name = "githubRepoToolStripMenuItem";
            githubRepoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            githubRepoToolStripMenuItem.Text = "Github Repo";
            githubRepoToolStripMenuItem.Click += githubRepoToolStripMenuItem_Click;
            // 
            // submitBugsToolStripMenuItem
            // 
            submitBugsToolStripMenuItem.Name = "submitBugsToolStripMenuItem";
            submitBugsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            submitBugsToolStripMenuItem.Text = "Submit Bugs";
            submitBugsToolStripMenuItem.Click += submitBugsToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.Transparent;
            menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(355, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // listView1
            // 
            listView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ModName, Author, Version });
            listView1.Location = new System.Drawing.Point(13, 141);
            listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listView1.MinimumSize = new System.Drawing.Size(333, 247);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(333, 257);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // ModName
            // 
            ModName.Text = "Mod Name";
            ModName.Width = 128;
            // 
            // Author
            // 
            Author.Text = "Author";
            Author.Width = 72;
            // 
            // Version
            // 
            Version.Text = "Version";
            // 
            // modDescription
            // 
            modDescription.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            modDescription.Location = new System.Drawing.Point(14, 441);
            modDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            modDescription.Name = "modDescription";
            modDescription.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            modDescription.Size = new System.Drawing.Size(334, 159);
            modDescription.TabIndex = 21;
            modDescription.TabStop = false;
            modDescription.Text = "Description";
            modDescription.Enter += modDescription_Enter;
            // 
            // BtnNewProfile
            // 
            BtnNewProfile.Location = new System.Drawing.Point(13, 83);
            BtnNewProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnNewProfile.MinimumSize = new System.Drawing.Size(76, 28);
            BtnNewProfile.Name = "BtnNewProfile";
            BtnNewProfile.Size = new System.Drawing.Size(76, 28);
            BtnNewProfile.TabIndex = 22;
            BtnNewProfile.Text = "Create Profile\r\n";
            BtnNewProfile.UseVisualStyleBackColor = true;
            BtnNewProfile.Click += BtnNewProfile_Click;
            // 
            // activeModListBindingSource
            // 
            activeModListBindingSource.DataMember = "ActiveModList";
            activeModListBindingSource.DataSource = profileBindingSource;
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(355, 647);
            Controls.Add(BtnNewProfile);
            Controls.Add(ModRemoveBtn);
            Controls.Add(button1);
            Controls.Add(AddModBtn);
            Controls.Add(modDescription);
            Controls.Add(listView1);
            Controls.Add(BtnProfileEditor);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(ModUpdateBtn);
            Controls.Add(ModListLabel);
            Controls.Add(ProfileListLabel);
            Controls.Add(ProfileList);
            Controls.Add(ModListSaveBtn);
            Controls.Add(SavePlayBtn);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(371, 686);
            Name = "MainForm";
            Text = "Lethal Company Mod Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)profileBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)profileListBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)settingsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)activeModListBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button BtnProfileEditor;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridBoolColumn4;

        private System.Windows.Forms.ToolStripMenuItem submitBugsToolStripMenuItem;
        private System.Windows.Forms.Label ModListLabel;

        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridBoolColumn3;

        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridBoolColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridBoolColumn2;

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
        private System.Windows.Forms.BindingSource profileBindingSource;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private System.Windows.Forms.BindingSource profileListBindingSource;
        private System.Windows.Forms.BindingSource activeModListBindingSource;
    }
}