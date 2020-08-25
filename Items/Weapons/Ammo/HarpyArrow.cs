using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Ammo
{
    public class Harpyarrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("HarpyArrow");
            Tooltip.SetDefault("Aerodynamic and razor sharp. Also hates the ground, these arrows get easily destroyed by most ground tiles.");
        }

        public override void SetDefaults()
        {

            item.damage = 10;
            item.ranged = true;
            item.width = 24;
            item.height = 48;
            item.useTime = 12;
            item.maxStack = 999;
            item.consumable = true;
            item.value = 125;
            item.rare = ItemRarityID.White;
            item.shoot = mod.ProjectileType("harpyarrow");
            item.shootSpeed = 25;
            item.ammo = AmmoID.Arrow;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cloud, 1);
            recipe.AddIngredient(ItemID.Feather, 5);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this, 200);
            recipe.AddRecipe();
        }


    }
}




