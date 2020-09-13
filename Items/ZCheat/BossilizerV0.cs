using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.ZCheat
{
    public class BossilizerV0 : ModItem
    {
        public override string Texture => "nalydmod/Items/Materials/GemFragments/BasicFragment";
        public bool toggle;
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Toggles all PreHardmode Boss Progression.\nCheat Item.");
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
            if (!toggle)
            {
                NPC.downedBoss1 = false;
                NPC.downedBoss2 = false;
                NPC.downedBoss3 = false;
                NPC.downedSlimeKing = false;
                NPC.downedQueenBee = false;
                NPC.downedGoblins = false;
                MyWorld.openedKingSlimeBag = false;
                MyWorld.openedBoss1Bag = false;
                MyWorld.openedBoss2CorruptionBag = false;
                MyWorld.openedBoss2CrimsonBag = false;
                MyWorld.openedBoss3Bag = false;
                MyWorld.openedQueenBeeBag = false;
                MyWorld.DownedMage1 = false;
                MyWorld.DownedGeodeWorm = false;
                Main.hardMode = false;
                Main.NewText("Set all pre hardmode boss variables to false", 200, 200, 200);
                toggle = true;
                return true;
            }
            if (toggle)
            {
                NPC.downedBoss1 = true;
                NPC.downedBoss2 = true;
                NPC.downedBoss3 = true;
                NPC.downedSlimeKing = true;
                NPC.downedQueenBee = true;
                NPC.downedGoblins = true;
                MyWorld.openedKingSlimeBag = true;
                MyWorld.openedBoss1Bag = true;
                MyWorld.openedBoss2CorruptionBag = true;
                MyWorld.openedBoss2CrimsonBag = true;
                MyWorld.openedBoss3Bag = true;
                MyWorld.openedQueenBeeBag = true;
                MyWorld.DownedMage1 = true;
                MyWorld.DownedGeodeWorm = true;
                Main.hardMode = true;
                Main.NewText("Set all pre hardmode boss variables to true", 200, 200, 200);
                toggle = false;
                return true;
            }
            return false;
        }
    }
}