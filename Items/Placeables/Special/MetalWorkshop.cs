using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Placeables.Special
{
    public class MetalWorkshop : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Used to combine powerful accessories.");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.TinkerersWorkshop);
            item.createTile = mod.TileType("MetalWorkshopTile");
            item.rare = ItemRarityID.Pink;
            item.value = 500000;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TinkerersWorkshop);
            recipe.AddIngredient(ItemID.SoulofSight);
            recipe.AddIngredient(ItemID.SoulofMight);
            recipe.AddIngredient(ItemID.SoulofFright);
            recipe.AddIngredient(ItemID.HallowedBar, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}