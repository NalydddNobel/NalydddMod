using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons
{
    public class godman : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rock Man");
            Tooltip.SetDefault("Likes to think its more powerful than other swords");
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
            recipe.AddIngredient(ItemID.StoneBlock, 25);
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