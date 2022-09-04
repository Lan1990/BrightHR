namespace BrightHR;
public class SkuFactory
{
    private readonly Dictionary<string, SkuSetterModel> _prices = new();
    public SkuFactory(Dictionary<string, SkuSetterModel> prices)
    {
        _prices = prices;
    }

    public StockKeepingUnit GetSku(string sku)
    {
        var found = _prices.TryGetValue(sku, out var setter);
        if (!found || setter == null)
        {
            return new StockKeepingUnit();
        } 
        return new StockKeepingUnit()
        {
            Name = sku,
            Price = setter.Price,
            SaleItem = new SaleItem
            {
                Discount = setter.DiscountPrice,
                NumberOfItems = setter.NumberForDiscount
            }
        };
    }
}

