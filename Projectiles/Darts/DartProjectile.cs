using Terraria.ModLoader;
namespace nalydmod.Projectiles.Darts
{
    public class DartProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 12;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.tileCollide = true;
            projectile.timeLeft = 1000;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
            projectile.aiStyle = 1;
        }
    }
}