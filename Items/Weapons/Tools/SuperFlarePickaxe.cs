using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Weapons.Tools
{
    public class SuperFlarePickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is much better than the Solar Flare Pickaxe I wanted!\nExpert");
        }
        public override void SetDefaults()
        {
            item.damage = 78;
            item.melee = true;
            item.width = 48;
            item.height = 48;
            item.useTime = 5;
            item.useAnimation = 5;
            item.pick = 225;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 10000;
            item.rare = 9;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("FlarePickaxe"));
            recipe.AddIngredient(mod.ItemType("SolarBar"), 10);
            recipe.AddIngredient(ItemID.FragmentSolar, 25);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}