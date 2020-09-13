using Microsoft.Xna.Framework;
using nalydmod.Dusts;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
namespace nalydmod
{
    public class MyPlayer : ModPlayer
    {

        //Buffs / temporary effects

        public bool bloodSkull;
        public bool hungryMaggot;
        public bool deadlyFlames;
        public bool petName;
        public static bool hasProjectile;
        public static int dmg;
        public static bool hit;

        //Special accessorys

        public static bool spaceAccessory;
        public static bool gemAccessory;

        //Mob spawns / biomes

        public static bool LunarZone;
        public static bool LunarBiome;

        //Raritys

        public static int rare12Red;
        public static int rare12Blue;
        bool bRare12Reset;
        bool rRare12Reset;
        public static int rare13Red;
        public static int rare13Green;
        int rare13x;
        bool Rare13Reset;
        public static int manaColorR;
        public static int manaColorB;
        public static int masterColorR;
        public static int masterColorG;
        bool masterToggleR;
        bool masterToggleG;

        //Player Variables

        public const int maxLifeFractals = 10;
        public int lifeFractals;

        public const int maxManaFractals = 5;
        public int manaFractals;

        public int maxSmallSummon;
        public int smallSummon;

        public bool kingSlimeEffect;
        public bool eoCEffect;
        public bool eoWEffect;
        public bool boCEffect;
        public bool queenBeeEffect;
        public bool skeletronEffect;
        public bool geodeWormEffect;
        public bool ancientMageEffect;

