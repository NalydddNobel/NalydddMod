using nalydmod.Projectiles.Melee.Projectile;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Melee.Swords
{
    public class DesertClaw : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("About as useless as the scimitar.");
        }
        public override void SetDefaults()
        {
            item.damage = 21;
            item.melee = true;
            item.width = 24;
            item.height = 36;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 1.55f;
            item.value = 4000;
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.shoot = ModContent.ProjectileType<SandPebble>();
            item.shootSpeed = 9;
        }
    }
}