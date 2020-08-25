using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials
{
    public class LifeFragment : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Life Fragment");
        }
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 10;
            item.maxStack = 999;
            item.value = 1000;
            item.rare = ItemRarityID.Green;
            Terraria.Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 8));

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("LifeFragment"), 10);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(itemID: ItemID.LifeCrystal);
            recipe.AddRecipe();
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
    }
}




