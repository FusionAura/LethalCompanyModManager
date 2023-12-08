namespace LCModLoader
{
    partial class Profile_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile_Editor));
            ProfileList = new System.Windows.Forms.ListView();
            ProfileName = new System.Windows.Forms.ColumnHeader();
            ActiveModCount = new System.Windows.Forms.ColumnHeader();
            BtnNewProfile = new System.Windows.Forms.Button();
            BTNDelete = new System.Windows.Forms.Button();
            BtnClearProfile = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            BtnLoadProfile = new System.Windows.Forms.Button();
            BtnClose = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ProfileList
            // 
            ProfileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ProfileName, ActiveModCount });
            ProfileList.Location = new System.Drawing.Point(14, 42);
            ProfileList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ProfileList.Name = "ProfileList";
            ProfileList.Size = new System.Drawing.Size(326, 142);
            ProfileList.TabIndex = 0;
            ProfileList.UseCompatibleStateImageBehavior = false;
            ProfileList.View = System.Windows.Forms.View.Details;
            ProfileList.SelectedIndexChanged += ProfileList_SelectedIndexChanged;
            // 
            // ProfileName
            // 
            ProfileName.Text = "Profile Name";
            ProfileName.Width = 178;
            // 
            // ActiveModCount
            // 
            ActiveModCount.Text = "Active Mod Count";
            ActiveModCount.Width = 98;
            // 
            // BtnNewProfile
            // 
            BtnNewProfile.Location = new System.Drawing.Point(253, 192);
            BtnNewProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnNewProfile.Name = "BtnNewProfile";
            BtnNewProfile.Size = new System.Drawing.Size(88, 27);
            BtnNewProfile.TabIndex = 1;
            BtnNewProfile.Text = "New Profile";
            BtnNewProfile.UseVisualStyleBackColor = true;
            BtnNewProfile.Click += button1_Click;
            // 
            // BTNDelete
            // 
            BTNDelete.Location = new System.Drawing.Point(253, 258);
            BTNDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BTNDelete.Name = "BTNDelete";
            BTNDelete.Size = new System.Drawing.Size(88, 27);
            BTNDelete.TabIndex = 2;
            BTNDelete.Text = "Delete Profile";
            BTNDelete.UseVisualStyleBackColor = true;
            BTNDelete.Click += BTNDelete_Click;
            // 
            // BtnClearProfile
            // 
            BtnClearProfile.Location = new System.Drawing.Point(253, 225);
            BtnClearProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnClearProfile.Name = "BtnClearProfile";
            BtnClearProfile.Size = new System.Drawing.Size(88, 27);
            BtnClearProfile.TabIndex = 3;
            BtnClearProfile.Text = "Clear Profile";
            BtnClearProfile.UseVisualStyleBackColor = true;
            BtnClearProfile.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(14, 17);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 18);
            label1.TabIndex = 4;
            label1.Text = "Profile List";
            // 
            // BtnLoadProfile
            // 
            BtnLoadProfile.Location = new System.Drawing.Point(14, 192);
            BtnLoadProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnLoadProfile.Name = "BtnLoadProfile";
            BtnLoadProfile.Size = new System.Drawing.Size(88, 27);
            BtnLoadProfile.TabIndex = 5;
            BtnLoadProfile.Text = "Load Profile";
            BtnLoadProfile.UseVisualStyleBackColor = true;
            BtnLoadProfile.Click += button4_Click;
            // 
            // BtnClose
            // 
            BtnClose.Location = new System.Drawing.Point(14, 258);
            BtnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new System.Drawing.Size(88, 27);
            BtnClose.TabIndex = 6;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // Profile_Editor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(355, 292);
            Controls.Add(BtnClose);
            Controls.Add(BtnLoadProfile);
            Controls.Add(label1);
            Controls.Add(BtnClearProfile);
            Controls.Add(BTNDelete);
            Controls.Add(BtnNewProfile);
            Controls.Add(ProfileList);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Profile_Editor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Mod Profile Editor";
            Load += Profile_Editor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView ProfileList;
        private System.Windows.Forms.Button BtnNewProfile;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.Button BtnClearProfile;
        private System.Windows.Forms.ColumnHeader ProfileName;
        private System.Windows.Forms.ColumnHeader ActiveModCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLoadProfile;
        private System.Windows.Forms.Button BtnClose;
    }
}