using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.HealthMana
{
    public class CCSapphireShard : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sapphire Shard");
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
            Lighting.AddLight((int)(item.position.X / 16f), (int)(item.position.Y / 16f), 0, 0, 0.25f);
        }
        public override bool OnPickup(Player player)
        {
            if (Main.myPlayer == player.whoAmI)
            {
                player.HealEffect(4);
                player.ManaEffect(12);
            }
            player.statLife += 4;
            player.statMana += 12;
            item.active = false;
            return false;
        }
    }
}