using nalydmod.Items.Placeables.Blocks.Ore;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Placeables.Bars
{
    public class FractaliteBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Feels like it has infinite magical potential");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.rare = ItemRarityID.Blue;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = mod.TileType("FractaliteBarTile");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Fractalite>(), 3);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}