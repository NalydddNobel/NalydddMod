using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Projectiles
{
    public class DirtArrow : ModProjectile
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
        }
        public override void AI()
        {
            projectile.rotation = (float)System.Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(3) == 0)
            {
                target.AddBuff(BuffID.Poisoned, 220);
            }
        }
    }
}
