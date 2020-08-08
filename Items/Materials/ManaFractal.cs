using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials
{
    public class ManaFractal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mana Fractal");
            Tooltip.SetDefault("Increases max mana by 40.");

        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 2000;
            item.maxStack = 999;
            item.useTime = 30;
            item.useAnimation = 30;
            item.rare = ItemRarityID.Quest;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.UseSound = (SoundID.Item5);
            item.consumable = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentSolar, 25);
            recipe.AddIngredient(ItemID.FragmentVortex, 25);
            recipe.AddIngredient(ItemID.FragmentNebula, 25);
            recipe.AddIngredient(ItemID.FragmentStardust, 25);
            recipe.AddIngredient(mod.ItemType("Susblueflower"), 100);
            recipe.AddIngredient(ItemID.LunarBar, 15);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }        
    }
}




