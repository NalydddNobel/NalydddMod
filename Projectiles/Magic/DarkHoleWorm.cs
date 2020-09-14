using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Projectiles.Magic
{
    public class DarkHoleWorm : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.magic = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            Main.projFrames[projectile.type] = 3;
        }
        public override void AI()
        {
            projectile.localAI[0]++;
            projectile.alpha += (int)projectile.localAI[0] / 2;
            if (projectile.alpha > 100)
            {
                projectile.active = false;
            }
            if (projectile.ai[0] == 5)
            {
                projectile.frame = 0;
            }
            else if (projectile.ai[0] == 0)
            {
                projectile.frame = 2;
            }
            else
            {
                projectile.frame = 1;
            }
            projectile.ai[0]--;
        }
    }
}