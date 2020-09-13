using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace nalydmod.Tiles.Special.Trees
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
            return mod.ItemType("CoveredBlueBricks");
        }
        public override Texture2D GetTexture()
        {
            return mod.GetTexture("Tiles/Special/Trees/DungeonTreeTreeTile");
        }
        public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset)
        {
            return mod.GetTexture("Tiles/Special/Trees/DungeonTreeTreeTopsTile"); 
        }
        public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame)
        {
            return mod.GetTexture("Tiles/Special/Trees/DungeonTreeTreeBranchesTile");
        }
    }
}