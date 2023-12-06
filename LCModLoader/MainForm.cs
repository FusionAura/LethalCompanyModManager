using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace LCModLoader;

public partial class MainForm : Form
{
    private About _aboutApp = new();
    private Profile_Editor _profileEditor = new();
    private List<ModFile> _modList = new();
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
    }

    private void GetConfigSettings()
    {
        //TODO: Set _gameDir to game directory
        //TODO: Open Config file and copy list data to appropriate mod lists
    }

    private void FirstTimeBoot()
    {
        Directory.CreateDirectory("Mods");
        Directory.CreateDirectory("Profiles");

        //TODO: If no config file exists, Create Config file.

        //TODO: Check to see if in the game's directory. If game can't be found, prompt user to select game directory
        var game = "Lethal Company.exe";

        if (File.Exists(game))
            _gameDir = Directory.GetCurrentDirectory();
        else
           FindGameDir(game);
        
        //TODO: If Game is found, check to see if BepInEx is installed
        //TODO: If BepInEx is not installed, Display prompt that it is missing.
    }

    private void FindGameDir(string game)
    {
        var dialog = new CommonOpenFileDialog();
        dialog.IsFolderPicker = true;
        while (_gameDir == "")
        {
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (File.Exists(dialog.FileName+@"\"+game))
                    _gameDir = Directory.GetCurrentDirectory();
                else
                {
                    CanNotFindGame(game);
                }
            }
            else
            {
                CanNotFindGame(game);
            }
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
        {
            _gameDir = "Error";
            
        }
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
        Process.Start("https://github.com/FusionAura/LethalCompanyModManager");
    }

    private void submitBugsToolStripMenuItem_Click(object sender, EventArgs e)
    {
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
        Process.Start(_gameDir);
    }
}