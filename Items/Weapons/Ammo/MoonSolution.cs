using nalydmod.Projectiles;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
namespace nalydmod.Items.Weapons.Ammo
{
    public class MoonSolution : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Midnight Solution");
            Tooltip.SetDefault("Used by the Clentaminator\nSpreads the Lunar Infection");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.GreenSolution);
            item.shoot = ProjectileType<MoonSolutionProjectile>() - ProjectileID.PureSpray;
            item.rare = 9;
        }
    }
}