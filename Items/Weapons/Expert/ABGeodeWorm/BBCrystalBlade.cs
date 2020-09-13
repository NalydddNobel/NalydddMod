using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Expert.ABGeodeWorm
{
    public class BBCrystalBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Topaz Blade");
            Tooltip.SetDefault("Shoots topaz bolts.\nExpert");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.TopazStaff);
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
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Topaz, 15);
            recipe.AddIngredient(mod.ItemType("TopazFragment"), 30);
            recipe.AddIngredient(mod.ItemType("BBSoulofShime"), 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}