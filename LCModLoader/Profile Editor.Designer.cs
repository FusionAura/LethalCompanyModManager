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
            this.ProfileList = new System.Windows.Forms.ListView();
            this.ProfileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActiveModCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnNewProfile = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BtnClearProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLoadProfile = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProfileList
            // 
            this.ProfileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProfileName,
            this.ActiveModCount});
            this.ProfileList.HideSelection = false;
            this.ProfileList.Location = new System.Drawing.Point(12, 36);
            this.ProfileList.Name = "ProfileList";
            this.ProfileList.Size = new System.Drawing.Size(280, 124);
            this.ProfileList.TabIndex = 0;
            this.ProfileList.UseCompatibleStateImageBehavior = false;
            this.ProfileList.View = System.Windows.Forms.View.Details;
            // 
            // ProfileName
            // 
            this.ProfileName.Text = "Profile Name";
            this.ProfileName.Width = 178;
            // 
            // ActiveModCount
            // 
            this.ActiveModCount.Text = "Active Mod Count";
            this.ActiveModCount.Width = 98;
            // 
            // BtnNewProfile
            // 
            this.BtnNewProfile.Location = new System.Drawing.Point(217, 166);
            this.BtnNewProfile.Name = "BtnNewProfile";
            this.BtnNewProfile.Size = new System.Drawing.Size(75, 23);
            this.BtnNewProfile.TabIndex = 1;
            this.BtnNewProfile.Text = "New Profile";
            this.BtnNewProfile.UseVisualStyleBackColor = true;
            this.BtnNewProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNDelete
            // 
            this.BTNDelete.Location = new System.Drawing.Point(217, 224);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(75, 23);
            this.BTNDelete.TabIndex = 2;
            this.BTNDelete.Text = "Delete Profile";
            this.BTNDelete.UseVisualStyleBackColor = true;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BtnClearProfile
            // 
            this.BtnClearProfile.Location = new System.Drawing.Point(217, 195);
            this.BtnClearProfile.Name = "BtnClearProfile";
            this.BtnClearProfile.Size = new System.Drawing.Size(75, 23);
            this.BtnClearProfile.TabIndex = 3;
            this.BtnClearProfile.Text = "Clear Profile";
            this.BtnClearProfile.UseVisualStyleBackColor = true;
            this.BtnClearProfile.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Profile List";
            // 
            // BtnLoadProfile
            // 
            this.BtnLoadProfile.Location = new System.Drawing.Point(12, 166);
            this.BtnLoadProfile.Name = "BtnLoadProfile";
            this.BtnLoadProfile.Size = new System.Drawing.Size(75, 23);
            this.BtnLoadProfile.TabIndex = 5;
            this.BtnLoadProfile.Text = "Load Profile";
            this.BtnLoadProfile.UseVisualStyleBackColor = true;
            this.BtnLoadProfile.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(12, 224);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Profile_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 253);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnLoadProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClearProfile);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BtnNewProfile);
            this.Controls.Add(this.ProfileList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profile_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mod Profile Editor";
            this.Load += new System.EventHandler(this.Profile_Editor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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