namespace BrightHR;
public class Checkout : ICheckout
{
    private readonly List<StockKeepingUnit> _items = new();
    public int GetTotalPrice()
    {
        var price = 0;
        foreach (var item in _items)
        {
            price += item.Price;
        }
        return price;
    }

    public void Scan(StockKeepingUnit item)
    {
        ApplyDiscount(item);
        _items.Add(item);
    }

    private void ApplyDiscount(StockKeepingUnit item) 
    {
        var numberOfItems = _items.Count(x => x.Name == item.Name) + 1;
        if (item.SaleItem.NumberOfItems != 0 && numberOfItems % item.SaleItem.NumberOfItems !=0 )
        {
            return;
        }
        var total = item.SaleItem.NumberOfItems * item.Price;
        var discountPrice = total - item.SaleItem.Discount;
        item.Price -= discountPrice;
    }
}
