using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Placeables.Blocks
{
    public class Fractalite : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fractalite");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 22;
            item.maxStack = 999;
            item.rare = ItemRarityID.Blue;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = mod.TileType("FractaliteTile");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(this);
            recipe.AddIngredient(ItemID.StoneBlock);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(mod.ItemType("FractaliteBrick"));
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(mod.ItemType("FractaliteBar"));
            recipe.AddRecipe();

        }
    }
}




