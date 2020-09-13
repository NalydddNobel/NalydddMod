using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Armor.Fractalite
{
    [AutoloadEquip(EquipType.Legs)]
    public class FractaliteLeggings : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.value = 20000;
            item.rare = 1;
            item.defense = 5;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("FractaliteBar"), 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}