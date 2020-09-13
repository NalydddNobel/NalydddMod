using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Weapons.Expert.AASlime
{
    public class SlimeShortsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slime Shortsword");
            Tooltip.SetDefault("Shoots a slime spike");
        }
        public override void SetDefaults()
        {
            item.damage = 16;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 48;
            item.useAnimation = 12;
            item.useStyle = ItemUseStyleID.Stabbing;
            item.knockBack = 1;
            item.value = 2000;
            item.rare = 1;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.shoot = mod.ProjectileType("SlimeSpike");
            item.shootSpeed = 7.22f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("AASoulofSlime"), 10);
            recipe.AddIngredient(mod.ItemType("RoyalGel"), 10);
            recipe.AddIngredient(ItemID.Gel, 100);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}