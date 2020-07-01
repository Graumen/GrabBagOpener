using Terraria.ModLoader;
using Terraria;
namespace GrabBagOpener
{
    class ModPlayer0 : ModPlayer
    {
        bool gbo;
        public override void ProcessTriggers(Terraria.GameInput.TriggersSet ts)
        {
            var lp = Main.LocalPlayer;

            if (gbo)
            {
                for (int id = 0; 58 > id; id++)
                {
                    var _ = lp.inventory[id];

                    if (_.type < 2337 && _.type > 2333 || _.type < 3209 && _.type > 3202) lp.openCrate(_.type);
                    if (_.type < 3333 && _.type > 3317 || _.type < 3863 && _.type > 3859 || ItemLoader.IsModBossBag(_)) lp.OpenBossBag(_.type);
                    if (_.type == 1774) lp.openGoodieBag();
                    if (_.type == 1869) lp.openPresent();
                    if (_.type == 3085) lp.openLockBox();
                    if (_.type == 3093) lp.openHerbBag();
                    if (_.type < 2337 && _.type > 2333 || _.type < 3209 && _.type > 3202 || _.type < 3333 && _.type > 3317 || _.type < 3863 && _.type > 3859 || _.type == 1774 || _.type == 1869 || _.type == 3085 || _.type == 3093 || ItemLoader.IsModBossBag(_))
                    {
                        if (_.stack > 1) _.stack--;
                        else _.SetDefaults();
                        break;
                    }
                }
            }
            if (Mod0.act.JustPressed)
            {
                gbo = !gbo;
                Main.NewText("Grab Bag Opener " + (gbo ? "[c/00ff00:On]" : "[c/ff0000:Off]"));
            }
        }
    }
}