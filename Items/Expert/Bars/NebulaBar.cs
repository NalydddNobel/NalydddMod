using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Bars
{
    public class NebulaBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Its in your hand... but it feels very distant.\nExpert");
        }
        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.value = 25000;
            item.maxStack = 999;
            item.rare = ItemRarityID.Cyan;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            Terraria.Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 4));
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
    }
}