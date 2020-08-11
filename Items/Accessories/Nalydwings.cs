using IL.Terraria;
using System.Collections;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;

namespace nalydmod.Items.Accessories
{
    [AutoloadEquip(EquipType.Wings)]
    public class Nalydwings : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nalyddd's Wings");
            Tooltip.SetDefault("You can feel the power of this new modder... hopefully");
        }



        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value =  1000000;
            item.rare = ItemRarityID.Expert;
            item.accessory = true;
            item.expert = true;
        }

        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.wingTimeMax = 280;
        }

        public override void VerticalWingSpeeds(Terraria.Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.85f;
            ascentWhenRising = 0.15f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 3f;
            constantAscend = 0.135f;         
        }

        public override void HorizontalWingSpeeds(Terraria.Player player, ref float speed, ref float acceleration)
        {
            speed = 9;
            acceleration = 2.5f;          
        }       
    }
}




