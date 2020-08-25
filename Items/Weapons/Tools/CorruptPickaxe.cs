using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Tools
{
    public class CorruptPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Corrupted Pickaxe");
            Tooltip.SetDefault("Who makes pickaxes out of Corrupt dirt?");
        }
        public override void SetDefaults()
        {
            item.damage = 4;
            item.melee = true;
            item.width = 36;
            item.height = 36;
            item.useTime = 9;
            item.useAnimation = 9;
            item.pick = 45;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 0;
            item.value = 1;
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Ebonwood, 3);
            recipe.AddIngredient(ItemID.DirtBlock, 25);
            recipe.AddIngredient(ItemID.EbonstoneBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CorruptSeeds, 2);
            recipe.AddIngredient(mod.ItemType("SoilPickaxe"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
