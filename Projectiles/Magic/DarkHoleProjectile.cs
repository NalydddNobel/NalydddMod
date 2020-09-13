using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Projectiles.Magic
{
    public class DarkHoleProjectile : ModProjectile
    {
        public override string Texture => "Terraria/Projectile_" + ProjectileID.None;
        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.magic = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
        }
        public override void AI()
        {
            for (int i = 0; i < 200; i++)
            {
                NPC target = Main.npc[i];
                if (!target.dontTakeDamage)
                {
                    float shootToX = target.position.X + target.width * 0.5f - projectile.Center.X;
                    float shootToY = target.position.Y - projectile.Center.Y;
                    float distance = (float)Math.Sqrt((shootToX * shootToX + shootToY * shootToY));
                    if (distance < 480f && !target.friendly && target.active)
                    {
                        distance = 3f / distance;
                        shootToX *= distance * 4;
                        shootToY *= distance * 4;
                        projectile.velocity.X = shootToX;
                        projectile.velocity.Y = shootToY;
                        projectile.localAI[1]--;
                        projectile.localAI[1]--;

                    }
                }
            }
            projectile.localAI[0]++;
            projectile.localAI[1]++;
            if (projectile.localAI[1] < 60)
            {
                if (projectile.localAI[0] >= 1)
                {
                    int projectile2 = Projectile.NewProjectile(projectile.Center, projectile.velocity * 0, mod.ProjectileType("DarkHoleWorm"), projectile.damage, projectile.knockBack, Main.myPlayer);
                    Main.projectile[projectile2].rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
                    Main.projectile[projectile2].alpha = 50;
                    Main.projectile[projectile2].ai[0] = 5;
                    projectile.localAI[0] = 0;
                }
                if (projectile.velocity.Y > 20)
                {
                    projectile.velocity.Y = 20;
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