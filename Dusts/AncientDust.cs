using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
namespace nalydmod.Dusts
{
    public class AncientDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noLight = false;
        }
        public override Color? GetAlpha(Dust dust, Color lightColor)
        {
            return Color.White;
        }
        public override bool MidUpdate(Dust dust)
        {
            Lighting.AddLight(dust.position, 0, 0.2f, 0);
            return false;
        }
        public override bool Update(Dust dust)
        {
            dust.position.Y += dust.velocity.Y * 0.1f;
            dust.velocity.X /= 1.005f;
            dust.position.X += dust.velocity.X * 0.05f;
            dust.scale *= 0.99f;
            if (dust.scale < 0.22f)
            {
                dust.active = false;
            }
            return false;
        }
    }
}