using IL.Terraria;
using System.Collections;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;

namespace nalydmod.Items.Accessories
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
            item.width = 28;
            item.height = 36;
            item.value = 20000;
            item.rare = 3;
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
            recipe.AddIngredient(mod.ItemType("AmethystFragment"), 5);
            recipe.AddIngredient(mod.ItemType("TopazFragment"), 8);
            recipe.AddIngredient(mod.ItemType("SapphireFragment"), 15);
            recipe.AddIngredient(mod.ItemType("EmeraldFragment"), 18);
            recipe.AddIngredient(mod.ItemType("RubyFragment"), 25);
            recipe.AddIngredient(mod.ItemType("DiamondFragment"), 30);
            recipe.AddIngredient(mod.ItemType("SoulofShime"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}



