using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Projectiles.Magic
{
    public class OdiousThorn1 : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.penetrate = 100;
            projectile.hostile = false;
            projectile.magic = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
        }
        public override void AI()
        {
            projectile.localAI[0]++;
            projectile.alpha += (int)projectile.localAI[0] / 2;
            if (projectile.alpha > 100)
            {
                projectile.active = false;
            }
        }
    }
}