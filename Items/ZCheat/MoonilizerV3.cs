using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.ZCheat
{
    public class MoonilizerV3 : ModItem
    {
        public override string Texture => "nalydmod/Items/Materials/GemFragments/BasicFragment";
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Starts a Frost Moon\nIf day, sets the time to 7:30pm\nCheat Item.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SuspiciousLookingEye);
            item.scale = 2;
            item.consumable = false;
            item.maxStack = 1;
        }
        public override bool UseItem(Terraria.Player player)
        {
            Main.dayTime = false;
            Main.bloodMoon = false;
            Main.pumpkinMoon = false;
            Main.snowMoon = true;
            Main.startSnowMoon();
            return true;
        }
    }
}





