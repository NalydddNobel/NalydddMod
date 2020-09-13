using nalydmod.Items.Global;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.HealthMana
{
    public class ManaFractal : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Permanently increases maximum Mana by 10.\nCan Use up to 20.");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ManaCrystal);
            item.width = 32;
            item.height = 32;
        }
        public override bool CanUseItem(Player player)
        {
            return player.statManaMax == 200 && player.GetModPlayer<MyPlayer>().manaFractals < MyPlayer.maxManaFractals;
        }
        public override bool UseItem(Player player)
        {
            player.statManaMax2 += 10;
            player.statMana += 10;
            if (Main.myPlayer == player.whoAmI)
            {
                player.ManaEffect(20);
            }
            player.GetModPlayer<MyPlayer>().manaFractals += 1;
            return true;
        }
        public override void ModifyTooltips(System.Collections.Generic.List<TooltipLine> list)
        {
            foreach (TooltipLine line2 in list)
            {
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                {
                    line2.overrideColor = MyPlayer.BaseColor.Mana;
                }
            }
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