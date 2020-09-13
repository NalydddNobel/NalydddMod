using Terraria;
using Terraria.ModLoader;
namespace nalydmod.Projectiles.Magic
{
    public class DarkHole : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 50;
            projectile.height = 50;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            Main.projFrames[projectile.type] = 6;
        }
        public override void AI()
        {
            projectile.localAI[0]++;
            projectile.localAI[1]++;
            if (projectile.localAI[0] >= 8)
            {
                projectile.frame++;
                projectile.localAI[0] = 0;
            }
            if (projectile.frame > 5)
            {
                projectile.frame = 0;
            }
            projectile.alpha += 8;
            if (projectile.alpha >= 255)
            {
                projectile.active = false;
            }
            if (projectile.localAI[1] >= 13)
            {
                int projectile2 = Projectile.NewProjectile(projectile.Center, projectile.velocity * 1.44f, mod.ProjectileType("DarkHoleProjectile"), projectile.damage, projectile.knockBack, Main.myPlayer);
                Main.projectile[projectile2].velocity.Y += Main.rand.NextFloat(2, -2);
                Main.projectile[projectile2].velocity.X += Main.rand.NextFloat(2, -2);
                projectile.localAI[1] = 0;
            }
        }
    }
}