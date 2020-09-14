using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Projectiles.Melee.Projectile
{
    public class SandPebble : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 12;
            projectile.height = 12;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.timeLeft = 33;
        }
        public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Dig, (int)projectile.position.X, (int)projectile.position.Y, 1, 1, 0f);
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Dirt, 
            (projectile.velocity.X * 0.66f) + (Main.rand.Next(-10, 10) * 0.1f), 
            (projectile.velocity.Y * 0.66f) + (Main.rand.Next(-10, 10) * 0.1f));
            int dust2 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Sandstorm,
            (projectile.velocity.X * 0.66f) + (Main.rand.Next(-10, 10) * 0.1f),
            (projectile.velocity.Y * 0.66f) + (Main.rand.Next(-10, 10) * 0.1f));
            int dust3 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Sandstorm,
            (projectile.velocity.X * 0.66f) + (Main.rand.Next(-10, 10) * 0.1f),
            (projectile.velocity.Y * 0.66f) + (Main.rand.Next(-10, 10) * 0.1f));
            int dust4 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Sandstorm,
            (projectile.velocity.X * 0.66f) + (Main.rand.Next(-10, 10) * 0.1f),
            (projectile.velocity.Y * 0.66f) + (Main.rand.Next(-10, 10) * 0.1f));
            Main.dust[dust].scale = Main.rand.Next(3, 10) * 0.1f;
            Main.dust[dust2].scale = Main.rand.Next(5, 14) * 0.1f;
            Main.dust[dust3].scale = Main.rand.Next(7, 14) * 0.1f;
            Main.dust[dust4].scale = Main.rand.Next(8, 16) * 0.1f;
        }
        public override void AI()
        {
            projectile.rotation += 0.22f;
            projectile.velocity.Y += 0.2f;
            projectile.scale -= 0.02f;
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Sandstorm, projectile.velocity.X * 0.22f, projectile.velocity.Y * 0.22f);
            Main.dust[dust].scale = Main.rand.Next(3, 10) * 0.1f;
        }       
    }
}