using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using IL.Terraria;

namespace nalydmod.Items.Placeables.Special
{
	public class DungeonSapling : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dungeon Sapling");
			Tooltip.SetDefault("Can be planted on Mossy Dungeon Bricks");
		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.maxStack = 999;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("DungeonSaplingTile");
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Blue;
			item.value = 100000;
		}
		
	}
}

	




