using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using IL.Terraria;

namespace nalydmod.Items.Placeables.Special
{
	public class Painting2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("An Ancient Treasure");
			Tooltip.SetDefault("Kn. Nobel.");

		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("Painting2Tile");
			item.width = 41;
			item.height = 32;
			item.rare = ItemRarityID.White;
			item.value = 100;
		}
	}
}



