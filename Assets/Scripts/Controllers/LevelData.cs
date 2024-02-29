using UnityEngine;

public class LevelData : MonoBehaviour
{
    [SerializeField] private int _coinsOnLevel;
    
    public int CoinsOnLevel { get => _coinsOnLevel; }
}