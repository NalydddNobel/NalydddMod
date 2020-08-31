using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Souls
{
    public class SoulofDiazonium : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of Diazonium");
            Tooltip.SetDefault("Can be traded for special dyes with the Dye Trader.\n'The essence of colorful clothing'");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.value = 50000;
            item.maxStack = 999;
            item.rare = -11;
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            Terraria.Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
    }
}