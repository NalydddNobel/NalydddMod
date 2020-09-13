using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Accessories
{
    [AutoloadEquip(EquipType.HandsOn)]
    public class LavaRing : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Gives lava immunity for 3 seconds.");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 20000;
            item.rare = ItemRarityID.Green;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lavaMax = 180;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 2);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemID.LavaCharm);
            recipe.AddRecipe();
        }
    }
}