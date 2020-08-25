using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Expert.Accessories
{
    [AutoloadEquip(EquipType.Shield)]
    public class CrystalShield : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal Shield");
            Tooltip.SetDefault("Prevents knockback.\nIncreases Damage by 5%.\nCan feel how deep into the Planet you are.\nExpert");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.value = 20000;
            item.rare = ItemRarityID.Blue;
            item.accessory = true;
        }
        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.noKnockback = true;
            player.accDepthMeter = 1;
            player.allDamage = 1.05f;
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




