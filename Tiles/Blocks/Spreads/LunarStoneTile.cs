using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
namespace nalydmod.Tiles.Blocks.Spreads
{
    public class LunarStoneTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            dustType = 1;
            drop = mod.ItemType("CoveredBlueBricks");
            AddMapEntry(new Color(50, 170, 100));
        }
        public override void ChangeWaterfallStyle(ref int style)
        {
            style = mod.GetWaterfallStyleSlot("LunarWaterfallStyle");
        }
        public override int SaplingGrowthType(ref int style)
        {
            style = 0;
            return mod.TileType("DungeonSaplingTile");
        }
    }
}