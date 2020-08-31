using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Materials
{
    public class crimsoneyes : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bloddied Lens");
            Tooltip.SetDefault("Wants to spread the Crimson.");
        }
        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 20;
            item.value = 1000;
            item.maxStack = 999;
            item.rare = 0;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("crimsoneyes"), 2);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(itemID: ItemID.CrimsonSeeds);
            recipe.AddRecipe();
        }
    }
}