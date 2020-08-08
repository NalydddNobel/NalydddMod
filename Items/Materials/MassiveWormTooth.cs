using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials
{
    public class MassiveWormTooth : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eater of World's Tooth");
        }

        public override void SetDefaults()
        {


            item.width = 32;
            item.height = 32;
            item.value = 2000;
            item.maxStack = 999;
            item.rare = ItemRarityID.LightPurple;
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WormTooth, 25);
            recipe.AddIngredient(ItemID.ShadowScale, 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(mod);            
            recipe.AddIngredient(mod.ItemType("MassiveWormTooth"), 1);
            recipe.AddIngredient(ItemID.ShadowScale, 1);
            recipe.AddIngredient(ItemID.WoodenArrow, 500);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(itemID: ItemID.UnholyArrow, 500);
            recipe.AddRecipe();
        }        
    }
}




