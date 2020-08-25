using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Melee.Swords
{
    public class GiantFlag : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Now Open!");
        }

        public override void SetDefaults()
        {
            item.damage = 14;
            item.melee = true;
            item.width = 80;
            item.height = 80;
            item.useTime = 20;
            item.useAnimation = 40;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 7;
            item.value = 5;
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 20);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}




