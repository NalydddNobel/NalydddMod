using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Expert.Accessories
{
    [AutoloadEquip(EquipType.Wings)]
    public class BrittleWings : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brittle Wings");
            Tooltip.SetDefault("It feels like it can fall apart any second\nExpert");
        }
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.value = 20000;
            item.rare = ItemRarityID.White;
            item.accessory = true;
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
    }
}




