using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Armor.Fractalite
{
    [AutoloadEquip(EquipType.Head)]
    public class FractaliteHelmet : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases mana by 20.\nIncreases magic damage by 5%");
        }
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.value = 20000;
            item.rare = 1;
            item.defense = 4;
        }
        public override void UpdateEquip(Player player)
        {
            player.statManaMax += 20;
            player.magicDamageMult = 1.05f;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<FractaliteBreastplate>() && legs.type == ModContent.ItemType<FractaliteLeggings>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increases magic damage by 8%,\nincreases mana by 20";
            player.magicDamageMult = 1.08f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("FractaliteBar"), 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}