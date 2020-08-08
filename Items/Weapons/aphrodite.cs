using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons
{
	public class aphrodite : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Aphrodite");
			Tooltip.SetDefault("This is a basic dirty sword.");
		}

		public override void SetDefaults() 
		{
			item.damage = 6;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 12;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 1;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.DirtBlock, 25);
			recipe.AddIngredient(ItemID.WoodenSword, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}