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
    public partial class MainForm : Form
    {
        private About _aboutApp = new About();
        private Profile_Editor _profileEditor = new Profile_Editor();
        private List<ModFile> _modList = new();
        private string _gameDir = "";
        private string _modDir = "";
        private string _unusedModDir = "";
        

        public MainForm()
        {
            InitializeComponent();
            //TODO: Check for existing config file
            //TODO: if not, call FirstTimeBoot();
            
        }

        private void GetConfigSettings()
        {
            //TODO: Set _gameDir to game directory
            //TODO: Open Config file and copy list data to appropriate mod lists
        }
        
        private void FirstTimeBoot()
        {
            //TODO: If no config file exists, Look for the game's directory.
            //TODO: If game can't be found, prompt user to select game directory
            //TODO: If Game is found, check to see if BepInEx is installed
            //TODO: If BepInEx is not installed, Display prompt that it is missing.
        }

        private void LoadProfile()
        {
            //TODO:Get Profile
            //TODO:Load Active Mod List
            //TODO:Load Rest of Mods
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           // throw new System.NotImplementedException();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _aboutApp.ShowDialog();
            _aboutApp.StartPosition = FormStartPosition.CenterParent;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void AddModBtn_Click(object sender, EventArgs e)
        {
            //TODO: Get file (zip) from directory
            //TODO: Extract contents to Inactive Mod Folder
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Open Settings File in Text Editor
        }

        private void ModRemoveBtn_Click(object sender, EventArgs e)
        {
            //TODO: Disable Mod if active
            //TODO: Remove list reference
            //TODO: Delete Mod Files
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: Check if files are present
            //TODO: If Files missing or installed incorrectly and Actuv, show error message and disable mod
            //TODO: Check
        }

        private void modDescription_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _profileEditor.ShowDialog();
            _profileEditor.StartPosition = FormStartPosition.CenterParent;
        }

        private void BtnNewProfile_Click(object sender, EventArgs e)
        {
            //TODO: Empty Active Mod List
            //TODO: Create New Profile
        }
    }
}