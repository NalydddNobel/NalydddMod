using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials
{
    public class Susblueflower : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Flower");
            Tooltip.SetDefault("Looks like its magical.");
        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 2000;
            item.maxStack = 999;
            item.rare = ItemRarityID.Blue;
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.JungleSpores, 2);
            recipe.AddIngredient(ItemID.VineRope, 25);
            recipe.AddTile(TileID.BloomingHerbs);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Susblueflower"), 25);
            recipe.AddIngredient(ItemID.ManaCrystal, 1);
            recipe.AddIngredient(ItemID.ManaPotion, 4);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(itemID: ItemID.NaturesGift);
            recipe.AddRecipe();
        }
    }
}




