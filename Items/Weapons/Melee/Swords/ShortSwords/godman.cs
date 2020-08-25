using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Melee.Swords.ShortSwords
{
    public class godman : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Man");
            Tooltip.SetDefault("Might secretly be a fighter robot. Shoots lemons.");
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 28;
            item.useAnimation = 10;
            item.useStyle = ItemUseStyleID.Stabbing;
            item.knockBack = 1;
            item.value = 2000;
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item7;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("Lemon");
            item.shootSpeed = 3;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperShortsword);
            recipe.AddIngredient(ItemID.StoneBlock, 25);
            recipe.AddIngredient(ItemID.IronBar, 8);
            recipe.AddIngredient(ItemID.Acorn, 3);
            recipe.AddIngredient(ItemID.SandBlock, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}