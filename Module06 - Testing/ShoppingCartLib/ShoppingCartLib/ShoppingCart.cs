namespace ShoppingCartLib;

public class ShoppingCart : IShoppingCart
{
    private readonly List<string> _items = [];

    public List<string> Get()
    {
        return _items;
    }

    public void Add(string product)
    {
        _items.Add(product);
    }
}