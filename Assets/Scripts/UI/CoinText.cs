using TMPro;
using UnityEngine;

public abstract class CoinText : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI _text;
    [SerializeField] protected PlayerCoinPicker _playerCoinPicker;

    private void OnEnable() => _playerCoinPicker.OnPlayerCoinPicked += UpdateText;

    private void OnDisable() => _playerCoinPicker.OnPlayerCoinPicked -= UpdateText;

    private void OnDestroy() => _playerCoinPicker.OnPlayerCoinPicked -= UpdateText;

    protected abstract void UpdateText(int coins);
}