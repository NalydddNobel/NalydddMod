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
    public class InfSlimeCrown : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Infinite Slime Crown");
            Tooltip.SetDefault("Summons King Slime.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SlimeCrown);
            item.consumable = false;
            item.maxStack = 1;
            item.rare = ItemRarityID.Blue;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EbonstoneBlock);
            recipe.AddIngredient(ItemID.CrimstoneBlock);
            recipe.AddIngredient(mod.ItemType("SoulofSlime"), 25);
            recipe.AddIngredient(ItemID.SlimeCrown);
            recipe.AddTile(TileID.SkullLanterns);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool CanUseItem(Terraria.Player player)
        {
            bool alreadySpawned = Terraria.NPC.AnyNPCs(NPCID.KingSlime);
            return !alreadySpawned;
        }
        public override bool UseItem(Terraria.Player player)
        {
            Terraria.NPC.SpawnOnPlayer(player.whoAmI, NPCID.KingSlime);
            Terraria.Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}




