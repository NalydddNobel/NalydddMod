using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Souls
{
    public class SoulofGrime : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of Grime");
            Tooltip.SetDefault("'The essence of thy flesh being consumed'\nExpert");
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.value = 25000;
            item.maxStack = 999;
            item.rare = 4;
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }
    }
}