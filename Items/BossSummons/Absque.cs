using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.BossSummons
{
    public class Absque : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Absque Aequalis");
            Tooltip.SetDefault("Summons Aequus\nNOT ADDED IN YET!!!");
        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.consumable = true;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.maxStack = 20;
            item.rare = ItemRarityID.Lime;
            item.consumable = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("TestItem1"));
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool UseItem(Terraria.Player player)
        {
            Terraria.Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}