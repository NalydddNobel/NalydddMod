using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nalydmod.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class GeodeWormMask : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Vanity Item");
        }
        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.rare = 1;
        }
    }
}