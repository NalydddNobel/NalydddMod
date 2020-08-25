using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials.GemFragments
{
    public class EmeraldFragment : ModItem
    {
        public override string Texture => "nalydmod/Items/Materials/GemFragments/BasicFragment";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Emerald Fragment");
            Tooltip.SetDefault("Drops from Emerald Creatures");
        }
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 10;
            item.maxStack = 999;
            item.alpha = 189;
            item.color = Color.Green;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            ItemID.Sets.ItemIconPulse[item.type] = true;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.Green;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("EmeraldFragment"), 8);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(itemID: ItemID.Emerald);
            recipe.AddRecipe();
        }
    }
}




