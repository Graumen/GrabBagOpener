using Terraria.ModLoader;
namespace GrabBagOpener
{
    public class Mod0 : Mod
    {
        public static ModHotKey act;
        public override void Load() => act = RegisterHotKey("Activate", "");
        public override void Unload() => act = null;
    }
}