using Microsoft.Xna.Framework;
using Terraria;
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
            item.width = 20;
            item.height = 20;
            item.value = 2500;
            item.maxStack = 999;
            item.rare = 1;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            ItemID.Sets.ItemIconPulse[item.type] = true;
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void PostUpdate()
        {
            Lighting.AddLight((int)(item.position.X / 16f), (int)(item.position.Y / 16f), 0, 0, 0.5f);
        }
    }
}