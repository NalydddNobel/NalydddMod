using Terraria.ModLoader;


namespace nalydmod.Projectiles
{
    public class uharpyarrowp : ModProjectile
    {


        public override void SetDefaults()
        {
            projectile.Name = "ultimateharpyarrow";
            projectile.width = 24;
            projectile.height = 48;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.penetrate = 25;
            projectile.timeLeft = 400;
            projectile.light = 1;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)System.Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
        }
    }
}
