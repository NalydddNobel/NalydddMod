using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Armor.Fractalite
{
    [AutoloadEquip(EquipType.Body)]
    public class FractaliteBreastplate : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases magic and summon damage by 5%");
        }
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.value = 20000;
            item.rare = ItemRarityID.Green;
            item.defense = 6;
        }
        public override void UpdateEquip(Player player)
        {
            player.minionDamageMult = 1.05f;
            player.magicDamageMult = 1.05f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("FractaliteBar"), 35);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}