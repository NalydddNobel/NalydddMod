using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Souls
{
    public class SoulofSlime : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul Of Slime");
            Tooltip.SetDefault("You cannot feel the soul itself, but you know that it's slimy.");

        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.value = 2500;
            item.maxStack = 999;
            item.rare = ItemRarityID.Expert;
            item.expertOnly = true;
            item.expert = true;
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            Terraria.Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 6));
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.LightBlue;
        }
    }
}




