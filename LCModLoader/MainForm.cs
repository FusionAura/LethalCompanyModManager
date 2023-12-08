using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;

namespace LCModLoader;

public partial class MainForm : Form
{
    private About _aboutApp = new();
    private Settings _settings = new();
    private Profile_Editor _profileEditor = new();
    private List<ModFile> _modList = new();
    private Profile _currentProfile;
    private string _gameExe = "";
    private string _gameDir = "";
    private string _modDir = "";
    private string _profileDir = "";


    public MainForm()
    {
        InitializeComponent();
        //TODO: Check for existing config file
        var path = "Config.json";

        if (!File.Exists(path))
        {
            var message = "Missing Config can be found, creating a new one.";
            var title = "No Config File";
            MessageBox.Show(message, title);
            FirstTimeBoot();
        }
        GetConfigSettings();
    }

    private void GetConfigSettings()
    {

        //TODO: Open Config file and copy list data to appropriate mod lists
        _gameExe = _settings._gameExe;
        _gameDir = _settings._gameDir;
        _modDir = _settings._modDir;
        _profileDir = _settings._profileDir;
    }

    private void FirstTimeBoot()
    {
        Directory.CreateDirectory("Mods");
        Directory.CreateDirectory("Profiles");

        //TODO: If no config file exists, Create Config file.
        var game = "Lethal Company.exe";
        var message = "The Mod Manager is not in the same folder as Lethal Company. Please select the location of the game.";
        var title = "Lethal Company Not Found";
        MessageBox.Show(message, title);
        if (File.Exists(game))
            _gameDir = Directory.GetCurrentDirectory();
        else
            FindGameDir(game);

        //Create Default Profile
        Profile Default = new();
        Default.ProfileName = "Default";
        Default.ActiveModList = new();
        ProfileList.DataSource = _settings.ProfileList;
        //Add Profile to Combobox.
        ProfileList.Items.Insert(0, Default);
        ProfileList.DisplayMember = Default.ProfileName;


        ProfileList.Text = Default.ProfileName;


        //Set Current Profile
        _currentProfile = (Profile)ProfileList.Items[0];



        //TODO: Check to see if in the game's directory. If game can't be found, prompt user to select game directory
        //TODO: If Game is found, check to see if BepInEx is installed
        //TODO: If BepInEx is not installed, Display prompt that it is missing.


    }

    private void FindGameDir(string game)
    {

        OpenFileDialog folderBrowser = new OpenFileDialog();
        // Set validate names and check file exists to false otherwise windows will
        // not let you select "Folder Selection."
        folderBrowser.ValidateNames = false;
        folderBrowser.CheckFileExists = false;
        folderBrowser.CheckPathExists = true;
        // Always default to Folder Selection.
        folderBrowser.FileName = game;


        while (_gameDir == "")
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(Path.GetDirectoryName(folderBrowser.FileName) + @"\" + game))
                {
                    _settings._gameExe = Path.GetDirectoryName(folderBrowser.FileName) + @"\" + Path.GetFileName(folderBrowser.FileName);
                    _settings._gameDir = Path.GetDirectoryName(folderBrowser.FileName);
                    _settings._modDir = Directory.GetCurrentDirectory() + @"/Mods";
                    _settings._profileDir = Directory.GetCurrentDirectory() + @"/Profiles";

                    _gameExe = _settings._gameExe;
                    _gameDir = _settings._gameDir;
                    _modDir = _settings._modDir;
                    _profileDir = _settings._profileDir;
                }
                else
                    CanNotFindGame(game);

            }
            else
                CanNotFindGame(game);

        }

    }

    void CanNotFindGame(string game)
    {
        var dialogResult =
            MessageBox.Show("Lethal Company cannot be found in this folder. Would you like to try again?",
                "No Game Detected", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
            FindGameDir(game);
        else if (dialogResult == DialogResult.No)
            _gameDir = "Error";


    }

    private void LoadProfile()
    {
        //TODO:Get Profile
        //TODO:Load Active Mod List
        //TODO:Load Rest of Mods
    }

    private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void label1_Click_1(object sender, EventArgs e)
    {
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        if (_gameDir == "Error")
            Application.Exit();
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
        //TODO: If Files missing or installed incorrectly and Active, show error message and disable mod
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

    private void githubRepoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = "https://github.com/FusionAura/LethalCompanyModManager",
            UseShellExecute = true
        });
    }

    private void submitBugsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = "https://github.com/FusionAura/LethalCompanyModManager/issues/new",
            UseShellExecute = true
        });
    }

    private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void profileListToolStripMenuItem_Click(object sender, EventArgs e)
    {
        _profileEditor.ShowDialog();
        _profileEditor.StartPosition = FormStartPosition.CenterParent;
    }

    private void openExplorerToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (_gameDir == "")
        {
            var message = "Lethal Company directory hasn't been set";
            var title = "Error";
            MessageBox.Show(message, title);
            return;
        }

        //@"c:\"
        Process.Start("explorer.exe", _gameDir);
    }

    private void quitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void ProfileList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void settingsBindingSource_CurrentChanged(object sender, EventArgs e)
    {

    }
}