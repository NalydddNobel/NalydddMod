using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.ZCheat
{
    public class Reversilizer : ModItem
    {
        public override string Texture => "nalydmod/Items/Materials/GemFragments/BasicFragment";
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Reverses time when used.\nHas somewhat unstable results.\nThe skys red!");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SuspiciousLookingEye);
            item.scale = 2;
            item.color = Color.AntiqueWhite;
            item.consumable = false;
            item.maxStack = 1;
            item.useTime = 2;
            item.useAnimation = 2;
            item.autoReuse = true;
        }
        public override bool UseItem(Player player)
        {
            Main.time -= 300;
            return true;
        }
    }
}





