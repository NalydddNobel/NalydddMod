using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.ZCheat
{
    public class Bossilizer : ModItem
    {
        public override string Texture => "nalydmod/Items/Materials/GemFragments/BasicFragment";
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Resets all PreHardmode Boss Progression.\nSide affect: Sets the world to PreHardmode.\nCheat Item.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SuspiciousLookingEye);
            item.scale = 2;
            item.color = Color.White;
            item.consumable = false;
            item.maxStack = 1;
        }
        public override bool UseItem(Terraria.Player player)
        {
            NPC.downedBoss1 = false;
            NPC.downedBoss2 = false;
            NPC.downedBoss3 = false;
            NPC.downedSlimeKing = false;
            NPC.downedQueenBee = false;
            Main.hardMode = false;
            return true;
        }
    }
}





