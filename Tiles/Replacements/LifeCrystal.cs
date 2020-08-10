using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Tiles.Replacements
{
	public class LifeCrystal : GlobalTile
	{
		public override void AnimateTile()
		{
			if (++Main.tileFrameCounter[TileID.Heart] >= 16)
			{
				Main.tileFrameCounter[TileID.Heart] = 0;
				if (++Main.tileFrame[TileID.Heart] >= 4)
				{
					Main.tileFrame[TileID.Heart] = 0;
				}
			}
		}
	}
}
