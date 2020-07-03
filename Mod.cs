using Terraria.ModLoader;
namespace GrabBagOpener
{
    public class Mod0 : Mod
    {
        public static ModHotKey activate;
        public override void Load() => activate = RegisterHotKey("Activate", "");
        public override void Unload() => activate = null;
    }
}