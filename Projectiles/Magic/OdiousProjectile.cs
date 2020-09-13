using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Projectiles.Magic
{
    public class OdiousProjectile : ModProjectile
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
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
        }
        public override void AI()
        {
            projectile.localAI[0]++;
            projectile.localAI[1]++;
            if (projectile.localAI[1] < 30)
            {
                if (projectile.localAI[0] == 2)
                {
                    int projectile2 = Projectile.NewProjectile(projectile.Center, projectile.velocity * 0, mod.ProjectileType("OdiousThorn1"), projectile.damage, projectile.knockBack, Main.myPlayer);
                    Main.projectile[projectile2].rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
                    projectile.localAI[0] = 0;
                }
            }
            else
            {
                int projectile2 = Projectile.NewProjectile(projectile.Center, projectile.velocity * 0, mod.ProjectileType("OdiousThorn2"), projectile.damage, projectile.knockBack, Main.myPlayer);
                Main.projectile[projectile2].rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
                projectile.active = false;
            }
        }
    }
}