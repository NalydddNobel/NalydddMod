using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials
{
    public class Blood3 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Teal Blood Droplet");
            Tooltip.SetDefault("From foreign creatures.");

        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 10;
            item.value = 200;
            item.maxStack = 999;
            item.rare = ItemRarityID.Blue;
            Terraria.Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 3));
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EbonstoneBlock, 1);
            recipe.AddIngredient(ItemID.CrimstoneBlock, 1);
            recipe.AddIngredient(ItemID.SpikyBall, 1);
            recipe.AddTile(TileID.SkullLanterns);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RottenChunk, 5);
            recipe.AddIngredient(mod.ItemType("SoulofCrime"), 5);
            recipe.AddIngredient(mod.ItemType("GoblinPowder"), 20);
            recipe.AddIngredient(mod.ItemType("Blood3"), 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Harpoon);
            recipe.AddRecipe();
        }
    }
}




