using Terraria;
using Terraria.ID;

namespace nalydmod.Projectiles.Minions
{
    public class HungryMaggot : MaggotINFO
    {
        public override void SetDefaults()
        {
            projectile.netImportant = true;
            projectile.width = 12;
            projectile.height = 12;
            Main.projFrames[projectile.type] = 3;
            projectile.friendly = true;
            Main.projPet[projectile.type] = true;
            projectile.minion = true;
            projectile.netImportant = true;
            projectile.minionSlots = 0.75f;
            projectile.penetrate = 1;
            projectile.timeLeft = 18000;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
            ProjectileID.Sets.Homing[projectile.type] = true;
            inertia = 30f;
            shoot = mod.ProjectileType("BloodShot");
            shootSpeed = 8f;
            ProjectileID.Sets.LightPet[projectile.type] = true;
            Main.projPet[projectile.type] = true;
        }
        public override void CheckActive()
        {
            Player player = Main.player[projectile.owner];
            MyPlayer modPlayer = (MyPlayer)player.GetModPlayer(mod, "MyPlayer");
            if (player.dead)
            {
                modPlayer.hungryMaggot = false;
            }
            if (modPlayer.hungryMaggot)
            {
                projectile.timeLeft = 2;
            }
        }

        public override void CreateDust()
        {
            Lighting.AddLight((int)(projectile.Center.X / 16f), (int)(projectile.Center.Y / 16f), 0.6f, 0.9f, 0.3f);
        }

        public override void SelectFrame()
        {
            projectile.frameCounter++;
            if (projectile.frameCounter >= 8)
            {
                projectile.frameCounter = 0;
                projectile.frame = (projectile.frame + 1) % 3;
            }
        }
    }
}