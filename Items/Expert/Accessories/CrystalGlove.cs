using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Accessories
{
    public class CrystalGlove : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases Mining Speed by 20%\nIncreases melee damage and speed by 15%\nAll other damage increases by 8%\n'Looks painful to put on.'");
        }
        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 36;
            item.value = 20000;
            item.rare = ItemRarityID.Blue;
            item.expert = true;
            item.accessory = true;
        }
        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.pickSpeed *= 0.8f;
            player.meleeSpeed *= 1.15f;
            player.meleeDamageMult = 1.15f;
            player.rangedDamageMult = 1.08f;
            player.magicDamageMult = 1.08f;
            player.minionDamageMult = 1.08f;
        }
    }
}