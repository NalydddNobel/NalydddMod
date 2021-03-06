using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Materials.GemFragments
{
    public class DiamondFragment : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Diamond Fragment");
        }
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 10;
            item.maxStack = 999;
            item.value = 10000;
            item.rare = ItemRarityID.Blue;
            Terraria.Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 8));
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("DiamondFragment"), 25);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(itemID: ItemID.Diamond);
            recipe.AddRecipe();
        }
    }
}