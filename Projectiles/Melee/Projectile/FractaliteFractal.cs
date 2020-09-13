using nalydmod.Dusts;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Projectiles.Melee.Projectile
{
    public class FractaliteFractal : ModProjectile
    {
        public override string Texture => "Terraria/Projectile_" + ProjectileID.ShadowBeamFriendly;
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.AmethystBolt);
            projectile.damage = 24;
            projectile.melee = true;
            projectile.magic = true;
        }
        public override void AI()
        {
            Dust.NewDust(projectile.position, projectile.width, projectile.height, ModContent.DustType<DeadlyFlameDust2>(), projectile.velocity.X * 0.4f, projectile.velocity.Y * 0.4f, 100, default, 0.88f);
            Dust.NewDust(projectile.position, projectile.width, projectile.height, ModContent.DustType<DeadlyFlameDust2>(), projectile.velocity.X * 0.4f, projectile.velocity.Y * 0.4f, 100, default, 1f);
            if (Main.rand.Next(2) == 0)
            {
                Dust.NewDust(projectile.position, projectile.width, projectile.height, ModContent.DustType<DeadlyFlameDust2>(), projectile.velocity.X * 0.4f, projectile.velocity.Y * 0.4f, 100, default, 1.22f);
            }
            if (Main.rand.Next(6) == 0)
            {
                Dust.NewDust(projectile.position, projectile.width, projectile.height, ModContent.DustType<DeadlyFlameDust>(), projectile.velocity.X * 0.4f, projectile.velocity.Y * 0.4f, 100, default, 1.22f);
            }
            Lighting.AddLight((int)(projectile.position.X / 16f), (int)(projectile.position.Y / 16f), 0, 0.55f, 0.75f);
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(3) == 0)
            {
                target.AddBuff(mod.BuffType("DeadlyFlamesDeBuff"), 60);
            }
        }
        public override void Kill(int timeLeft)
        {
            Dust.NewDust(projectile.position, projectile.width, projectile.height, ModContent.DustType<DeadlyFlameDust2>(), projectile.velocity.X * 1.2f, projectile.velocity.Y * 1.2f, 100, default, 0.88f);
            Dust.NewDust(projectile.position, projectile.width, projectile.height, ModContent.DustType<DeadlyFlameDust2>(), projectile.velocity.X, projectile.velocity.Y, 100, default, 1f);
            Dust.NewDust(projectile.position, projectile.width, projectile.height, ModContent.DustType<DeadlyFlameDust2>(), projectile.velocity.X * -1.2f, projectile.velocity.Y * -1.2f, 100, default, 0.88f);
            Dust.NewDust(projectile.position, projectile.width, projectile.height, ModContent.DustType<DeadlyFlameDust2>(), -projectile.velocity.X, -projectile.velocity.Y, 100, default, 1f);
            Dust.NewDust(projectile.position, projectile.width, projectile.height, ModContent.DustType<DeadlyFlameDust2>(), projectile.velocity.X * 0.4f, projectile.velocity.Y * 0.4f, 100, default, 1.22f);
            Dust.NewDust(projectile.position, projectile.width, projectile.height, ModContent.DustType<DeadlyFlameDust>(), projectile.velocity.X * 0.4f, projectile.velocity.Y * 0.4f, 100, default, 1.22f);
            Dust.NewDust(projectile.position, projectile.width, projectile.height, ModContent.DustType<DeadlyFlameDust>(), projectile.velocity.X * 0.4f, projectile.velocity.Y * 0.4f, 100, default, 1.22f);
            Dust.NewDust(projectile.position, projectile.width, projectile.height, ModContent.DustType<DeadlyFlameDust>(), projectile.velocity.X * 0.4f, projectile.velocity.Y * 0.4f, 100, default, 1.45f);
        }
    }
}
