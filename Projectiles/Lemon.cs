using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Projectiles
{
    public class Lemon : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 12;
            projectile.height = 24;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.tileCollide = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 150;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
            projectile.aiStyle = 1;
        }
        public override void AI()
        {
            if (projectile.timeLeft == 149)
            {
                Main.PlaySound(SoundID.Item1, projectile.position);
            }
        }
    }
}
