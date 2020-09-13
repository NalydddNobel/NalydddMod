using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
namespace nalydmod.Dusts
{
    public class SpaceSpiral : ModDust
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
            Lighting.AddLight(dust.position, 0.2f, 0.2f, 0.3f);
            return false;
        }
        public override bool Update(Dust dust)
        {
            dust.position.Y += dust.velocity.Y * 0.1f;
            dust.velocity.X /= 1.05f;
            dust.position.X += dust.velocity.X * 0.05f;
            dust.scale *= 0.99f;
            dust.rotation += Main.rand.Next(1, 4) * 0.1f;
            if (dust.scale < 0.33f)
            {
                dust.active = false;
            }
            return false;
        }
    }
}