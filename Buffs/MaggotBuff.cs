using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
namespace nalydmod.Buffs
{
    public class MaggotBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Hungry Maggot");
            Description.SetDefault("The hungry maggot will fight for you");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            MyPlayer modPlayer = player.GetModPlayer<MyPlayer>();
            if (player.ownedProjectileCounts[ProjectileType<Projectiles.Minions.HungryMaggot>()] > 0)
            {
                modPlayer.hungryMaggot = true;
            }
            if (!modPlayer.hungryMaggot)
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
            else
            {
                player.buffTime[buffIndex] = 18000;
            }
            modPlayer.smallSummon += player.ownedProjectileCounts[ProjectileType<Projectiles.Minions.HungryMaggot>()];
        }
    }
}