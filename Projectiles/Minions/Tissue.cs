using Terraria.ModLoader;

namespace nalydmod.Projectiles.Minions
{
    public abstract class Tissue : ModProjectile
    {
        public override void AI()
        {
            CheckActive();
            Behavior();
        }

        public abstract void CheckActive();

        public abstract void Behavior();
    }
}