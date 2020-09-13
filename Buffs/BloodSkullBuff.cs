using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
namespace nalydmod.Buffs
{
    public class BloodSkullBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Blood Skull");
            Description.SetDefault("The bloody skull will fight for you");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            MyPlayer modPlayer = player.GetModPlayer<MyPlayer>();
            if (player.ownedProjectileCounts[ProjectileType<Projectiles.Minions.TissueSkull>()] > 0)
            {
                modPlayer.bloodSkull = true;
            }
            if (!modPlayer.bloodSkull)
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
            else
            {
                player.buffTime[buffIndex] = 18000;
            }
        }
    }
}