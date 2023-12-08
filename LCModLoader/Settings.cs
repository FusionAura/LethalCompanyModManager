using System.ComponentModel;

namespace LCModLoader
{
    public struct Settings
    {
        public string GameExe { get; set; }
        public string GameDir { get; set; }
        public string ModDir { get; set; }
        public string ProfileDir { get; set; }
        public Profile CurrentProfile { get; set; }
        public BindingList<Profile> ProfileList { get; set; }
    }
}
