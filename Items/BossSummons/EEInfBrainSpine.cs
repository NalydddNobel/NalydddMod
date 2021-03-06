using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.BossSummons
{
    public class EEInfBrainSpine : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brain Matter");
            Tooltip.SetDefault("Summons Brain of Cthulhu.\nCan be used infinitly.\nExpert");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SlimeCrown);
            item.consumable = false;
            item.maxStack = 1;
            item.rare = 2;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("DDSoulofCrime"), 30);
            recipe.AddIngredient(mod.ItemType("HHSoulofAxiom"), 30);
            recipe.AddIngredient(ItemID.Vertebrae, 15);
            recipe.AddIngredient(ItemID.TissueSample, 33);
            recipe.AddIngredient(ItemID.BrainOfConfusion);
            recipe.AddIngredient(ItemID.BloodySpine);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool CanUseItem(Terraria.Player player)
        {
            return !Terraria.NPC.AnyNPCs(NPCID.BrainofCthulhu);
        }
        public override bool UseItem(Terraria.Player player)
        {
            Terraria.NPC.SpawnOnPlayer(player.whoAmI, NPCID.BrainofCthulhu);
            Terraria.Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}