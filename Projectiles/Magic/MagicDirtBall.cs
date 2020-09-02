using Terraria;
using Terraria.ModLoader;
namespace nalydmod.Projectiles.Magic
{
    public class MagicDirtBall : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 32;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.magic = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.timeLeft = 150;
        }
        public override void AI()
        {
            projectile.ai[0]++;
            if (Main.rand.Next(7) == 0)
            {
                int dust = Dust.NewDust(projectile.position, projectile.width - 30, projectile.height - 345, 14);
                int dust2 = Dust.NewDust(projectile.position, projectile.width - 30, projectile.height - 345, 125);
                Main.dust[dust].velocity /= 120f;
                Main.dust[dust2].velocity /= 60f;
                Main.dust[dust].scale = 0.8f;
                Main.dust[dust2].scale = 1.2f;
                Main.dust[dust].alpha = 130;
                Main.dust[dust2].alpha = 100;
                Main.dust[dust].noGravity = false;
                Main.dust[dust2].noGravity = false;
            }
            projectile.rotation = projectile.ai[0] * 0.1f;
        }
    }
}