using IL.Terraria;
using System.Collections;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;

namespace nalydmod.Items.Accessories
{
    [AutoloadEquip(EquipType.Wings)]
    public class TatteredWings : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swarmer Wings");
            Tooltip.SetDefault("Dry.");
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
            player.wingTimeMax = 40;
        }
        public override void VerticalWingSpeeds(Terraria.Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.50f;
            ascentWhenRising = 0.10f;
            maxCanAscendMultiplier = 0.8f;
            maxAscentMultiplier = 1.5f;
            constantAscend = 0.055f;         
        }
        public override void HorizontalWingSpeeds(Terraria.Player player, ref float speed, ref float acceleration)
        {
            speed = 6;
            acceleration = 1f;          
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("TatteredSwarmerWing"), 2);
            recipe.AddIngredient(ItemID.SoulofFlight, 5);
            recipe.AddIngredient(ItemID.AntlionMandible, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}




