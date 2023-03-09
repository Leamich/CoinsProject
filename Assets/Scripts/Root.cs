using UnityEngine;
using UnityEngine.Analytics;

public class Root : MonoBehaviour
{
    [SerializeField] private CoinsPresenter _coinsPresenter;

    private CoinsModel _coinsModel;

    private void Awake()
    {
        _coinsModel = new CoinsModel(PlayerPrefs.GetInt("Coins", 0));
        _coinsPresenter.Init(_coinsModel, this);
    }

    public void OnPickupCoin()
    {
        _coinsModel.OnPickupCoin();
        _coinsPresenter.OnPickupCoin();
        PlayerPrefs.SetInt("Coins", _coinsModel.Amount);
    }
}
