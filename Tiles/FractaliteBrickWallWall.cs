using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Tiles
{
    public class FractaliteBrickWallWall : ModWall
    {
        public override void SetDefaults()
        {
            Main.wallHouse[Type] = true;
            dustType = 15;
            drop = mod.ItemType("FractaliteBrickWall");
            AddMapEntry(new Color(100, 80, 180));
            soundType = SoundID.Dig;
            soundStyle = 1;
        }
    }
}