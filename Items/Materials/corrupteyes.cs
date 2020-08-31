using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Materials
{
    public class corrupteyes : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Faded Lens");
            Tooltip.SetDefault("Wants to spread the Corruption.");
        }
        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.value = 1000;
            item.maxStack = 999;
            item.rare = 0;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("corrupteyes"), 2);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(itemID: ItemID.CorruptSeeds);
            recipe.AddRecipe();
        }
    }
}