using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.BossSummons
{
    public class FFInfSkull : ModItem
    {
        public static bool itemBuffedSkeletron;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skull-shaped Matter");
            Tooltip.SetDefault("Summons a buffed Skeletron during the night.\nSummons a Dungeon Gaurdian during the day.\nCan be used infinitly.\nExpert\n(Skeletron's ai sometimes makes him despawn when he spawns)");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.SuspiciousLookingEye);
            item.consumable = false;
            item.maxStack = 1;
            item.rare = 2;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("EESoulofSpine"), 30);
            recipe.AddIngredient(mod.ItemType("HHSoulofAxiom"), 30);
            recipe.AddIngredient(ItemID.Bone, 100);
            recipe.AddIngredient(ItemID.RedHat);
            recipe.AddIngredient(ItemID.BoneGlove);
            recipe.AddIngredient(ItemID.ClothierVoodooDoll);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool CanUseItem(Terraria.Player player)
        {
            if (Terraria.Main.dayTime)
            {
                return !Terraria.NPC.AnyNPCs(NPCID.DungeonGuardian);
            }
            if (!Terraria.Main.dayTime)
            {               
                return !Terraria.NPC.AnyNPCs(NPCID.SkeletronHead);
            }
            return false;
        }
        public override bool UseItem(Terraria.Player player)
        {
            if (Terraria.Main.dayTime)
            {
                Terraria.NPC.SpawnOnPlayer(player.whoAmI, NPCID.DungeonGuardian);
            }
            if (!Terraria.Main.dayTime)
            {
                Terraria.NPC.SpawnOnPlayer(player.whoAmI, NPCID.SkeletronHead);
                itemBuffedSkeletron = true;
            }
            Terraria.Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}