using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Accessories.Summon.Small
{
    public class SpectreScroll : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases max number of small minions by 3.\nIncreases mana by 40.");
        }
        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.value = 20000;
            item.rare = 9;
            item.accessory = true;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statManaMax2 += 20;
            player.GetModPlayer<MyPlayer>().maxSmallSummon += 3;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.NecromanticScroll);
            recipe.AddIngredient(ItemID.Ectoplasm, 10);
            recipe.AddIngredient(mod.ItemType("SoulofBite"), 10);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}