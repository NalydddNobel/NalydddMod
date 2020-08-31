using Microsoft.Xna.Framework;
using System.Security.AccessControl;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Npcs.Enemies.Slimes
{
    class MoonrockSlime : ModNPC
    {
        public override string Texture => "nalydmod/Npcs/Enemies/Slimes/BasicSpikedSlime";
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 2;
        }
        public override void SetDefaults()
        {
            npc.CloneDefaults(NPCID.GreenSlime);
            aiType = NPCID.GreenSlime;
            animationType = NPCID.GreenSlime;
            npc.damage = 120;
            npc.lifeMax = 2489;
            npc.defense = 23;
            npc.value = 5088;
            npc.knockBackResist = 0.12f;
            npc.color = Color.CadetBlue;
        }
        public override void NPCLoot()
        {

        }
        public override void ModifyHitByProjectile(Projectile projectile, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
                damage = 0;
                knockback = 0;
                crit = false;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (MyPlayer.LunarBiome == true)
            {
                return 2f;
            }
            else return 0;
        }
    }
}