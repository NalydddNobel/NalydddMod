using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using nalydmod.Items.BossSummons;

namespace nalydmod.NPCs
{
    public class PermBuffs : GlobalNPC
    {
        public override void AI(NPC npc)
        {
            Player player = Main.player[Main.LocalPlayer.whoAmI];
            if (player.GetModPlayer<MyPlayer>().kingSlimeEffect)
            {
                if (npc.aiStyle == 1)
                {
                    npc.damage = 0;
                }
            }
        }
        public override void ScaleExpertStats(NPC npc, int numPlayers, float bossLifeScale)
        {
            if (MyWorld.extraBuffedMode)
            {
                switch (npc.type)
                {
                    case NPCID.BlueSlime:
                        if (Main.hardMode)
                        {
                            if (NPC.downedPlantBoss)
                            {
                                npc.lifeMax = 859;
                                npc.damage = 292;
                                npc.defense = 60;
                            }
                            else
                            {
                                npc.lifeMax = 674;
                                npc.damage = 166;
                                npc.defense = 38;
                            }                         
                        }
                        else
                        {
                            npc.lifeMax = 290;
                            npc.damage = 68;
                            npc.defense = 11;
                        }
                        break;

                    case NPCID.DemonEye:
                        if (Main.hardMode)
                        {
                            if (NPC.downedPlantBoss)
                            {
                                npc.lifeMax = 1200;
                                npc.damage = 369;
                                npc.defense = 15;
                            }
                            else
                            {
                                npc.lifeMax = 555;
                                npc.damage = 200;
                                npc.defense = 8;
                            }
                        }
                        else
                        {
                            npc.lifeMax = 222;
                            npc.damage = 56;
                            npc.defense = 5;
                        }
                        break;

                    case NPCID.Zombie:
                        if (Main.hardMode)
                        {
                            if (NPC.downedPlantBoss)
                            {
                                npc.lifeMax = 1026; 
                                npc.damage = 296;
                                npc.defense = 89;
                            }
                            else
                            {
                                npc.lifeMax = 454;
                                npc.damage = 175;
                                npc.defense = 50;
                            }
                        }
                        else
                        {
                            npc.lifeMax = 279;
                            npc.damage = 72;
                            npc.defense = 16;
                        }
                        break;

                    case NPCID.EyeofCthulhu:
                        {
                            if (!(CCInfEye.itemBuffedEoC || BossBuffs.buffedEoC))
                            {
                                if (npc.ai[0] > 0)
                                {
                                    npc.damage = 59;
                                    npc.defense = 2;
                                }
                                else
                                {
                                    npc.lifeMax = 6411;
                                    npc.damage = 64;
                                    npc.defense = 20;
                                }
                            }                        
                        }
                        break;
                }
            }
        }
    }
}