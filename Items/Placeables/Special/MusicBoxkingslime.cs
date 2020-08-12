using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using IL.Terraria;

namespace nalydmod.Items.Placeables.Special
{
	public class MusicBoxkingslime : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (King Slime)");
		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("MusicBoxkingslimeTile");
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.LightRed;
			item.value = 100000;
			item.accessory = true;
		}
	}
}



