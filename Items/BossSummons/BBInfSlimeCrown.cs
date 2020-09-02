using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.BossSummons
{
    public class BBInfSlimeCrown : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slime-Shaped Matter");
            Tooltip.SetDefault("Summons King Slime.\nCan be used infinitly.\nExpert");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SlimeCrown);
            item.consumable = false;
            item.maxStack = 1;
            item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("AASoulofSlime"), 30);
            recipe.AddIngredient(mod.ItemType("HHSoulofAxiom"), 30);
            recipe.AddIngredient(ItemID.Gel, 100);
            recipe.AddIngredient(ItemID.PinkGel, 33);
            recipe.AddIngredient(ItemID.RoyalGel, 1);
            recipe.AddIngredient(ItemID.SlimeCrown);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool CanUseItem(Terraria.Player player)
        {
            return !Terraria.NPC.AnyNPCs(NPCID.KingSlime);
        }
        public override bool UseItem(Terraria.Player player)
        {
            Terraria.NPC.SpawnOnPlayer(player.whoAmI, NPCID.KingSlime);
            Terraria.Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}