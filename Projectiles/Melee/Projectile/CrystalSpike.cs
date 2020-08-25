using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Projectiles.Melee.Projectile
{
    public class CrystalSpike : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.damage = 14;
            projectile.width = 30;
            projectile.height = 30;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.hostile = false;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.timeLeft = 50;
        }
        public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Dig, (int)projectile.position.X, (int)projectile.position.Y, 1, 1, 0f);
        }
        public override void AI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.SomethingRed);
            int dust2 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.SomethingRed);
            Main.dust[dust].velocity /= 120f;
            Main.dust[dust2].velocity /= 60f;
            Main.dust[dust].scale = 0.5f;
            Main.dust[dust2].scale = 0.75f;
            Main.dust[dust].color.B = 255;
            Main.dust[dust2].color.B = 155;
            Main.dust[dust].alpha = 130;
            Main.dust[dust2].alpha = 100;
            projectile.alpha = (int)projectile.localAI[0] * 2;
        }
    }
}