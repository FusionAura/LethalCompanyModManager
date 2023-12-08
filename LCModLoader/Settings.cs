using System.Collections.Generic;

namespace LCModLoader
{
    public struct Settings
    {
        public string _gameExe { get; set; }
        public string _gameDir { get; set; }
        public string _modDir { get; set; }
        public string _profileDir { get; set; }
        public List<Profile> ProfileList { get; set; }
    }
}
