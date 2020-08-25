using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.ZCheat
{
    public class Fowardilizer : ModItem
    {
        public override string Texture => "nalydmod/Items/Materials/GemFragments/BasicFragment";
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Speeds up time when used.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SuspiciousLookingEye);
            item.scale = 2;
            item.color = Color.AliceBlue;
            item.consumable = false;
            item.maxStack = 1;
            item.useTime = 2;
            item.useAnimation = 2;
            item.autoReuse = true;
        }
        public override bool UseItem(Player player)
        {
            Main.time += 300;
            return true;
        }
    }
}





