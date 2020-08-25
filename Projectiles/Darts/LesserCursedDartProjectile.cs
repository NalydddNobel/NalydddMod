using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Projectiles.Darts
{
    public class LesserCursedDartProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 12;
            projectile.height = 12;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.tileCollide = true;
            projectile.timeLeft = 1000;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
            projectile.aiStyle = 1;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(2) == 0)
            {
                target.AddBuff(BuffID.CursedInferno, 30);
            }
            if (Main.rand.Next(4) == 0)
            {
                target.AddBuff(BuffID.CursedInferno, 300);
            }
        }
    }
}