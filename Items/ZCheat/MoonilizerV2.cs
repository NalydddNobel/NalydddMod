using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.ZCheat
{
    public class MoonilizerV2 : ModItem
    {
        public override string Texture => "nalydmod/Items/Materials/GemFragments/BasicFragment";
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Broken\nStarts a Pumpkin Moon\nIf day, sets the time to 7:30pm\nCheat Item.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SuspiciousLookingEye);
            item.scale = 2;
            item.color = Color.Orange;
            item.consumable = false;
            item.maxStack = 1;
        }
        public override bool UseItem(Terraria.Player player)
        {
            Main.dayTime = false;
            Main.bloodMoon = false;
            Main.pumpkinMoon = true;
            Main.snowMoon = false;
            return true;
        }
    }
}





