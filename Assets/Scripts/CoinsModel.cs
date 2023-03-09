public class CoinsModel
{
    private int _amount = 0;

    public int Amount
    {
        get { return _amount; }
        set
        {
            if(value >= 0) _amount = value;
        }
    }

    public string GetText()
    {
        return $"Coins: {_amount}";
    }

    public void OnPickupCoin()
    {
        _amount++;
    }
    public bool TryDiscard(int price)
    {
        if (_amount < price)
            return false;

        _amount -= price;
        return true;
    }
}
