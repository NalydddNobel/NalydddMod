using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Npcs.Town         //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
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
            npc.townNPC = true; //This defines if the npc is a town Npc or not
            npc.friendly = true;  //this defines if the npc can hur you or not()
            npc.width = 18; //the npc sprite width
            npc.height = 46;  //the npc sprite height
            npc.aiStyle = 7; //this is the npc ai style, 7 is Pasive Ai
            npc.defense = 25;  //the npc defense
            npc.lifeMax = 250;// the npc life
            npc.HitSound = SoundID.NPCHit1;  //the npc sound when is hit
            npc.DeathSound = SoundID.NPCDeath1;  //the npc sound when he dies
            npc.knockBackResist = 0.5f;  //the npc knockback resistance
            Main.npcFrameCount[npc.type] = 25; //this defines how many frames the npc sprite sheet has
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 150; //this defines the npc danger detect range
            NPCID.Sets.AttackType[npc.type] = 3; //this is the attack type,  0 (throwing), 1 (shooting), or 2 (magic). 3 (melee) 
            NPCID.Sets.AttackTime[npc.type] = 30; //this defines the npc attack speed
            NPCID.Sets.AttackAverageChance[npc.type] = 10;//this defines the npc atack chance
            NPCID.Sets.HatOffsetY[npc.type] = 4; //this defines the party hat position
            animationType = NPCID.Guide;  //this copy the guide animation
        }
        public override bool CanTownNPCSpawn(int numTownNPCs, int money) //Whether or not the conditions have been met for this town NPC to be able to move into town.
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

        public override void SetupShop(Chest shop, ref int nextSlot)       //Allows you to add items to this town NPC's shop. Add an item by setting the defaults of shop.item[nextSlot] then incrementing nextSlot.
        {
            if (NPC.downedBoss1)   //this make so when the king slime is killed the town npc will sell this
            {
                shop.item[nextSlot].SetDefaults(ItemID.RecallPotion);  //an example of how to add a vanilla terraria item
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.WormholePotion);
                nextSlot++;
            }
            if (NPC.downedBoss3)   //this make so when Skeletron is killed the town npc will sell this
            {
                shop.item[nextSlot].SetDefaults(ItemID.BookofSkulls);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.ClothierVoodooDoll);
                nextSlot++;
            }
            shop.item[nextSlot].SetDefaults(ItemID.IronskinPotion);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("corrupteyes"));  //this is an example of how to add a modded item
            nextSlot++;

        }

        public override string GetChat()       //Allows you to give this town NPC a chat message when a player talks to it.
        {
            int wizardNPC = NPC.FindFirstNPC(NPCID.Wizard);   //this make so when this npc is close to Wizard
            if (wizardNPC >= 0 && Main.rand.Next(4) == 0)    //has 1 in 3 chance to show this message
            {
                return "Is " + Main.npc[wizardNPC] + " really a wizard? I wonder what magic he can do other than shoot fireballs.";
            }
            int guideNPC = NPC.FindFirstNPC(NPCID.Guide); //this make so when this npc is close to the Guide
            if (guideNPC >= 0 && Main.rand.Next(4) == 0) //has 1 in 3 chance to show this message
            {
                return "You could try to ask " + Main.npc[guideNPC] + " about me. Except for the fact that my people's history has been destroyed with almost no trace.";
            }
            int anglerNPC = NPC.FindFirstNPC(NPCID.Angler);
            if (anglerNPC >= 0 && Main.rand.Next(8) == 0)
            {
                return "I've never took my time to talk to " + Main.npc[anglerNPC] + ". Mostly because I hate the smell of fish.";
            }
            if (anglerNPC >= 0 && Main.rand.Next(8) == 0)
            {
                return "I've never took my time to talk to " + Main.npc[anglerNPC] + ". Mostly because I hate the water.";
            }
            switch (Main.rand.Next(4))    //this are the messages when you talk to the npc
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