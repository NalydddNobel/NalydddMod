using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.HealthMana
{
    public class DDEmeraldShard : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Emerald Shard");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Heart);
            item.width = 8;
            item.height = 8;
        }
        public override bool CanBurnInLava()
        {
            return false;
        }
        public override bool ItemSpace(Player player)
        {
            return true;
        }
        public override void Update(ref float gravity, ref float maxFallSpeed)
        {
            gravity = 0.33f;
        }
        public override void PostUpdate()
        {
            Lighting.AddLight((int)(item.position.X / 16f), (int)(item.position.Y / 16f), 0, 0.35f, 0);
        }
        public override bool OnPickup(Player player)
        {
            if (Main.myPlayer == player.whoAmI)
            {
                player.HealEffect(6);
                player.ManaEffect(15);
            }
            player.statLife += 6;
            player.statMana += 15;
            item.active = false;
            return false;
        }
    }
}