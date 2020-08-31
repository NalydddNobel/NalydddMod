using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.ZCheat
{
    public class AccessoryV0 : ModItem
    {
        public override string Texture => "nalydmod/Items/Materials/GemFragments/BasicFragment";
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("1000% Damage Increase\n+ 1000 Health\n+200 Mana");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.AdhesiveBandage);
            item.rare = 1;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statManaMax2 += 200;
            player.statLifeMax2 += 1000;
            player.allDamageMult = 10;
        }
    }
}