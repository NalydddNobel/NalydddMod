using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials.GemFragments
{
    public class RubyFragment : ModItem
    {
        public override string Texture => "nalydmod/Items/Materials/GemFragments/BasicFragment";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ruby Fragment");
            Tooltip.SetDefault("Drops from Ruby Creatures");
        }
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 10;
            item.maxStack = 999;
            item.alpha = 189;
            item.color = Color.Red;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            ItemID.Sets.ItemIconPulse[item.type] = true;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.Red;
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




