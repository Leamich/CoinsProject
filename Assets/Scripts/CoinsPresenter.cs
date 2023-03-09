using UnityEngine;
using UnityEngine.UI;

public class CoinsPresenter : MonoBehaviour
{
    [SerializeField] private Text _render;
    [SerializeField] private Animator _animator;

    private CoinsModel _model = new CoinsModel();

    private void Awake()
    {
        _model.Amount = PlayerPrefs.GetInt("Coins", 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Contains("Coin"))
            OnPickupCoin();
    }

    public void OnPickupCoin()
    {
        _model.OnPickupCoin();
        _render.text = _model.GetText();
        _animator.SetTrigger("OnPickupCoin");
        PlayerPrefs.SetInt("Coins", _model.Amount);
    }
}