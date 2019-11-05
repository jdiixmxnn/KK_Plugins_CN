﻿using BepInEx;

namespace KK_Plugins
{
    [BepInDependency(Sideloader.Sideloader.GUID)]
    [BepInDependency(ExtensibleSaveFormat.ExtendedSave.GUID)]
    [BepInDependency(KKAPI.KoikatuAPI.GUID, "1.9")]
    [BepInDependency(KoiSkinOverlayX.KoiSkinOverlayMgr.GUID)]
    [BepInPlugin(GUID, PluginName, Version)]
    internal partial class UncensorSelector : BaseUnityPlugin { }
}