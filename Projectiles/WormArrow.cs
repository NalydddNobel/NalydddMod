using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Projectiles
{
    public class WormArrow : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.tileCollide = false;
            projectile.penetrate = 4;
            projectile.timeLeft = 80;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)System.Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(2) == 0)
            {
                target.AddBuff(BuffID.Poisoned, 40);
            }
            if (Main.rand.Next(2) == 0)
            {
                target.AddBuff(BuffID.Slimed, 80);
            }
            if (Main.rand.Next(2) == 0)
            {
                target.AddBuff(BuffID.Stinky, 120);
            }
        }
    }
}
