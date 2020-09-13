using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
namespace nalydmod.Dusts
{
    public class DeadlyFlameDust2 : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.velocity *= 0.22f;
            dust.noLight = false;
            dust.noGravity = true;
        }
        public override bool Update(Dust dust)
        {
            dust.position.X += Main.rand.NextFloat(-10, 10) * 0.1f;
            dust.scale *= 0.88f;
            if (dust.scale < 0.08)
            {
                dust.active = false;
            }
            else
            {
                Lighting.AddLight((int)(dust.position.X / 16f), (int)(dust.position.Y / 16f), 0, 0.22f, 0.30f);
            }
            return false;
        }
        public override Color? GetAlpha(Dust dust, Color lightColor)
        {
            return Color.White;
        }
    }
}