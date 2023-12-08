
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace LCModLoader;
[System.Runtime.Versioning.SupportedOSPlatform("windows")]
public partial class MainForm : Form
{
    private About _aboutApp = new();
    private Settings _settings = new();
    private Profile_Editor _profileEditor;
    private List<ModFile> _modList = new();

    public MainForm()
    {
        InitializeComponent();
        //TODO: Check for existing config file
        var path = "Config.xml";
        
        if (!File.Exists(path))
        {
            var message = "Missing Config can be found, creating a new one.";
            var title = "No Config File";
            MessageBox.Show(message, title);
            
            FirstTimeBoot();
        }
    }

    private void CreateConfigFile()
    {
        XmlWriterSettings settings = new XmlWriterSettings();
        settings.Indent = true;
        settings.IndentChars = ("    ");
        using (XmlWriter writer = XmlWriter.Create("Config.xml", settings))
        {
            writer.WriteStartElement("Settings");
            writer.WriteElementString("GameExecutable", _settings.GameExe);
            writer.WriteElementString("GameDirectory", _settings.GameDir);
            writer.WriteElementString("ModFolder", _settings.ModDir);
            writer.WriteElementString("CurrentProfile", _settings.CurrentProfile.ProfileName);
            writer.WriteElementString("ProfileFolder", _settings.ProfileDir);
            writer.WriteEndElement();
            writer.Flush();
        }
    }

    //TODO: Load config file
    private void LoadConfigFile()
    {

        XmlTextReader textReader = new XmlTextReader("Config.xml");
        textReader.Read();
        // If the node has value  
        while (textReader.Read())
        {
            textReader.MoveToElement();
            _settings.GameExe = textReader.Value;
            _settings.GameDir = textReader.Value;
            _settings.ModDir = textReader.Value;
            _settings.ProfileDir = textReader.Value;
            
            //_settings.CurrentProfile = profile
        }




        XmlWriterSettings settings = new XmlWriterSettings();
        settings.Indent = true;
        settings.IndentChars = ("    ");
        using (XmlWriter writer = XmlWriter.Create("Config.xml", settings))
        {
            writer.WriteElementString("GameExecutable", _settings.GameExe);
            writer.WriteElementString("GameDirectory", _settings.GameDir);
            writer.WriteElementString("ModFolder", _settings.ModDir);
            writer.WriteElementString("CurrentProfile", _settings.CurrentProfile.ProfileName);
            writer.WriteElementString("ProfileFolder", _settings.ProfileDir);
            writer.WriteEndElement();
            writer.Flush();
        }
    }


    private void FirstTimeBoot()
    {
        
        //TODO: If no config file exists, Create Config file.
        var game = "Lethal Company.exe";
        var message = "The Mod Manager is not in the same folder as Lethal Company. Please select the location of the game.";
        var title = "Lethal Company Not Found";
        MessageBox.Show(message, title);
        //TODO: Check to see if in the game's directory. If game can't be found, prompt user to select game directory
        if (File.Exists(game))
        { 
            _settings.GameDir = Directory.GetCurrentDirectory();
            //TODO: If Game is found, check to see if BepInEx is installed

            //TODO: If BepInEx is not installed, Display prompt that it is missing.

        }
        else
            FindGameDir(game);

        //TODO: Check if existing profiles exist


        //TODO: If not, establish profile list
        _settings.ProfileList = new();
        CreateProfile("Default");


        
        
        _profileEditor = new(_settings, _settings.CurrentProfile);
        CreateConfigFile();
    }

    private void CreateProfile(string Name)
    {
        //Create Default Profile
        Profile newProfile = new();
        newProfile.ProfileName = Name;
        newProfile.ActiveModList = new();

        _settings.ProfileList.Add(newProfile);

        ProfileList.DataSource = _settings.ProfileList;

        ProfileList.DisplayMember = newProfile.ProfileName;
        ProfileList.SelectedItem = ProfileList.Items[0];


        //Set Current Profile
        _settings.CurrentProfile = (Profile)ProfileList.Items[0];
        SaveProfileToXML(_settings.CurrentProfile);
    }

    private void LoadProfileFile()
    {

        XmlTextReader textReader = new XmlTextReader(_settings.CurrentProfile.ProfileName + ".xml");
        textReader.Read();
        // If the node has value  
        while (textReader.Read())
        {
            textReader.MoveToElement();
            _settings.CurrentProfile.ProfileName = textReader.Value;
            //_settings.GameDir = textReader.Value;


            //_settings.CurrentProfile = profile
        }
    }

    private void SaveProfileToXML(Profile newProfile)
    {
        //TODO: Notify if mod is missing
        XmlWriterSettings settings = new XmlWriterSettings();
        settings.Indent = true;
        settings.IndentChars = ("    ");

        using (XmlWriter writer = XmlWriter.Create(_settings.ProfileDir+@"/"+newProfile.ProfileName+".xml", settings))
        {
            writer.WriteStartElement("Profile");
            writer.WriteElementString("ProfileName", newProfile.ProfileName);
            writer.WriteStartElement("ActiveMods");
            foreach (ModFile a in newProfile.ActiveModList)
                writer.WriteElementString(a.ModName, a.ModFileDir);
            writer.WriteEndElement();
            writer.Flush();
        }
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

        while (_settings.GameDir == null)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(Path.GetDirectoryName(folderBrowser.FileName) + @"\" + game))
                {
                    _settings.GameExe = Path.GetDirectoryName(folderBrowser.FileName) + @"\" + Path.GetFileName(folderBrowser.FileName);
                    _settings.GameDir = Path.GetDirectoryName(folderBrowser.FileName);
                }
                else
                    CanNotFindGame(game);

            }
            else
                CanNotFindGame(game);

        }


        string dir = Path.GetDirectoryName(folderBrowser.FileName);
        Directory.CreateDirectory(dir + @"/Mods");
        Directory.CreateDirectory(dir + @"/Profiles");
        _settings.ModDir = Path.GetDirectoryName(folderBrowser.FileName) + @"/Mods";
        _settings.ProfileDir = Path.GetDirectoryName(folderBrowser.FileName) + @"/Profiles";
    }

    void CanNotFindGame(string game)
    {
        var dialogResult =
            MessageBox.Show("Lethal Company cannot be found in this folder. Would you like to try again?",
                "No Game Detected", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
            FindGameDir(game);
        else if (dialogResult == DialogResult.No)
            _settings.GameDir = "Error";
    }

    private void LoadProfile()
    {
        //TODO:Get Profile
        //TODO:Load Active Mod List
        //TODO:Load Rest of Mods
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        
        if (_settings.GameDir == "Error")
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

    private void button2_Click(object sender, EventArgs e)
    {
        _profileEditor.ShowDialog();
        _profileEditor.UpdateSettings(_settings, _settings.CurrentProfile);
        _profileEditor.StartPosition = FormStartPosition.CenterParent;
    }

    private void BtnNewProfile_Click(object sender, EventArgs e)
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
                _profileEditor.UpdateSettings(_settings, _settings.CurrentProfile);
                return;
            }
            dupe = false;
        }
    }


    private void modDescription_Enter(object sender, EventArgs e)
    {
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
        if (_settings.GameDir == "")
        {
            var message = "Lethal Company directory hasn't been set";
            var title = "Error";
            MessageBox.Show(message, title);
            return;
        }

        //@"c:\"
        Process.Start("explorer.exe", _settings.GameDir);
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

    private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void label1_Click_1(object sender, EventArgs e)
    {
    }

}