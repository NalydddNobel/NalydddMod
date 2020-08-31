using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Npcs.Town
{
    public class DesertDevoter : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Desert Devoter");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.DyeTrader];
        }
        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 46;
            npc.aiStyle = 7;
            npc.defense = 25;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            Main.npcFrameCount[npc.type] = 25;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 150;
            NPCID.Sets.AttackType[npc.type] = 3;
            NPCID.Sets.AttackTime[npc.type] = 30;
            NPCID.Sets.AttackAverageChance[npc.type] = 10;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
            animationType = NPCID.Guide;
        }
        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            if (Main.expertMode == true)
            {
                if (NPC.downedSlimeKing)
                {
                    return true;
                }
            }
            return false;
        }
        public override bool CheckConditions(int left, int right, int top, int bottom)    //Allows you to define special conditions required for this town NPC's house
        {
            return true;  //so when a house is available the npc will  spawn
        }
        public override string TownNPCName()     //Allows you to give this town NPC any name when it spawns
        {
            switch (WorldGen.genRand.Next(6))
            {
                case 0:
                    return "Maroon";
                case 1:
                    return "Habider";
                case 2:
                    return "Soliterry";
                case 3:
                    return "Lorner";
                case 4:
                    return "Unpopol";
                case 5:
                    return "Egel";
                default:
                    return "Daysert";
            }
        }

        public override void SetChatButtons(ref string button, ref string button2)  //Allows you to set the text for the buttons that appear on this town NPC's chat window. 
        {
            button = "Buy";   //this defines the buy button name
        }
        public override void OnChatButtonClicked(bool firstButton, ref bool openShop) //Allows you to make something happen whenever a button is clicked on this town NPC's chat window. The firstButton parameter tells whether the first button or second button (button and button2 from SetChatButtons) was clicked. Set the shop parameter to true to open this NPC's shop.
        {
            if (firstButton)
            {
                openShop = true;   //so when you click on buy button opens the shop
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.KingSlimeBossBag);
            nextSlot++;
            if (MyWorld.DownedGeodeWorm && Main.expertMode)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("GeodeTreasureBag"));
                nextSlot++;
            }
            if (NPC.downedBoss1 && Main.expertMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.EyeOfCthulhuBossBag);
                nextSlot++;
            }
            if (NPC.downedBoss2 && Main.expertMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.EaterOfWorldsBossBag);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.BrainOfCthulhuBossBag);
                nextSlot++;
            }
            if (MyWorld.DownedMage1 && Main.expertMode)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("Mage1TreasureBag"));
                nextSlot++;
            }
            if (NPC.downedBoss3 && Main.expertMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SkeletronBossBag);
                nextSlot++;
            }
            if (NPC.downedQueenBee && Main.expertMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.QueenBeeBossBag);
                nextSlot++;
            }
            if (Main.hardMode && Main.expertMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.WallOfFleshBossBag);
                nextSlot++;
            }
        }
        public override string GetChat()
        {
            switch (Main.rand.Next(4))
            {
                case 0:
                    return "My kind will sell you wares. Only if you have the goods.";
                case 1:
                    return "The deserts back in my land didn't even have life, except for my kind of course.";
                case 2:
                    return "I'd like this house better if it was more... dry.";
                case 3:
                    return "Ra";
                default:
                    return "The desert is my home, friend.";
            }
        }
        public override void TownNPCAttackStrength(ref int damage, ref float knockback)//  Allows you to determine the damage and knockback of this town NPC attack
        {
            damage = 15;  //npc damage
            knockback = 2f;   //npc knockback
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)  //Allows you to determine the cooldown between each of this town NPC's attack. The cooldown will be a number greater than or equal to the first parameter, and less then the sum of the two parameters.
        {
            cooldown = 5;
            randExtraCooldown = 10;
        }
        //------------------------------------This is an example of how to make the npc use a sward attack-------------------------------
        public override void DrawTownAttackSwing(ref Texture2D item, ref int itemSize, ref float scale, ref Vector2 offset)//Allows you to customize how this town NPC's weapon is drawn when this NPC is swinging it (this NPC must have an attack type of 3). Item is the Texture2D instance of the item to be drawn (use Main.itemTexture[id of item]), itemSize is the width and height of the item's hitbox
        {
            scale = 1f;
            item = Main.itemTexture[mod.ItemType("DesertClaw")]; //this defines the item that this npc will use
        }

        public override void TownNPCAttackSwing(ref int itemWidth, ref int itemHeight) //  Allows you to determine the width and height of the item this town NPC swings when it attacks, which controls the range of this NPC's swung weapon.
        {
            itemWidth = 56;
            itemHeight = 56;
        }

        //----------------------------------This is an example of how to make the npc use a gun and a projectile ----------------------------------
        /*public override void DrawTownAttackGun(ref float scale, ref int item, ref int closeness) //Allows you to customize how this town NPC's weapon is drawn when this NPC is shooting (this NPC must have an attack type of 1). Scale is a multiplier for the item's drawing size, item is the ID of the item to be drawn, and closeness is how close the item should be drawn to the NPC.
          {
              scale = 1f;
              item = mod.ItemType("GunName");  
              closeness = 20;
          }
          public override void TownNPCAttackProj(ref int projType, ref int attackDelay)//Allows you to determine the projectile type of this town NPC's attack, and how long it takes for the projectile to actually appear
          {
              projType = ProjectileID.CrystalBullet;
              attackDelay = 1;
          }
 
          public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)//Allows you to determine the speed at which this town NPC throws a projectile when it attacks. Multiplier is the speed of the projectile, gravityCorrection is how much extra the projectile gets thrown upwards, and randomOffset allows you to randomize the projectile's velocity in a square centered around the original velocity
          {
              multiplier = 7f;
             // randomOffset = 4f;
 
          }   */
    }
}