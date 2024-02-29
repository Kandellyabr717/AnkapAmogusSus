public class CoinCounter : CoinText
{
    protected override void UpdateText(int coins) => _text.text = coins.ToString();
}