        public override void Initialize()
        {
            kingSlimeEffect = false;
            eoCEffect = false;
            lifeFractals = 0;
            manaFractals = 0;
        }
        public override void Load(TagCompound tag)
        {

            //Perm buffs

            kingSlimeEffect = tag.GetBool("kingSlimeEffect");
            eoCEffect = tag.GetBool("eoCEffect");

            //Life / mana

            lifeFractals = tag.GetInt("lifeFractals");
            manaFractals = tag.GetInt("manaFractals");
            if (lifeFractals > maxLifeFractals)
            {
                lifeFractals = maxLifeFractals;
            }
            if (manaFractals > maxManaFractals)
            {
                manaFractals = maxManaFractals;
            }
        }
        public override TagCompound Save()
        {
            return new TagCompound
            {
                {"kingSlimeEffect", kingSlimeEffect},
                {"eoCEffect", eoCEffect},

                {"lifeFractals", lifeFractals},
                {"manaFractals", manaFractals},
            };
        }      
        public override void ResetEffects()
        {
            bloodSkull = false;
            hungryMaggot = false;
            deadlyFlames = false;
            petName = false;
            gemAccessory = false;
            spaceAccessory = false;

            player.statLifeMax2 += lifeFractals * 25;
            player.statManaMax2 += manaFractals * 20;               
        }
        public override void PreUpdate()
        {
            smallSummon = player.ownedProjectileCounts[ModContent.ProjectileType<Projectiles.Minions.TissueSkull>()];

            //customraritys

            if (!Main.dedServ)
            {

                //rare12fx

                if (!rRare12Reset)
                {
                    rare12Red += 2;
                    if (rare12Red > 255)
                    {
                        rRare12Reset = true;
                    }
                }
                else
                {
                    rare12Red -= 8;
                    if (rare12Red < 0)
                    {
                        rRare12Reset = false;
                    }
                }
                if (!bRare12Reset)
                {
                    rare12Blue += 8;
                    if (rare12Blue > 255)
                    {
                        bRare12Reset = true;
                    }
                }
                else
                {
                    rare12Blue -= 8;
                    if (rare12Blue < 0)
                    {
                        bRare12Reset = false;
                    }
                }
                if (rare12Blue < 77 && rare12Red < 88)
                {
                    bRare12Reset = false;
                    rRare12Reset = false;
                }

                //rare13fx

                rare13Red = (int)Math.Round(Math.Sin(rare13x / 6) * 127 + 127);
                rare13Green = (int)Math.Round(Math.Sin(rare13x / 6 + 14) * 127 + 127);
                if (!Rare13Reset)
                {
                    rare13x++;
                    if (rare13x > 578)
                    {
                        Rare13Reset = true;
                    }
                }
                else
                {
                    rare13x--;
                    if (rare13x < 0)
                    {
                        Rare13Reset = false;
                    }
                }

                //Masterfx

                if (!masterToggleR)
                {
                    masterColorR += 2;
                    if (masterColorR > 255)
                    {
                        masterToggleR = true;
                    }
                }
                else
                {
                    masterColorR -= 3;
                    if (masterColorR < 0)
                    {
                        masterToggleR = false;
                    }
                }
                if (!masterToggleG)
                {
                    masterColorG += 1;
                    if (masterColorG > 255)
                    {
                        masterToggleG = true;
                    }
                }
                else
                {
                    masterColorG -= 1;
                    if (masterColorG < 0)
                    {
                        masterToggleG = false;
                    }
                }
            }
        }
        public override void UpdateBiomes()
        {
            LunarBiome = MyWorld.BiomeLunar > 50;
        }
        public override void UpdateBadLifeRegen()
        {
            if (deadlyFlames)
            {
                if (player.lifeRegen > 0)
                {
                    player.lifeRegen = 0;
                }
                player.lifeRegenTime = 0;
                player.lifeRegen -= 16;
            }
        }
            [Obsolete]
        public override void SetupStartInventory(IList<Item> items)
        {
            Item item = new Item();
            item.SetDefaults(mod.ItemType("Blood"));
            item.stack = 5;
            items.Add(item);
            item = new Item();
            item.SetDefaults(mod.ItemType("AAextraBuffedModeItem"));
            items.Add(item);
        }
        public override void DrawEffects(PlayerDrawInfo drawInfo, ref float r, ref float g, ref float b, ref float a, ref bool fullBright)
        {
            if (deadlyFlames)
            {
                if (Main.rand.Next(2) == 0 && drawInfo.shadow == 0f)
                {
                    int dust = Dust.NewDust(drawInfo.position - new Vector2(2f, 2f), player.width + 4, player.height + 4, ModContent.DustType<DeadlyFlameDust>(), player.velocity.X * 0.4f, player.velocity.Y * 0.4f, 100, default, 1.22f);
                    Main.dust[dust].velocity *= 1.2f;
                    Main.dust[dust].velocity.Y -= 0.5f;
                    Main.playerDrawDust.Add(dust);
                }
                if (Main.rand.Next(8) == 0 && drawInfo.shadow == 0f)
                {
                    int dust = Dust.NewDust(drawInfo.position - new Vector2(2f, 2f), player.width + 4, player.height + 4, ModContent.DustType<DeadlyFlameDust>(), player.velocity.X * 0.4f, player.velocity.Y * 0.4f, 100, default, 1.44f);
                    Main.dust[dust].velocity *= 1.2f;
                    Main.dust[dust].velocity.Y -= 0.5f;
                    Main.playerDrawDust.Add(dust);
                }
                if (Main.rand.Next(2) == 0 && drawInfo.shadow == 0f)
                {
                    int dust = Dust.NewDust(drawInfo.position - new Vector2(2f, 2f), player.width + 4, player.height + 4, ModContent.DustType<DeadlyFlameDust2>(), player.velocity.X * 0.4f, player.velocity.Y * 0.4f, 100, default, 0.88f);
                    Main.dust[dust].velocity *= 1.2f;
                    Main.dust[dust].velocity.Y -= 0.5f;
                    Main.playerDrawDust.Add(dust);
                }
                if (Main.rand.Next(4) == 0 && drawInfo.shadow == 0f)
                {
                    int dust = Dust.NewDust(drawInfo.position - new Vector2(2f, 2f), player.width + 4, player.height + 4, ModContent.DustType<DeadlyFlameDust2>(), player.velocity.X * 0.4f, player.velocity.Y * 0.4f, 100, default, 1f);
                    Main.dust[dust].velocity *= 1.2f;
                    Main.dust[dust].velocity.Y -= 0.5f;
                    Main.playerDrawDust.Add(dust);
                }
                Lighting.AddLight((int)(player.position.X / 16f), (int)(player.position.Y / 16f), 0, 0.66f, 0.90f);
            }
        }
        public override void OnHitByNPC(NPC npc, int damage, bool crit)
        {
            if (spaceAccessory)
            {
                if (npc.type == NPCID.MeteorHead)
                {
                    dmg = npc.damage;
                    npc.damage = (int)Math.Round(npc.damage * 0.5);
                    hit = true;
                }
            }
        }
        public class BaseColor
        {
            public static Color RedBlueCycle => new Color(rare12Red, 0, rare12Blue);
            public static Color RedGreenCycle => new Color(rare13Red, rare13Green, 0);
            public static Color DarkGreen => new Color(6, 75, 60);
            public static Color DarkBlue => new Color(30, 75, 120);
            public static Color Mana => new Color(manaColorR, 0, manaColorB);
            public static Color Life => new Color(rare13Red, rare13Green, 0);
            public static Color Master => new Color(masterColorR, masterColorG, 255);
        }
    }
}