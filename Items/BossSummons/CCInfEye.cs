using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.BossSummons
{
    public class CCInfEye : ModItem
    {
        public static bool itemBuffedEoC;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eye-shaped Matter");
            Tooltip.SetDefault("Summons a buffed Eye of Cthulhu.\nCan be used infinitly.\nExpert");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SuspiciousLookingEye);
            item.consumable = false;
            item.maxStack = 1;
            item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("CCSoulofTime"), 30);
            recipe.AddIngredient(mod.ItemType("HHSoulofAxiom"), 30);
            recipe.AddIngredient(mod.ItemType("corrupteyes"), 15);
            recipe.AddIngredient(mod.ItemType("crimsoneyes"), 15);
            recipe.AddIngredient(ItemID.EoCShield);
            recipe.AddIngredient(ItemID.SuspiciousLookingEye);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool CanUseItem(Player player)
        {
            if (!Main.dayTime && Main.expertMode)
            {
                return !NPC.AnyNPCs(NPCID.EyeofCthulhu);
            }
            return false;
        }
        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            itemBuffedEoC = true;
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}