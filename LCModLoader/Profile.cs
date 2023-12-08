using System;
using System.Collections.Generic;
namespace LCModLoader;

public class Profile
{
    public string ProfileName { get; set; }
    public List<ModFile> ActiveModList { get; set; }
    public int ModCountActive => ActiveModList.Count;

}