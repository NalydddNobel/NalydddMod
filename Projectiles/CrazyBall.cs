using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Projectiles
{
    public class CrazyBall : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 24;
            projectile.height = 24;
            projectile.friendly = true;
            projectile.penetrate = 2;
            projectile.hostile = false;
            projectile.magic = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.timeLeft = 45;
        }

        public override void AI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Shadowflame);
            int dust2 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Shadowflame);
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
        public override void Kill(int timeLeft)
        {
            int RandomTome = Main.rand.Next(1, 1); ;

            if (RandomTome == 1)
            {

            }
        }
    }
}