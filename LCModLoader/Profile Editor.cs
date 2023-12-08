using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCModLoader
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public partial class Profile_Editor : Form
    {
        private Settings _settings;
        private Profile _currentProfile;
        public Profile_Editor(Settings settings, Profile currentProfile)
        {
            InitializeComponent();
            UpdateSettings(settings, currentProfile);
        }
        public void UpdateSettings(Settings settings, Profile currentProfile)
        {
            _settings = settings;
            _currentProfile = currentProfile;
            foreach (Profile a in _settings.ProfileList.ToList())
            {
                ProfileList.Items.Add(new ListViewItem(new string[] { a.ProfileName, a.ModCountActive.ToString() }));
            }
        }
        private void CreateProfile(string Name)
        {
            //Create Default Profile
            Profile newProfile = new();
            newProfile.ProfileName = Name;
            newProfile.ActiveModList = new();

            _settings.ProfileList.Add(newProfile);
            //Set Current Profile
            _currentProfile = _settings.ProfileList[_settings.ProfileList.Count-1];
            ProfileList.Items.Add(new ListViewItem(new string[] { _currentProfile.ProfileName, _currentProfile.ModCountActive.ToString() }));
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Empty Active Mod List

            bool dupe = false;
            while (true)
            {
                //TODO: Create New Profile
                string UserAnswer = Microsoft.VisualBasic.Interaction.InputBox("Please enter a profile name.", "Enter a Profile Name", "New Profile");
                if (UserAnswer.Length == 0)
                    return;

                foreach (Profile a in _settings.ProfileList)
                {
                    if (a.ProfileName == (UserAnswer))
                    {
                        //TODO:Check to see if name is used already.
                        var message = "This profile name is already in use. Enter a new name.";
                        var title = "Profile Name exists";
                        MessageBox.Show(message, title);
                        dupe = true;
                    }
                }
                if (!dupe)
                {
                    CreateProfile(UserAnswer);
                    return;
                }
                dupe = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Profile_Editor_Load(object sender, EventArgs e)
        {

        }

        private void ProfileList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
