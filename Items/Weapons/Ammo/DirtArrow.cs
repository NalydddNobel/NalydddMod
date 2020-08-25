using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Ammo
{
    public class DirtArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dirt Arrow");
            Tooltip.SetDefault("May poision enemies.");
        }

        public override void SetDefaults()
        {
            item.damage = 3;
            item.ranged = true;
            item.width = 12;
            item.height = 24;
            item.maxStack = 999;
            item.consumable = true;
            item.value = 125;
            item.rare = ItemRarityID.White;
            item.shoot = mod.ProjectileType("DirtArrow");
            item.shootSpeed = 5;
            item.ammo = AmmoID.Arrow;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 20);
            recipe.AddRecipe();
        }


    }
}




