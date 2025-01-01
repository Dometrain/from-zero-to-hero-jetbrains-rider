namespace ShoppingCartLib;

public interface IShoppingCart
{
    List<string> Get();
    void Add(string product);
}

public class ShoppingCart2 : IShoppingCart
{
    public List<string> Get()
    {
        throw new NotImplementedException();
    }

    public void Add(string product)
    {
        throw new NotImplementedException();
    }
}