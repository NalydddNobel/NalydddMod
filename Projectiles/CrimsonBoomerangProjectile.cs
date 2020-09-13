using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Projectiles
{
    public class CrimsonBoomerangProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 16;
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
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Blood);
            int dust2 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Blood);
            Main.dust[dust].velocity /= 120f;
            Main.dust[dust2].velocity /= 60f;
            Main.dust[dust].scale = 0.5f;
            Main.dust[dust2].scale = 0.75f;
            projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {

        }
    }
}