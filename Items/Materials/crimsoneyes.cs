using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

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
            item.value = 20000;
            item.maxStack = 999;
            item.rare = ItemRarityID.LightRed;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimstoneBlock, 5);
            recipe.AddIngredient(ItemID.Lens, 1);
            recipe.AddTile(TileID.SkullLanterns);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("crimsoneyes"), 2);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(itemID: ItemID.CrimsonSeeds);
            recipe.AddRecipe();
        }
    }
}




