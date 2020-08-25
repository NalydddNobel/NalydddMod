using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Accessories
{
    [AutoloadEquip(EquipType.Wings)]
    public class TatteredWings : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swarmer Wings");
            Tooltip.SetDefault("Can glide at rapid speeds.");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.value = 20000;
            item.rare = ItemRarityID.Blue;
            item.accessory = true;
        }
        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.wingTimeMax = 560;
        }
        public override void VerticalWingSpeeds(Terraria.Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.10f;
            ascentWhenRising = 0.02f;
            maxCanAscendMultiplier = 0.2f;
            maxAscentMultiplier = 0.22f;
            constantAscend = 0.012f;
        }
        public override void HorizontalWingSpeeds(Terraria.Player player, ref float speed, ref float acceleration)
        {
            speed = 16;
            acceleration = .066f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("TatteredSwarmerWing"), 2);
            recipe.AddIngredient(ItemID.SoulofFlight, 5);
            recipe.AddIngredient(ItemID.AntlionMandible, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}




