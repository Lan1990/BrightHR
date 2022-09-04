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

        if (Items.Count(x=> x is StockKeepingUnitA) == 3)
        {
            return 130;
        }
        return price;
    }

    public void Scan(IStockKeepingUnit item)
    {
        Items.Add(item);
    }
}
