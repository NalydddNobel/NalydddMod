using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.BossSummons
{
    public class AAGeodeWorm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Suspious Looking Geode");
            Tooltip.SetDefault("Summons Geode Worm.");
        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.consumable = false;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.maxStack = 20;
            item.rare = ItemRarityID.White;
            item.consumable = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("AmethystFragment"), 35);
            recipe.AddIngredient(mod.ItemType("TopazFragment"), 30);
            recipe.AddIngredient(mod.ItemType("SapphireFragment"), 25);
            recipe.AddIngredient(mod.ItemType("EmeraldFragment"), 20);
            recipe.AddIngredient(mod.ItemType("RubyFragment"), 15);
            recipe.AddIngredient(mod.ItemType("DiamondFragment"), 10);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool CanUseItem(Terraria.Player player)
        {
            return !Terraria.NPC.AnyNPCs(mod.NPCType("GeodeWormHead"));
        }
        public override bool UseItem(Terraria.Player player)
        {
            Terraria.NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("GeodeWormHead"));
            Terraria.Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}