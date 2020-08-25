using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Tiles
{
    public class FractaliteBrickTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            dustType = 15;
            drop = mod.ItemType("FractaliteBrick");
            AddMapEntry(new Color(130, 110, 210));
            soundType = SoundID.Tink;
            soundStyle = 1;
        }
    }
}