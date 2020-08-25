using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Projectiles.Throwing
{
    public class BloodDagger : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.height = 10;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.ranged = true;
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
            Main.dust[dust].color.B = 255;
            Main.dust[dust2].color.B = 155;
            Main.dust[dust].alpha = 130;
            Main.dust[dust2].alpha = 100;
            projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f;

        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(2) == 0)
            {
                target.AddBuff(BuffID.Slow, 20);
            }
        }
    }
}