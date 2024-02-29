using System;

public class PlayerCoinPicker : PlayerStateChanger
{
    public int Coins { get => _coins; }

    private int _coins;

    public event Action<int> OnPlayerCoinPicked;

    public bool PickCoin(CoinTrigger self)
    {
        if (!ChangeState(self)) return false;
        _coins += 1;
        OnPlayerCoinPicked?.Invoke(_coins);
        return true;
    }
}