using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
namespace nalydmod.Dusts
{
    public class LavaSparkle : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.velocity *= 0.55f;
            dust.noLight = false;
        }
        public override Color? GetAlpha(Dust dust, Color lightColor)
        {
            return Color.White;
        }
        public override bool MidUpdate(Dust dust)
        {
            float strength = dust.scale * 10f;
            if (strength > 1f)
            {
                strength = 1f;
            }
            Lighting.AddLight(dust.position, 0.1f * strength, 0.2f * strength, 0.7f * strength);
            return true;
        }
        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;
            dust.rotation += 0.25f;
            dust.scale *= 0.98f;
            dust.velocity.Y += 0.02f;
            if (Main.rand.Next(14) == 0)
            {
                dust.frame.Y += 10;
            }
            if (dust.frame.Y > 20)
            {
                dust.frame.Y = 0;
            }
            if (dust.scale < 0.33f)
            {
                dust.active = false;
            }
            return false;
        }
    }
}