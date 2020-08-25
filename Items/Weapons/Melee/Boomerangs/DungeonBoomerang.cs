using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Melee.Boomerangs
{
    public class DungeonBoomerang : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("bu məˌræŋ");
        }
        public override void SetDefaults()
        {
            item.damage = 18;
            item.melee = true;
            item.noMelee = true;
            item.width = 20;
            item.height = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 21;
            item.useAnimation = 21;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 2;
            item.value = 1;
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.noUseGraphic = true;
            item.shootSpeed = 6;
            item.shoot = mod.ProjectileType("DungeonBoomerangProjectile");
        }
    }
}