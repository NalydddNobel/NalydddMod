using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert
{
    public class SpectrumLens : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectrum Eyes");
            Tooltip.SetDefault("Wants to spread the Hallow.\nExpert");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 40;
            item.value = 20000;
            item.maxStack = 999;
            item.rare = ItemRarityID.Blue;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SpectrumLens"), 2);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(itemID: ItemID.HallowedSeeds);
            recipe.AddRecipe();
        }
    }
}