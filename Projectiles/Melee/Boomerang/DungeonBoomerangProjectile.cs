using System;
using Terraria;
using Terraria.ModLoader;

namespace nalydmod.Projectiles.Melee.Boomerang
{
    public class DungeonBoomerangProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 32;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.penetrate = 3;
            projectile.timeLeft = 600;
            projectile.light = 0.5f;
            projectile.extraUpdates = 1;
        }
        public override void AI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 15);
            int dust2 = Dust.NewDust(projectile.position, projectile.width, projectile.height, 15);
            Main.dust[dust].velocity /= 120f;
            Main.dust[dust2].velocity /= 60f;
            Main.dust[dust].scale = (Main.rand.NextFloat(0, 0.5f));
            Main.dust[dust2].scale = (Main.rand.NextFloat(0, 0.9f));
            Main.dust[dust].alpha = 130;
            Main.dust[dust2].alpha = 100;
            projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X);
            projectile.localAI[0] += 1f;
        }

    }
}