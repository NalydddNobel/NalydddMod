using IL.Terraria;
using Terraria.ModLoader;


namespace nalydmod.Projectiles
{
    public class harpyarrow : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "harpyarrow";
            projectile.width = 24;
            projectile.height = 48;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.penetrate = 3;
            projectile.timeLeft = 400;
            projectile.light = 0;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)System.Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }
    }
}
