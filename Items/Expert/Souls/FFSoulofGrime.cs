using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Souls
{
    public class FFSoulofGrime : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of Grime");
            Tooltip.SetDefault("'The essence of thy flesh being consumed'\nExpert");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 2500;
            item.maxStack = 999;
            item.rare = 2;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            ItemID.Sets.ItemIconPulse[item.type] = true;
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 4));
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void PostUpdate()
        {
            Lighting.AddLight((int)(item.position.X / 16f), (int)(item.position.Y / 16f), 0.22f, 0, 0);
        }
    }
}