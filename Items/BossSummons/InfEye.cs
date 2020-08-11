using IL.Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using On.Terraria;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.BossSummons
{
    public class InfEye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Infinite Suspious Looking Eye");
            Tooltip.SetDefault("Summons The Eye of Cuthulu.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SuspiciousLookingEye);
            item.consumable = false;
            item.maxStack = 1;
            item.rare = ItemRarityID.Blue;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EbonstoneBlock);
            recipe.AddIngredient(ItemID.CrimstoneBlock);
            recipe.AddIngredient(mod.ItemType("SoulofTime"), 25);
            recipe.AddIngredient(ItemID.SuspiciousLookingEye);
            recipe.AddTile(TileID.SkullLanterns);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool CanUseItem(Terraria.Player player)
        {
            if (Terraria.Main.dayTime == false)
            {
                bool alreadySpawned = Terraria.NPC.AnyNPCs(NPCID.EyeofCthulhu);
                return !alreadySpawned;
            }
            return false;
        }
        public override bool UseItem(Terraria.Player player)
        {
            Terraria.NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            Terraria.Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}




