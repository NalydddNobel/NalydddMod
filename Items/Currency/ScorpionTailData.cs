using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI;

namespace nalydmod
{
    public class CustomCurrencyData : CustomCurrencySingleCoin
    {
        public Color CustomCurrencytextcolor = Color.Orange; //this defines the Custom Currency Buy Price color when shown in the shoop

        public CustomCurrencyData(int coinItemID, long currencyCap) : base(coinItemID, currencyCap)
        {

        }

        public override void GetPriceText(string[] lines, ref int currentLine, int price)
        {
            Color color = CustomCurrencytextcolor * (Main.mouseTextColor / 255f);
            lines[currentLine++] = string.Format("[c/{0:X2}{1:X2}{2:X2}:{3} {4} {5}]", new object[]
                {
                    color.R,
                    color.G,
                    color.B,
                    price,
                    "Scorpion Tail" //this is the Currency name when shown in the shop
                });
        }
    }
}