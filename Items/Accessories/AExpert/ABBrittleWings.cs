using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Accessories.AExpert
{
    [AutoloadEquip(EquipType.Wings)]
    public class ABBrittleWings : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brittle Wings");
            Tooltip.SetDefault("Allows flight and slow fall\nExpert");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 30;
            item.value = 20000;
            item.rare = ItemRarityID.Blue;
            item.accessory = true;
        }
        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.wingTimeMax = 35;
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
            speed = 4.56f;
            acceleration = 0.258f;
        }
    }
}