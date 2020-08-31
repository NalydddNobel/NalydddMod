using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.BossSummons
{
    public class InfWormfood : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Food-Shaped Matter");
            Tooltip.SetDefault("Summons Eater of Worlds.\nCan be used infinitly.\nExpert");
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
            recipe.AddIngredient(mod.ItemType("SoulofCrime"), 30);
            recipe.AddIngredient(mod.ItemType("SoulofAxiom"), 30);
            recipe.AddIngredient(ItemID.RottenChunk, 15);
            recipe.AddIngredient(ItemID.ShadowScale, 33);
            recipe.AddIngredient(ItemID.DemoniteBar, 25);
            recipe.AddIngredient(ItemID.WormFood);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool CanUseItem(Terraria.Player player)
        {
            bool alreadySpawned = Terraria.NPC.AnyNPCs(NPCID.EaterofWorldsHead);
            return !alreadySpawned;
        }
        public override bool UseItem(Terraria.Player player)
        {
            Terraria.NPC.SpawnOnPlayer(player.whoAmI, NPCID.EaterofWorldsHead);
            Terraria.Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}