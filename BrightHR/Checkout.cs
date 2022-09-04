namespace BrightHR;
public class Checkout : ICheckout
{
    private readonly List<IStockKeepingUnit> _items = new();
    public int GetTotalPrice()
    {
        var price = 0;
        foreach (var item in _items)
        {
            price += item.Price;
        }
        return price;
    }

    public void Scan<T>(T item) where T : IStockKeepingUnit
    {
        ApplyDiscount(item);
        _items.Add(item);
    }

    private void ApplyDiscount<T>(T item) where T : IStockKeepingUnit
    {
        var numberOfItems = _items.Count(x => x is T) + 1;
        if (numberOfItems % item.SaleItem.NumberOfItems !=0 )
        {
            return;
        }
        var total = item.SaleItem.NumberOfItems * item.Price;
        var discountPrice = total - item.SaleItem.Discount;
        item.Price -= discountPrice;
    }
}
