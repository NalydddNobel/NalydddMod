using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials.Expert
{
    public class SolarBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Solar Bar");
            Tooltip.SetDefault("As hot as the sun");

        }

        public override void SetDefaults()
        {


            item.width = 30;
            item.height = 24;
            item.value = 1000;
            item.maxStack = 999;
            item.rare = ItemRarityID.Expert;
            item.expertOnly = true;
            item.expert = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            ItemID.Sets.ItemIconPulse[item.type] = true;
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentSolar, 5);
            recipe.AddIngredient(ItemID.ShinyStone, 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}




