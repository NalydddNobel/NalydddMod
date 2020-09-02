using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Materials
{
    public class crimsoneyes : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bloddied Lens");
            Tooltip.SetDefault("Wants to spread the Crimson.");
        }
        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 20;
            item.value = 1000;
            item.maxStack = 999;
            item.rare = 0;
        }
        public override void Update(ref float gravity, ref float maxFallSpeed)
        {
            if (Main.rand.Next(23) == 0)
            {
                int dust = Dust.NewDust(item.position * Main.rand.Next(1, 2), item.width, item.height, 225);
                Main.dust[dust].noGravity = true;
                Main.dust[dust].scale = Main.rand.Next(6, 12) * .1f;
                Main.dust[dust].velocity.Y = Main.rand.Next(-12, 12) * .05f;
                Main.dust[dust].velocity.X = Main.rand.Next(-12, 12) * .05f;
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("crimsoneyes"), 2);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(itemID: ItemID.CrimsonSeeds);
            recipe.AddRecipe();
        }
    }
}