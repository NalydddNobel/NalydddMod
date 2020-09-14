using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Accessories.Summon.Small
{
    public class DirtBall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chocolate Bar");
            Tooltip.SetDefault("Increases max number of small minions by 1.\nDon't eat it.");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = 20000;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<MyPlayer>().maxSmallSummon++;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 15);
            recipe.AddIngredient(ItemID.Gel, 6);
            recipe.needWater = true;
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MudBlock, 15);
            recipe.AddIngredient(ItemID.Gel, 3);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}