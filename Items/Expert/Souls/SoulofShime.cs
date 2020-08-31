using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Souls
{
    public class SoulofShime : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of Shime");
            Tooltip.SetDefault("'The essence of gemstones'\n'Shime is a word? right?'\nExpert");
        }
        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.value = 5000;
            item.maxStack = 999;
            item.rare = 1;
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