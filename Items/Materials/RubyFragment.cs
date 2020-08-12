using IL.Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using On.Terraria;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials
{
    public class RubyFragment : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ruby Fragment");           
        }
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 10;            
            item.maxStack = 999;
            Terraria.Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 8));

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("RubyFragment"), 10);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(itemID: ItemID.Ruby);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("RubyFragment"), 2);
            recipe.AddIngredient(ItemID.GoldBar, 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(mod.ItemType("RoyalGel"));
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("RubyFragment"), 2);
            recipe.AddIngredient(ItemID.PlatinumBar, 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(mod.ItemType("RoyalGel"));
        }
    }
}




