using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
namespace nalydmod.Tiles
{
    internal class MetalWorkshopTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.CoordinateHeights = new[] { 20, 18 };
            TileObjectData.addTile(Type);
            AddMapEntry(new Color(200, 200, 200));
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Metal Workshop");
            dustType = DustID.Iron;
            adjTiles = new int[] { TileID.TinkerersWorkbench };
            disableSmartCursor = true;
        }
        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("MetalWorkshop"));
        }
    }
}