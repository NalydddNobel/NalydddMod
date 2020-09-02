using Terraria;
using Terraria.ModLoader;
namespace nalydmod.Dusts
{
    public class Blood2Dust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.velocity *= 0.22f;
            dust.noLight = false;
        }
        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;
            dust.velocity.Y += 0.03f;
            dust.rotation += 0.11f;
            dust.scale *= 0.99f;
            if (Main.rand.Next(14) == 0)
            {
                dust.frame.Y += 10;
            }
            if (dust.frame.Y > 20)
            {
                dust.frame.Y = 0;
            }
            if (dust.scale < 0.22f)
            {
                dust.active = false;
            }
            return false;
        }
    }
}