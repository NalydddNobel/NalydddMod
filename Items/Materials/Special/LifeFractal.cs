using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace nalydmod.Items.Materials.Special
{
	// Making an item like Life Fruit (That goes above 500) involves a lot of code, as there are many things to consider. (An alternate that approaches 500 can simply follow vanilla code, however.):
	//    You can't make player.statLifeMax more than 500 (it won't save), so you'll have to maintain your extra life within your mod.
	//    Within your ModPlayer, you need to save/load a count of usages. You also need to sync the data to other players. 
	internal class LifeFractal : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Permanently increases maximum life by 25");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.LifeFruit);
			item.width = 32;
			item.height = 32;
			item.rare = ItemRarityID.Quest;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 25);
			recipe.AddIngredient(ItemID.FragmentVortex, 25);
			recipe.AddIngredient(ItemID.FragmentNebula, 25);
			recipe.AddIngredient(ItemID.FragmentStardust, 25);
			recipe.AddIngredient(ItemID.LunarBar, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}