using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials
{
    public class GoblinPowder : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Goblin Powder");
            Tooltip.SetDefault("Don't sniff it.");
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 20;
            item.value = 200;
            item.maxStack = 999;
            item.rare = ItemRarityID.White;
            Terraria.Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(40, 3));
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EbonstoneBlock, 5);
            recipe.AddIngredient(ItemID.SpikyBall, 1);
            recipe.AddTile(TileID.SkullLanterns);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}




