using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Weapons.Melee.Swords
{
    public class CrystalBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots crystal spikes.");
        }

        public override void SetDefaults()
        {
            item.damage = 11;
            item.crit = 12;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 33;
            item.useAnimation = 33;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 2.66f;
            item.value = 1;
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("CrystalSpike");
            item.shootSpeed = 8;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Diamond);
            recipe.AddIngredient(ItemID.Ruby, 10);
            recipe.AddIngredient(mod.ItemType("AmethystFragment"), 30);
            recipe.AddIngredient(mod.ItemType("TopazFragment"), 25);
            recipe.AddIngredient(mod.ItemType("SapphireFragment"), 18);
            recipe.AddIngredient(mod.ItemType("EmeraldFragment"), 15);
            recipe.AddIngredient(mod.ItemType("RubyFragment"), 8);
            recipe.AddIngredient(mod.ItemType("DiamondFragment"), 5);
            recipe.AddIngredient(mod.ItemType("SoulofShime"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}