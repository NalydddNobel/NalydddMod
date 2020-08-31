using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Souls
{
    public class SoulofTime : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul Of Time");
            Tooltip.SetDefault("'The essence of eyes'\n'You can see the entire world aging'\nExpert");
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 5000;
            item.maxStack = 999;
            item.rare = 2;
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            Terraria.Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
        }
    }
}