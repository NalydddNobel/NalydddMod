using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
namespace nalydmod.Dusts
{
    public class MoonSolutionDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.velocity *= 0.22f;
            dust.noLight = false;
            dust.alpha = 55;
        }
        public override Color? GetAlpha(Dust dust, Color lightColor)
        {
            return Color.White;
        }
        public override bool Update(Dust dust)
        {
            dust.scale *= 0.99f;
            if (dust.scale < 0.22f)
            {
                dust.active = false;
            }
            return false;
        }
    }
}