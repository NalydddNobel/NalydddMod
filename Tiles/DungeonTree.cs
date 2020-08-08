using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace nalydmod.Tiles
{
    public class DungeonTree : ModTree
    {
        private Mod mod
        {
            get
            {
                return ModLoader.GetMod("nalydmod");
            }
        }
        public override int DropWood()
        {
            return mod.ItemType("CoveredBlueBricks");     //this is what the tree will drop
        }

        public override Texture2D GetTexture()
        {
            return mod.GetTexture("Tiles/DungeonTreeTreeTile");        //add where is u'r tree tile
        }

        public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset)
        {
            return mod.GetTexture("Tiles/DungeonTreeTreeTopsTile");       //add where is u'r tree tops tile
        }

        public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame)
        {
            return mod.GetTexture("Tiles/DungeonTreeTreeBranchesTile");    //add where is u'r tree branches tile
        }
    }
}