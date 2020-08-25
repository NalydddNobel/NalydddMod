using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Souls
{
    public class SoulofSpine : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul Of Spine");
            Tooltip.SetDefault("Has back problems.\nDrops from Boney creatures.");

        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = 15000;
            item.maxStack = 999;
            item.rare = ItemRarityID.Expert;
            item.expertOnly = true;
            item.expert = true;
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;

        }
    }
}