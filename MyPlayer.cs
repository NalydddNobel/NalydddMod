using System;
using System.Collections.Generic;
using System.Diagnostics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace nalydmod
{
    public class MyPlayer : ModPlayer
    {
        public const int maxLifeFractals = 10;
        public int LifeFractals;
        public const int maxManaFractals = 20;
        public int ManaFractals;
        private const int saveVersion = 0;
        public bool minionName = false;
        public bool petName = false;
        public static bool hasProjectile;
        public static bool spaceAccessory;
        public override void ResetEffects()
        {
            petName = false;
            minionName = false;
            player.statLifeMax2 += LifeFractals * 25;
            player.statManaMax2 += ManaFractals * 10;
        }
        public override TagCompound Save()
        {
            return new TagCompound
            {
                {"LifeFractals", LifeFractals},
                {"ManaFractals", ManaFractals},
            };
        }
        public override void Load(TagCompound tag)
        {
            LifeFractals = tag.GetInt("LifeFractals");
            ManaFractals = tag.GetInt("ManaFractals");
        }
        [Obsolete]
        public override void SetupStartInventory(IList<Item> items)
        {
            Item item = new Item();
            item.SetDefaults(mod.ItemType("Blood"));
            item.stack = 5;
            items.Add(item);
        }
    }
}