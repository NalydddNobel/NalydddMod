using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Souls
{
    public class AASoulofSlime : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of Slime");
            Tooltip.SetDefault("'The essence of royal gelatins'\n'You cannot feel the soul itself, but you know that it's slimy'\nExpert");
        }
        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.value = 2500;
            item.maxStack = 999;
            item.rare = 1;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            Terraria.Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 4));
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
    }
}