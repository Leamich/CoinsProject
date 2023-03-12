using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class CoinsPresenter : MonoBehaviour
{
    [SerializeField] private Text _render;
    [SerializeField] private Animator _animator;

    [Inject] private CoinsModel _model;

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