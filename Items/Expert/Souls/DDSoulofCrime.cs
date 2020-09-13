using IL.Terraria.GameContent.UI.Elements;
using Microsoft.Xna.Framework;
using nalydmod.Items.Placeables.Blocks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Souls
{
    public class DDSoulofCrime : ModItem
    {
        bool start;
        bool colorflip;
        float red;
        float blue;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of Crime");
            Tooltip.SetDefault("'The essence of infectious properties'\nExpert");
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
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(4, 8));
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void PostUpdate()
        {
            if (!start)
            {
                red = 0.5f;
                blue = 0.5f;
                start = true;
            }
            else
            {
                if (!colorflip)
                {
                    blue += Main.rand.Next(1, 2) * 0.002f;
                    red -= Main.rand.Next(1, 2) * 0.0015f;
                    if (blue > 0.8)
                    {
                        colorflip = true;
                    }
                }
                if (colorflip)
                {
                    blue -= Main.rand.Next(1, 2) * 0.002f;
                    red += Main.rand.Next(1, 2) * 0.0023f;
                    if (red > 0.8)
                    {
                        colorflip = false;
                    }
                }
            }
            Lighting.AddLight((int)(item.position.X / 16f), (int)(item.position.Y / 16f), red, 0, blue);
        }
    }
}