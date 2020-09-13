using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
namespace nalydmod.Items.Weapons.Magic
{
    public class OdiousThorn : ModItem
    {
        public static short glowMask;
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a odious thorn");
            if (Main.netMode != NetmodeID.Server)
            {
                glowMask = GlowMaskAPI.Tools.instance.AddGlowMask(mod.GetTexture("Items/Glows/Glow1"));
            }
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(64);
            item.damage = 22;
            item.crit = 1;
            item.shootSpeed = 12;
            item.rare = 2;
            item.shoot = mod.ProjectileType("OdiousProjectile");
            item.glowMask = glowMask;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(64);
            recipe.AddIngredient(521);
            recipe.AddIngredient(mod.ItemType("DDSoulofCrime"), 10);
            recipe.AddIngredient(mod.ItemType("CursedSparks"), 10);
            recipe.AddIngredient(mod.ItemType("corrupteyes"), 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}