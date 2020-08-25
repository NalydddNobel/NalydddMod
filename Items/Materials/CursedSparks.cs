using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials
{
    public class CursedSparks : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cursed Sparks");
            Tooltip.SetDefault("Might start a permament fire.");

        }
        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 20;
            item.value = 500;
            item.maxStack = 999;
            item.rare = ItemRarityID.White;
            Terraria.Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 3));
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EbonstoneBlock, 5);
            recipe.AddIngredient(ItemID.Lens, 1);
            recipe.AddTile(TileID.SkullLanterns);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}




