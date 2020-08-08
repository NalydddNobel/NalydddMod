using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace nalydmod.Tiles.Spreads
{
    public class MossyBlueBricksTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            dustType = 1;
            drop = mod.ItemType("CoveredBlueBricks");
            AddMapEntry(new Color(000, 25, 50));
            SetModTree(new DungeonTree());
        }
        public override int SaplingGrowthType(ref int style)
        {
            style = 0;
            return mod.TileType("DungeonSaplingTile");        //this make the spaling spawn the custom tree/sapling on this block/tile.    change CustomSaplingTile with u'r sapling name
        }
    }
}