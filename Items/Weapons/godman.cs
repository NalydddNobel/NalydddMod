using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons
{
    public class godman : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("godman"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Somehow more powerful than most swords");
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 28;
            item.useAnimation = 10;
            item.useStyle = 3;
            item.knockBack = 1;
            item.value = 2000;
            item.rare = 0;
            item.UseSound = SoundID.Item7;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 25);
            recipe.AddIngredient(ItemID.IronBar, 8);
            recipe.AddIngredient(ItemID.Acorn, 3);
            recipe.AddIngredient(ItemID.SandBlock, 10);
            recipe.AddIngredient(ItemID.GoldChest, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}