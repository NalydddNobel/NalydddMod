using Microsoft.Xna.Framework;
using nalydmod.Tiles.Special.Trees;
using nalydmod.Walls;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Tiles.Blocks.Spreads
{
    public class LunarGrassTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            dustType = 1;
            drop = ItemID.DirtBlock;
            AddMapEntry(new Color(50, 170, 100));
            SetModTree(new DungeonTree());
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