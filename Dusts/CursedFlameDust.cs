using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
namespace nalydmod.Dusts
{
    public class CursedFlameDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.velocity *= 0.22f;
            dust.noLight = false;
            dust.noGravity = true;
            dust.alpha = 255;
        }
        public override bool Update(Dust dust)
        {
            dust.position.Y -= 0.09f;
            dust.scale *= 0.88f;
            if (dust.scale < 0.11)
            {
                dust.active = false;
            }
            else
            {
                Lighting.AddLight((int)(dust.position.X / 16f), (int)(dust.position.Y / 16f), dust.color.R / 255f * 0.5f, dust.color.G / 255f * 0.5f, dust.color.B / 255f * 0.5f);
            }
            return false;
        }
        public override Color? GetAlpha(Dust dust, Color lightColor)
        {
            return Color.White;
        }
    }
}