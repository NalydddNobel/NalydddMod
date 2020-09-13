using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Weapons.AFractalite
{
    public class MandelSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fractalite Sword");
            Tooltip.SetDefault("Has the essence of Mandel.");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.LightsBane);
            item.width = 28;
            item.height = 28;
            item.useAnimation = 26;
            item.useTime = 44;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("FractaliteFractal");
            item.shootSpeed = 10;
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (Main.rand.Next(2) == 0)
            {
                target.AddBuff(mod.BuffType("DeadlyFlamesDeBuff"), 60);
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("FractaliteBar"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}