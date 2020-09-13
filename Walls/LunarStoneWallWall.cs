using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Walls
{
    public class LunarStoneWallWall : ModWall
    {
        public override void SetDefaults()
        {
            dustType = 15;
            drop = mod.ItemType("LunarStoneWall");
            AddMapEntry(new Color(100, 80, 180));
            soundType = SoundID.Dig;
            soundStyle = 1;
        }
        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.4f;
            g = 0.4f;
            b = 0.4f;
        }
    }
}