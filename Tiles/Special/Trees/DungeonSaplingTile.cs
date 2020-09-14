using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using nalydmod.Tiles.Blocks.Spreads;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;
namespace nalydmod.Tiles.Special.Trees
{
    public class DungeonSaplingTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.Width = 1;
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.UsesCustomCanPlace = true;
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 18 };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.AnchorValidTiles = new[] { TileType<MossyBlueBricksTile>() };
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.DrawFlipHorizontal = true;
            TileObjectData.newTile.WaterPlacement = LiquidPlacement.NotAllowed;
            TileObjectData.newTile.LavaDeath = true;
            TileObjectData.newTile.RandomStyleRange = 3;
            TileObjectData.newTile.StyleMultiplier = 3;
            TileObjectData.newSubTile.CopyFrom(TileObjectData.newTile);
            TileObjectData.newSubTile.AnchorValidTiles = new int[] { TileType<CoveredBlueBricksTile>() };
            TileObjectData.addSubTile(1);
            TileObjectData.addTile(Type);

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Dungeon Tree");
            AddMapEntry(new Color(200, 200, 200), name);
            sapling = true;
            dustType = 8;
            adjTiles = new int[] { TileID.Saplings };
        }
        public override void NumDust(int i, int j, bool fail, ref int num) => num = fail ? 1 : 3;
        public override void RandomUpdate(int i, int j)
        {
            if (WorldGen.genRand.Next(20) == 0)
            {
                Tile tile = Framing.GetTileSafely(i, j);
                bool growSucess;
                if (tile.frameX < 54)
                    growSucess = WorldGen.GrowTree(i, j);
                else
                    growSucess = WorldGen.GrowPalmTree(i, j);
                bool isPlayerNear = WorldGen.PlayerLOS(i, j);
                if (growSucess && isPlayerNear)
                    WorldGen.TreeGrowFXCheck(i, j);
            }
        }
        public override void SetSpriteEffects(int i, int j, ref SpriteEffects effects)
        {
            if (i % 2 == 1)
                effects = SpriteEffects.FlipHorizontally;
        }
    }
}