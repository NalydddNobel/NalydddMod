using IL.Terraria;
using IL.Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;

namespace nalydmod.Items.Materials
{
    public class RoyalGel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Royal Gel");           
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;            
            item.maxStack = 999;          
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("RoyalGel"), 1);
            recipe.AddIngredient(ItemID.PinkGel, 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(itemID: ItemID.Gel, 50);
            recipe.AddRecipe();
        }
    }
}




