using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Expert.ABGeodeWorm
{
    public class EECrystalBlade : ModItem
    {
        public static short glowMask;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ruby Blade");
            Tooltip.SetDefault("Shoots ruby bolts.\nExpert");
            if (Main.netMode != NetmodeID.Server)
            {
                glowMask = GlowMaskAPI.Tools.instance.AddGlowMask(mod.GetTexture("Items/Glows/Glow5"));
            }
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.RubyStaff);
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
            recipe.AddIngredient(ItemID.Ruby, 15);
            recipe.AddIngredient(mod.ItemType("RubyFragment"), 30);
            recipe.AddIngredient(mod.ItemType("BBSoulofShime"), 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}