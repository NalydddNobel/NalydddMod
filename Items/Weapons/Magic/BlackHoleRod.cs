using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
namespace nalydmod.Items.Weapons.Magic
{
    public class BlackHoleRod : ModItem
    {
        public static short glowMask;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rod of Dark Matter");
            Tooltip.SetDefault("Summons a black hole that shoots multiple homing corrupt worms");
            if (Main.netMode != NetmodeID.Server)
            {
                glowMask = GlowMaskAPI.Tools.instance.AddGlowMask(mod.GetTexture("Items/Glows/Glow2"));
            }
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(64);
            item.damage = 59;
            item.useTime = 20;
            item.useAnimation = 20;
            item.crit = 5;
            item.shootSpeed = 12;
            item.rare = 8;
            item.mana = 8;
            item.shoot = mod.ProjectileType("DarkHole");
            item.glowMask = glowMask;
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("RodofContamination"));
            recipe.AddIngredient(ItemID.FragmentNebula, 25);
            recipe.AddIngredient(ItemID.VileMushroom, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}