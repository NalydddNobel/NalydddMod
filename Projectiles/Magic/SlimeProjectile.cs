using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Projectiles.Magic
{
    public class SlimeProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 48;
            projectile.height = 48;
            projectile.friendly = true;
            projectile.penetrate = 2;
            Main.projFrames[projectile.type] = 4;
            projectile.hostile = false;
            projectile.magic = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.timeLeft = 45;
        }
        public override void AI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.t_Slime);
            int dust2 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.t_Slime);
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
            projectile.alpha = (int)projectile.localAI[0] * 4;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Slimed, 510);
        }
        public override bool PreDraw(SpriteBatch sb, Color lightColor)
        {
            projectile.frameCounter++;
            if (projectile.frameCounter >= 5)
            {
                projectile.frame++;
                projectile.frameCounter = 0;
                if (projectile.frame > 3)
                    projectile.frame = 0;
            }
            return true;
        }
    }
}