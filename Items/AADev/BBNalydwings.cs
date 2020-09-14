using Terraria.ModLoader;
namespace nalydmod.Items.AADev
{
    [AutoloadEquip(EquipType.Wings)]
    public class BBNalydwings : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nalyddd's Wings");
            Tooltip.SetDefault("You can feel the power of this new modder... hopefully\nExpert");
        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 26;
            item.value = 1000000;
            item.rare = 10;
            item.accessory = true;
        }
        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.wingTimeMax = 320;
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
            speed = 8;
            acceleration = 1.22f;
        }
    }
}