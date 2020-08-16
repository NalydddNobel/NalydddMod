using nalydmod;
using nalydmod.Items.Accessories;
using nalydmod.Items.Materials;
using nalydmod.Items.Materials.Expert;
using nalydmod.Items.Weapons;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace nalydmod.Items.Global
{
	public class BossBags : GlobalItem
	{
		public override void OpenVanillaBag(string context, Player player, int arg)
		{
			// This method shows adding items to Fishrons boss bag. 
			// Typically you'll also want to also add an item to the non-expert boss drops, that code can be found in ExampleGlobalNPC.NPCLoot. Use this and that to add drops to bosses.
			if (context == "bossBag" && arg == ItemID.KingSlimeBossBag)
			{
				player.QuickSpawnItem(ItemType<SlimyBar>(), Main.rand.Next(40, 60));
				player.QuickSpawnItem(ItemType<SoulofSlime>(), Main.rand.Next(20, 35));
				player.QuickSpawnItem(ItemType<RoyalGel>(), Main.rand.Next(12, 25));
				player.QuickSpawnItem(ItemType<BrittleWings>());
				if (Main.rand.Next(5) == 0)
			    {
					player.QuickSpawnItem(ItemType<SlimeShortsword>());
				}
				if (Main.rand.Next(5) == 0)
				{
					player.QuickSpawnItem(ItemType<SlimeShooter>());
				}
				if (Main.rand.Next(5) == 0)
				{
					player.QuickSpawnItem(ItemType<SlimeSniper>());
				}
				if (Main.rand.Next(5) == 0)
				{
					player.QuickSpawnItem(ItemType<SlimeTome>());
				}
				if (Main.rand.Next(5) == 0)
				{
					player.QuickSpawnItem(ItemType<SlimeStaffx>());
				}
				if (Main.rand.Next(5) == 0)
				{
					player.QuickSpawnItem(ItemID.SlimeStaff);
				}
			}
			if (context == "bossBag" && arg == ItemID.CultistBossBag)
			{
				player.QuickSpawnItem(ItemType<Nalydwings>());
			}
		}
	}
}