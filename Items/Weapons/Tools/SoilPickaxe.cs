using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Tools
{
	public class SoilPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dirt Pickaxe");
			Tooltip.SetDefault("Who makes pickaxes out of dirt?");
		}
		public override void SetDefaults()
		{
			item.damage = 1;
			item.melee = true;
			item.width = 36;
			item.height = 36;
			item.useTime = 10;
			item.useAnimation = 10;
			item.pick = 35;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 0;
			item.value = 1;
			item.rare = ItemRarityID.Gray;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperPickaxe);
			recipe.AddIngredient(ItemID.DirtBlock, 25);
			recipe.AddIngredient(ItemID.StoneBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
