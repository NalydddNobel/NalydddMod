using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Souls
{
    public class BBSoulofShime : ModItem
    {
        bool start;
        float red;
        float green;
        float blue;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of Shime");
            Tooltip.SetDefault("'The essence of gemstones'\n'Shime is a word? right?'\nExpert");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 2750;
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
            if (!start)
            {
                red = 0.5f;
                green = 0.5f;
                blue = 0.5f;
                start = true;
            }
            else
            {
                {
                    if (red > 1.5)
                    {
                        red = 1.5f;
                    }
                    red += Main.rand.Next(-1, 2) * 0.01f;              
                }
                {
                    if (green > 1.5)
                    {
                        green = 1.5f;
                    }
                    green += Main.rand.Next(-1, 2) * 0.01f;
                }
                {
                    if (blue > 1.5)
                    {
                        blue = 1.5f;
                    }
                    blue += Main.rand.Next(-1, 2) * 0.01f;
                }
            }
            Lighting.AddLight((int)(item.position.X / 16f), (int)(item.position.Y / 16f), red, green, blue);            
        }
    }
}