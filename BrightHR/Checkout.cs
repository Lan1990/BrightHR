namespace BrightHR;
public class Checkout : ICheckout
{
    List<IStockKeepingUnit> Items = new List<IStockKeepingUnit>();
    public int GetTotalPrice()
    {
        var price = 0;
        foreach (var item in Items)
        {
            price += item.Price;
        }
        return price;
    }

    public void Scan(IStockKeepingUnit item)
    {
        Items.Add(item);
    }
}
