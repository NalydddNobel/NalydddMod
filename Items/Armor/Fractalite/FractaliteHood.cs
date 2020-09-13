using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Armor.Fractalite
{
    [AutoloadEquip(EquipType.Head)]
    public class FractaliteHood : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases max number of minions.\nIncreases summon damage by 5%");
        }
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.value = 20000;
            item.rare = 1;
            item.defense = 2;
        }
        public override void UpdateEquip(Player player)
        {
            player.minionDamageMult = 1.05f;
            player.maxMinions++;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<FractaliteBreastplate>() && legs.type == ModContent.ItemType<FractaliteLeggings>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increases summon damage by 15%";
            player.minionDamageMult = 1.15f;
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