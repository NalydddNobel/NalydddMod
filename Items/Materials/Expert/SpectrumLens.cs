using IL.Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials.Expert
{
    public class SpectrumLens : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectrum Eyes");
            Tooltip.SetDefault("Wants to spread the Hallow.");

        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 40;
            item.value = 20000;
            item.maxStack = 999;
            item.rare = ItemRarityID.Expert;
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




