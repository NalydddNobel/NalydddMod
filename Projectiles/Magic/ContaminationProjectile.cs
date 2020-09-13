using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Projectiles.Magic
{
    public class ContaminationProjectile : ModProjectile
    {
        public override string Texture => "Terraria/Projectile_" + ProjectileID.None;
        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.penetrate = 100;
            projectile.hostile = false;
            projectile.magic = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
        }
        public override void AI()
        {
            projectile.localAI[0]++;
            projectile.localAI[1]++;
            if (projectile.localAI[1] < 60)
            {
                if (projectile.localAI[0] >= 1)
                {
                    int projectile2 = Projectile.NewProjectile(projectile.Center, projectile.velocity * 0, mod.ProjectileType("ContaminationWorm"), projectile.damage, projectile.knockBack, Main.myPlayer);
                    Main.projectile[projectile2].rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
                    Main.projectile[projectile2].alpha = 50;
                    Main.projectile[projectile2].ai[0] = 13;
                    projectile.localAI[0] = 0;
                }
                projectile.velocity.Y += projectile.localAI[1] / 16;
                projectile.velocity.X /= 1.015f;
                if (projectile.velocity.Y > 20)
                {
                    projectile.velocity.Y = 20;
                }
                if (projectile.velocity.X == 0)
                {
                    projectile.velocity.X = 0;
                }
            }
            else
            {
                Projectile.NewProjectile(projectile.Center, projectile.velocity * 0, mod.ProjectileType("WormHole"), projectile.damage, 0, Main.myPlayer);
                projectile.active = false;
            }
        }
        public override void Kill(int timeLeft)
        {
            {
                Projectile.NewProjectile(projectile.Center, projectile.velocity * 0, mod.ProjectileType("WormHole"), projectile.damage, 0, Main.myPlayer);
            }
        }
    }
}