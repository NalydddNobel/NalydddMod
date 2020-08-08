using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Tools
{
	public class SuperFlarePickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Super Flare Pickaxe");
			Tooltip.SetDefault("This is much better than the Solar Flare Pickaxe I wanted! This is Great!");
		}

		public override void SetDefaults()
		{
			item.damage = 250;
			item.melee = true;
			item.width = 48;
			item.height = 48;
			item.useTime = 3;
			item.useAnimation = 3;
			item.pick = 200;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = ItemRarityID.Expert;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.expertOnly = true;
			item.expert = true;
			ItemID.Sets.ItemIconPulse[item.type] = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(mod.ItemType("SolarBar"), 10);
			recipe.AddIngredient(ItemID.DemoniteBar, 80);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(mod.ItemType("SolarBar"), 10);
			recipe.AddIngredient(ItemID.CrimtaneBar, 80);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();


			
		}
		
		

}
}