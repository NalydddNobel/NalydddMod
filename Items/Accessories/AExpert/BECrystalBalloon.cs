using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Accessories.AExpert
{
    [AutoloadEquip(EquipType.Balloon)]
    public class BECrystalBalloon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal Balloon");
            Tooltip.SetDefault("Increases summon damage by 6%\nIncreases your max number of minions\nIncreases mana by 20\nExpert");
        }
        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 36;
            item.value = 20000;
            item.rare = ItemRarityID.Blue;
            item.accessory = true;
        }
        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.minionDamageMult = 1.06f;
            player.maxMinions++;
            player.statManaMax2 += 20;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("BBSoulofShime"), 10);
            recipe.AddIngredient(ItemID.SoulofLight);
            recipe.AddIngredient(ItemID.Diamond);
            recipe.AddIngredient(mod.ItemType("DiamondFragment"), 5);
            recipe.AddIngredient(mod.ItemType("RubyFragment"), 8);
            recipe.AddIngredient(mod.ItemType("EmeraldFragment"), 15);
            recipe.AddIngredient(mod.ItemType("SapphireFragment"), 18);
            recipe.AddIngredient(mod.ItemType("TopazFragment"), 25);
            recipe.AddIngredient(mod.ItemType("AmethystFragment"), 30);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}