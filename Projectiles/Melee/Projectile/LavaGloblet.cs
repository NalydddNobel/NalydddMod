using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Projectiles.Melee.Projectile
{
    public class LavaGloblet : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.damage = 9;
            projectile.width = 6;
            projectile.height = 6;
            projectile.aiStyle = -1;
            projectile.friendly = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
            projectile.melee = true;
            projectile.light = 1.2f;
        }
        public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Dig, (int)projectile.position.X, (int)projectile.position.Y, 1, 1, 0f);
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("LavaSparkle"));
            int dust2 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Fire);
            Main.dust[dust].velocity /= 120f;
            Main.dust[dust2].velocity /= 60f;
            Main.dust[dust].scale = 0.8f;
            Main.dust[dust2].scale = 1.2f;
            Main.dust[dust].alpha = 130;
            Main.dust[dust2].alpha = 100;
            projectile.alpha = (int)projectile.localAI[0] * 2;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(2) == 0)
            {
                target.AddBuff(BuffID.OnFire, 300);
            }
        }
        public override void AI()
        {
            projectile.ai[1]++;
            if (Main.rand.Next(6) == 0)
            {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("LavaSparkle"));
                int dust2 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Fire);
                Main.dust[dust].velocity /= 120f;
                Main.dust[dust2].velocity /= 60f;
                Main.dust[dust].scale = 1.2f;
                Main.dust[dust2].scale = 0.9f;
                Main.dust[dust].alpha -= (int)projectile.ai[0]++ * 2;
                Main.dust[dust2].alpha -= (int)projectile.ai[0]++ * 2;
            }
            if (projectile.velocity.X > 0)
            {
                projectile.velocity.X += 0.01f * projectile.ai[1];
            }
            if (projectile.velocity.X < 0)
            {
                projectile.velocity.X -= 0.01f * projectile.ai[1];
            }
            projectile.scale -= 0.0002f * projectile.ai[1];
            projectile.velocity.Y += projectile.ai[1] * 0.1f;
            if (projectile.scale <= 0.01)
            {
                projectile.damage = 0;
                projectile.tileCollide = false;
                projectile.scale = 0.01f;
                projectile.ai[0]++;
            }
            if (projectile.ai[0] == 60)
            {
                projectile.active = false;
            }
            if (projectile.velocity.Y >= 4.5f)
            {
                projectile.velocity.Y = 4.5f;
            }
        }
    }
}