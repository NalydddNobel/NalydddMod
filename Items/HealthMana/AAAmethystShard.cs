using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.HealthMana
{
    public class AAAmethystShard : ModItem
    {
        int age;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amethyst Shard");
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
            age++;
            if (age > 600)
            {
                item.active = false;
            }
            item.alpha = age / 2;
            Lighting.AddLight((int)(item.position.X / 16f), (int)(item.position.Y / 16f), 0.3f - (age * 0.0005f), 0, 0.3f - (age * 0.0005f));
        }
        public override bool OnPickup(Player player)
        {
            if (Main.myPlayer == player.whoAmI)
            {
                player.HealEffect(2);
                player.ManaEffect(8);
            }
            player.statLife += 5;
            player.statMana += 5;
            item.active = false;
            return false;
        }
    }
}