using System.Collections.Generic;
namespace LCModLoader
{
    public struct ModFile
    {
        public string ModFileDir;
        public string ModSettingFile;
        
        public string ModName;
        public string Author;
        public int Version;
        public string WebsiteURL;
        public string Description;
        public List<string> Dependencies;
    }
}