using Terraria.ModLoader;
namespace nalydmod.Items.Expert.Accessories
{
    public class MagicChannel : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }
        public override void SetStaticDefaults()
        {
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