using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.ZCheat
{
    public class BossilizerV1 : ModItem
    {
        public override string Texture => "nalydmod/Items/Materials/GemFragments/BasicFragment";
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Resets all Hardmode Boss Progression.\nSide affect: Sets the world to Hardmode if in SuperHardmode.\nCheat Item.");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SuspiciousLookingEye);
            item.scale = 2;
            item.consumable = false;
            item.maxStack = 1;
        }
        public override bool UseItem(Player player)
        {
            NPC.downedMechBoss1 = false;
            NPC.downedMechBoss2 = false;
            NPC.downedMechBoss3 = false;
            NPC.downedMechBossAny = false;
            NPC.downedPlantBoss = false;
            NPC.downedGolemBoss = false;
            NPC.downedAncientCultist = false;
            NPC.downedMoonlord = false;
            NPC.downedPirates = false;
            NPC.downedMartians = false;
            NPC.downedFrost = false;
            NPC.downedChristmasIceQueen = false;
            NPC.downedChristmasSantank = false;
            NPC.downedChristmasTree = false;
            NPC.downedClown = false;
            NPC.downedFishron = false;
            NPC.downedHalloweenKing = false;
            NPC.downedHalloweenTree = false;
            NPC.downedTowerNebula = false;
            NPC.downedTowerSolar = false;
            NPC.downedTowerStardust = false;
            NPC.downedTowerVortex = false;
            MyWorld.pillarAequusInvasion = false;
            MyWorld.SuperHardMode = false;
            return true;
        }
    }
}