using nalydmod.NPCs.ItemDrops;
using Terraria;
using Terraria.ModLoader;
namespace nalydmod.Buffs
{
    public class DeadlyFlamesDeBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Deadly Flames");
            Description.SetDefault("'The blue flames are cold'");
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = true;
            canBeCleared = false;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<MyPlayer>().deadlyFlames = true;
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<Global>().deadlyFlames = true;
        }
    }
}