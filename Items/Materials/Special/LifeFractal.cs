using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Materials.Special
{
    internal class LifeFractal : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Permanently increases maximum life by 25.\nCan Use up to 10.");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.LifeFruit);
            item.width = 24;
            item.height = 24;
            item.rare = ItemRarityID.Purple;
        }
        public override bool CanUseItem(Player player)
        {
            return player.statLifeMax == 500 && player.GetModPlayer<MyPlayer>().LifeFractals < MyPlayer.maxLifeFractals;
        }
        public override bool UseItem(Player player)
        {
            player.statLifeMax2 += 25;
            player.statLife += 25;
            if (Main.myPlayer == player.whoAmI)
            {
                player.HealEffect(25, true);
            }
            player.GetModPlayer<MyPlayer>().LifeFractals += 1;
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentSolar, 5);
            recipe.AddIngredient(ItemID.FragmentVortex, 5);
            recipe.AddIngredient(ItemID.FragmentNebula, 5);
            recipe.AddIngredient(ItemID.FragmentStardust, 5);
            recipe.AddIngredient(ItemID.LunarBar, 5);
            recipe.AddIngredient(mod.ItemType("FractaliteBar"), 5);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}