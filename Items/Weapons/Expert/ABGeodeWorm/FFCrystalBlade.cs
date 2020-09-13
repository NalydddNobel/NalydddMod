using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Weapons.Expert.ABGeodeWorm
{
    public class FFCrystalBlade : ModItem
    {
        public static short glowMask;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Diamond Blade");
            Tooltip.SetDefault("Shoots diamond bolts.\nExpert");
            if (Main.netMode != NetmodeID.Server)
            {
                glowMask = GlowMaskAPI.Tools.instance.AddGlowMask(mod.GetTexture("Items/Glows/Glow6"));
            }
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.DiamondStaff);
            item.crit = 3;
            item.melee = true;
            item.magic = false;
            item.useAnimation = 15;
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
            recipe.AddIngredient(ItemID.Diamond, 15);
            recipe.AddIngredient(mod.ItemType("DiamondFragment"), 30);
            recipe.AddIngredient(mod.ItemType("BBSoulofShime"), 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}