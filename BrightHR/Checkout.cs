namespace BrightHR;
public class Checkout : ICheckout
{
    List<StockKeepingUnitA> Items = new List<StockKeepingUnitA>();
    public int GetTotalPrice()
    {
        var price = 0;
        foreach (var item in Items)
        {
            price += item.Price;
        }
        return price;
    }

    public void Scan(StockKeepingUnitA item)
    {
        Items.Add(item);
    }
}
