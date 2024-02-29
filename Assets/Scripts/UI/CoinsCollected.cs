using UnityEngine;

public class CoinsCollected : CoinText
{
    [SerializeField] private LevelData _levelData;

    protected override void UpdateText(int coins) => _text.text = $"You  collected  {coins}  out  of {_levelData.CoinsOnLevel}  coins  on  this  level";
}