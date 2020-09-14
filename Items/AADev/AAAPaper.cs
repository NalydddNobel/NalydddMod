using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace nalydmod.Items.AADev
{
    public class AAAPaper : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Paper of Info");
            Tooltip.SetDefault("[c/00ffdd:Right Click] to change the page\n1 / " +
                nalydmod.pages +
                " pages");
        }
        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<AAAPaper2>());
        }
    }
    public class AAAPaper2 : ModItem
    {
        public override string Texture => "nalydmod/Items/AADev/AAAPaper";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Paper of Info");
            Tooltip.SetDefault("This paper contains random [c/00ffdd:info] and [c/00ffdd:tips] for this mod\n2 / " +
                nalydmod.pages +
                " pages");
        }
        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<AAAPaper3>());
        }
    }
    public class AAAPaper3 : ModItem
    {
        public override string Texture => "nalydmod/Items/AADev/AAAPaper";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Paper of Info");
            Tooltip.SetDefault("Tip: [c/00ffdd:Small Summons] dont use regular [c/00ffdd:minion slots], this system is kinda buggy in certain situations\n3 / " +
                nalydmod.pages +
                " pages");
        }
        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<AAAPaper4>());
        }
    }
    public class AAAPaper4 : ModItem
    {
        public override string Texture => "nalydmod/Items/AADev/AAAPaper";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Paper of Info");
            Tooltip.SetDefault("Tip: Most of the [c/00ffdd:content] is [c/00ffdd:expert only]\n4 / " +
                nalydmod.pages +
                " pages");
        }
        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<AAAPaper5>());
        }
    }
    public class AAAPaper5 : ModItem
    {
        public override string Texture => "nalydmod/Items/AADev/AAAPaper";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Paper of Info");
            Tooltip.SetDefault("Tip: [c/00ffdd:Fractalite] is a very [c/00ffdd:rare ore] that can be found [c/00ffdd:deep underground]\n5 / " +
                nalydmod.pages +
                " pages");
        }
        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<AAAPaper6>());
        }
    }
    public class AAAPaper6 : ModItem
    {
        public override string Texture => "nalydmod/Items/AADev/AAAPaper";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Paper of Info");
            Tooltip.SetDefault("Info: This [c/00ffdd:mod] is [c/00ffdd:unfinished] and is my [c/00ffdd:first mod]\n6 / " +
                nalydmod.pages +
                " pages");
        }
        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<AAAPaper7>());
        }
    }
    public class AAAPaper7 : ModItem
    {
        public override string Texture => "nalydmod/Items/AADev/AAAPaper";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Paper of Info");
            Tooltip.SetDefault("Info: Almost all [c/00ffdd:sprites] are made by [c/00ffdd:me].\n7 / " +
                nalydmod.pages +
                " pages");
        }
        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<AAAPaper8>());
        }
    }
    public class AAAPaper8 : ModItem
    {
        public override string Texture => "nalydmod/Items/AADev/AAAPaper";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Paper of Info");
            Tooltip.SetDefault("Tip: 2 [c/00ffdd:faded lenses] can be used to create [c/00ffdd:corrupt seeds]." +
                "\n2 [c/00ffdd:bloodied lenses] can be used to create [c/00ffdd:crimson seeds]." +
                "\n2 [c/00ffdd:spectrum eyes] can be used to create [c/00ffdd:hallowed seeds]" +
                "\nThis allows for [c/00ffdd:corruption] and [c/00ffdd:crimson] to be in the same world without multiple worlds" +
                "\nThis also allows for the [c/00ffdd:prehardmode] hallow without multiple worlds\n8 / " +
                nalydmod.pages +
                " pages");
        }
        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<AAAPaper9>());
        }
    }
    public class AAAPaper9 : ModItem
    {
        public override string Texture => "nalydmod/Items/AADev/AAAPaper";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Paper of Info");
            Tooltip.SetDefault("Tip: Hardmode items like [c/00ffdd:souls of night] can be collected in [c/00ffdd:prehardmode]" +
                "\nKilling [c/00ffdd:rare] enemies in their respective [c/00ffdd:biomes] will make them drop [c/00ffdd:souls]\n9 / " +
                nalydmod.pages +
                " pages");
        }
        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<AAAPaper10>());
        }
    }
    public class AAAPaper10 : ModItem
    {
        public override string Texture => "nalydmod/Items/AADev/AAAPaper";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Paper of Info");
            Tooltip.SetDefault("Tip: This mod is very [c/00ffdd:unfinished], especially this update as I have published it before [c/00ffdd:finishing] it\n10 / " +
                nalydmod.pages +
                " pages");
        }
        public override void SetDefaults()
        {
            item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ModContent.ItemType<AAAPaper>());
        }
    }
}