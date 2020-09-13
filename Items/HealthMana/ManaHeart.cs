using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.HealthMana
{
    public class ManaHeart : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Heart);
            item.rare = 1;
        }
        public override bool ItemSpace(Player player)
        {
            return true;
        }
        public override bool OnPickup(Player player)
        {
            if (Main.myPlayer == player.whoAmI)
            {
                player.HealEffect(10);
                player.ManaEffect(50);
            }
            player.statLife += 10;
            player.statMana += 50;
            item.active = false;
            return false;
        }
    }
}