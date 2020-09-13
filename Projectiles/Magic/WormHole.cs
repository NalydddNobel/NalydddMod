using Terraria;
using Terraria.ModLoader;
namespace nalydmod.Projectiles.Magic
{
    public class WormHole : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 50;
            projectile.height = 50;
            projectile.velocity *= 0;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            Main.projFrames[projectile.type] = 6;
        }
        public override void AI()
        {
            projectile.localAI[0]++;
            if (projectile.localAI[0] >= 8)
            {
                projectile.frame++;
                projectile.localAI[0] = 0;
            }
            if (projectile.frame > 5)
            {
                projectile.frame = 0;
            }
            projectile.alpha += 3;
            if (projectile.alpha == 255)
            {
                projectile.active = false;
            }
        }
    }
}