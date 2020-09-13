using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
namespace nalydmod.Items.Weapons.Magic
{
    public class RodofContamination : ModItem
    {
        public static short glowMask;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rod of Contamination");
            Tooltip.SetDefault("Shoots a corrupted worm");
            if (Main.netMode != NetmodeID.Server)
            {
                glowMask = GlowMaskAPI.Tools.instance.AddGlowMask(mod.GetTexture("Items/Glows/Glow2"));
            }
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(64);
            item.damage = 45;
            item.crit = 3;
            item.shootSpeed = 32;
            item.rare = 5;
            item.mana = 14;
            item.shoot = mod.ProjectileType("ContaminationProjectile");
            item.glowMask = glowMask;
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("OdiousThorn"));
            recipe.AddIngredient(521, 25);
            recipe.AddIngredient(547, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}