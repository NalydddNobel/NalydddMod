using Terraria.ModLoader;
namespace nalydmod.Items.Accessories.AExpert.ABoss
{
    [AutoloadEquip(EquipType.HandsOn)]
    public class FFMagicChannel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Alien Magical Channel");
            Tooltip.SetDefault("Reduces damage from alien creatures.");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.value = 20000;
            item.expert = true;
            item.accessory = true;
        }
        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            MyPlayer.spaceAccessory = true;
        }
    }
}