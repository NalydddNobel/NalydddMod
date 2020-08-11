using IL.Terraria;
using System.Collections;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;

namespace nalydmod.Items.Accessories
{
    [AutoloadEquip(EquipType.Wings)]
    public class StickyWings : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slimy Wings");
            Tooltip.SetDefault("It feels like it can melt apart any second");
        }



        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.value = 20000;
            item.rare = ItemRarityID.White;
            item.accessory = true;
            item.expert = true;
        }

        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.wingTimeMax = 30;
        }

        public override void VerticalWingSpeeds(Terraria.Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.45f;
            ascentWhenRising = 0.05f;
            maxCanAscendMultiplier = 0.5f;
            maxAscentMultiplier = 1f;
            constantAscend = 0.035f;         
        }

        public override void HorizontalWingSpeeds(Terraria.Player player, ref float speed, ref float acceleration)
        {
            speed = 5;
            acceleration = 0.5f;          
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Gel, 100);
            recipe.AddIngredient(ItemID.PinkGel, 30);
            recipe.AddIngredient(mod.ItemType("RoyalGel"), 20);
            recipe.AddIngredient(mod.ItemType("SoulofSlime"), 4);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}




