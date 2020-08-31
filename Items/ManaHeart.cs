using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items
{
    public class ManaHeart : ModItem
    {
        public override void SetDefaults()
        {
            Item.lifeGrabRange = 5000;
            Item.manaGrabRange = 5000;
            item.CloneDefaults(ItemID.Heart);
            item.rare = 10;
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
            return true;
        }
    }
}