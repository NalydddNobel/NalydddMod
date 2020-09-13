using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Weapons.Expert.ABGeodeWorm
{
    public class DDCrystalBlade : ModItem
    {
        public static short glowMask;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Emerald Blade");
            Tooltip.SetDefault("Shoots emerald bolts.\nExpert");
            if (Main.netMode != NetmodeID.Server)
            {
                glowMask = GlowMaskAPI.Tools.instance.AddGlowMask(mod.GetTexture("Items/Glows/Glow5"));
            }
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.EmeraldStaff);
            item.crit = 1;
            item.melee = true;
            item.magic = false;
            item.mana = 0;
            item.width = 40;
            item.height = 40;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.noMelee = false;
            item.glowMask = glowMask;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Emerald, 15);
            recipe.AddIngredient(mod.ItemType("EmeraldFragment"), 30);
            recipe.AddIngredient(mod.ItemType("BBSoulofShime"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}