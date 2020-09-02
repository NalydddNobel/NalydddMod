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
            return false;
        }
        public override Color? GetAlpha(Dust dust, Color lightColor)
        {
            lightColor = Color.GreenYellow;
            return Color.White;
        }
    }
}