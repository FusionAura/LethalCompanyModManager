using System.Collections.Generic;

namespace LCModLoader;

public struct Profile
{
    private string _profileName;
    private List<ModFile> _activeModList;
    private int _ModCountActive;
}