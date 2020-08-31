using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Projectiles.Melee.Projectile
{
    public class LavaGlob : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.damage = 30;
            projectile.width = 25;
            projectile.height = 25;
            projectile.scale = 1.5f;
            projectile.aiStyle = -1;
            projectile.friendly = true;
            projectile.penetrate = 2;
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
            Main.dust[dust].scale = 2.3f;
            Main.dust[dust2].scale = 3f;
            Main.dust[dust].alpha = 130;
            Main.dust[dust2].alpha = 100;
            projectile.alpha = (int)projectile.localAI[0] * 2;
            int projectile2 = Terraria.Projectile.NewProjectile(projectile.Top, projectile.velocity * 2, mod.ProjectileType("LavaGloblet"), 5, 0, Main.myPlayer);
            Main.projectile[projectile2].velocity.Y -= Main.rand.Next(1, 3) * -0.1f;
            Main.projectile[projectile2].velocity.X -= Main.rand.Next(-3, 3) * 0.1f;
            int projectile3 = Terraria.Projectile.NewProjectile(projectile.Top, projectile.velocity * 2, mod.ProjectileType("LavaGloblet"), 5, 0, Main.myPlayer);
            Main.projectile[projectile3].velocity.Y *= Main.rand.Next(-3, 3) * -0.1f;
            Main.projectile[projectile3].velocity.X *= Main.rand.Next(-3, 3) * 0.1f;
            int projectile4 = Terraria.Projectile.NewProjectile(projectile.Top, projectile.velocity * 2, mod.ProjectileType("LavaGloblet"), 5, 0, Main.myPlayer);
            Main.projectile[projectile4].velocity.Y += Main.rand.Next(3, 5) * -0.1f;
            Main.projectile[projectile4].velocity.X += Main.rand.Next(-3, 3) * 0.1f;
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
            if (Main.rand.Next(2) == 0)
            {
                int projectile2 = Terraria.Projectile.NewProjectile(projectile.Top, projectile.velocity * 2, mod.ProjectileType("LavaGloblet"), 5, 0, Main.myPlayer);
                Main.projectile[projectile2].timeLeft = 33;
                Main.projectile[projectile2].velocity.Y -= Main.rand.Next(-15, 15) * 0.1f;
                Main.projectile[projectile2].velocity.X -= Main.rand.Next(-10, 10) * 0.1f;
                int projectile3 = Terraria.Projectile.NewProjectile(projectile.Top, projectile.velocity * 2, mod.ProjectileType("LavaGloblet"), 5, 0, Main.myPlayer);
                Main.projectile[projectile3].timeLeft = 33;
                Main.projectile[projectile3].velocity.Y *= Main.rand.Next(-15, 15) * 0.1f;
                Main.projectile[projectile3].velocity.X *= Main.rand.Next(-10, 10) * 0.1f;
                int projectile4 = Terraria.Projectile.NewProjectile(projectile.Top, projectile.velocity * 2, mod.ProjectileType("LavaGloblet"), 5, 0, Main.myPlayer);
                Main.projectile[projectile4].timeLeft = 33;
                Main.projectile[projectile4].velocity.Y += Main.rand.Next(-15, 15) * 0.1f;
                Main.projectile[projectile4].velocity.X += Main.rand.Next(-10, 10) * 0.1f;
            }           
        }
        public override void AI()
        {
            if (Main.rand.Next(11) == 0)
            {
                projectile.ai[0]++;
            }
            projectile.ai[1]++;
            if (Main.rand.Next(3) == 0)
            {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("LavaSparkle"));
                int dust2 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Fire);
                Main.dust[dust].velocity /= 120f;
                Main.dust[dust2].velocity /= 60f;
                Main.dust[dust].scale = 1.2f;
                Main.dust[dust2].scale = 0.9f;
                Main.dust[dust].alpha = 130;
                Main.dust[dust2].alpha = 100;
                projectile.alpha = (int)projectile.localAI[0] * 2;
            }
            projectile.scale -= 0.0002f * projectile.ai[1];
            projectile.velocity.Y += projectile.ai[1] * 0.01f;
            if (projectile.scale < 0.44)
            {
                projectile.active = false;
            }
        }
    }
}