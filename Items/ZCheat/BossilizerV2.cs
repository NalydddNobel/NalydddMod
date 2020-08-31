using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.ZCheat
{
    public class BossilizerV2 : ModItem
    {
        public override string Texture => "nalydmod/Items/Materials/GemFragments/BasicFragment";
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Resets all SuperHardmode Boss Progression.\nCheat Item.");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SuspiciousLookingEye);
            item.scale = 2;
            item.consumable = false;
            item.maxStack = 1;
        }
        public override bool UseItem(Player player)
        {
            MyWorld.DownedEoC2 = false;
            return true;
        }
    }
}