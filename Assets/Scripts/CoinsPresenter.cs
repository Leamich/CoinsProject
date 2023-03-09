using UnityEngine;
using UnityEngine.UI;

public class CoinsPresenter : MonoBehaviour
{
    [SerializeField] private Text _render;
    [SerializeField] private Animator _animator;

    private CoinsModel _model;
    private Root _root;

    public void Init(CoinsModel model, Root root)
    {
        _model = model;
        _root = root;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Contains("Coin"))
            _root.OnPickupCoin();
    }

    public void OnPickupCoin()
    {
        _render.text = _model.GetText();
        _animator.SetTrigger("OnPickupCoin");
    }
}