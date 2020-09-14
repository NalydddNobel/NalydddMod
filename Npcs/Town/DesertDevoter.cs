using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using nalydmod.Items.Expert.Toggles;
using nalydmod.Items.Materials.Special;
using nalydmod.Items.Weapons.Melee.Swords;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Npcs.Town
{
    public class DesertDevoter : ModNPC
    {
        public override void SetStaticDefaults()
        {
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
            for (int k = 0; k < 255; k++)
            {
                Player player = Main.player[k];
                if (!player.active)
                {
                    continue;
                }
                foreach (Item item in player.inventory)
                {
                    if ((item.type == ModContent.ItemType<ZADryDoughnut>()) && MyWorld.firstNight)
                    {
                        if (NPC.downedBoss1 || MyWorld.DownedGeodeWorm)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;            
        }
        public override bool CheckConditions(int left, int right, int top, int bottom)    
        {
            return true;  
        }
        public override string TownNPCName()     
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
        public override void SetChatButtons(ref string button, ref string button2)  
        {
            button = "Shop";   
        }
        public override void OnChatButtonClicked(bool firstButton, ref bool openShop)  
        {
            if (firstButton)
            {
                openShop = true;   
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
                    return "I have wares, if you have the money.";
                case 1:
                    return "The deserts back home didn't even have any life, except for me of course.";
                case 2:
                    return "I'd like this house better if it was more... dry.";
                case 3:
                    return "Ra.";
                default:
                    return "I am unfinished...";
            }
        }
        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 22;  
            knockback = 1f;   
        }
        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)  
        {
            cooldown = 2;
            randExtraCooldown = 7;
        }
        public override void DrawTownAttackSwing(ref Texture2D item, ref int itemSize, ref float scale, ref Vector2 offset)
        {
            item = Main.itemTexture[mod.ItemType("DesertClaw")];
        }
        public override void TownNPCAttackSwing(ref int itemWidth, ref int itemHeight)
        {
            itemWidth = 24;
            itemHeight = 36;
        }
        public override void NPCLoot()
        {
            if (Main.rand.Next(3) == 1)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DesertClaw>());
            }
        }
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