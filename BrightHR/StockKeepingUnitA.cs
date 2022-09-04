namespace BrightHR;
public class StockKeepingUnitA : IStockKeepingUnit
{
    public int Price { get; set; } = 50;

    public SaleItem SaleItem { get; } = new SaleItem { Discount = 130, NumberOfItems = 3 };
}
