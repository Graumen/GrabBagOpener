using Terraria.ModLoader;
using Terraria;
namespace GrabBagOpener
{
    class ModPlayer0 : ModPlayer
    {
        bool active;
        public override void ProcessTriggers(Terraria.GameInput.TriggersSet _)
        {
            var lp = Main.LocalPlayer;

            if (active)
            {
                for (int slot = 0; 58 > slot; slot++)
                {
                    var item = lp.inventory[slot];

                    if (1774 == item.type)
                    {
                        lp.openGoodieBag();
                        lp.ConsumeItem(item.type);
                    }
                    if (1869 == item.type)
                    {
                        lp.openPresent();
                        lp.ConsumeItem(item.type);
                    }
                    if (2333 < item.type && 2337 > item.type || 3202 < item.type && 3209 > item.type)
                    {
                        lp.openCrate(item.type);
                        lp.ConsumeItem(item.type);
                    }
                    if (3085 == item.type && lp.ConsumeItem(327))
                    {
                        lp.openLockBox();
                        lp.ConsumeItem(item.type);
                    }
                    if (3093 == item.type)
                    {
                        lp.openHerbBag();
                        lp.ConsumeItem(item.type);
                    }
                    if (3317 < item.type && 3333 > item.type || 3859 < item.type && 3863 > item.type || ItemLoader.IsModBossBag(item))
                    {
                        lp.OpenBossBag(item.type);
                        lp.ConsumeItem(item.type);
                    }
                }
            }
            if (Mod0.activate.JustPressed)
            {
                active = !active;
                Main.NewText("Grab Bag Opener " + (active ? "[c/00ff00:On]" : "[c/ff0000:Off]"));
            }
        }
    }
}