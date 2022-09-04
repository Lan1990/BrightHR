namespace BrightHR;
public class StockKeepingUnitB : IStockKeepingUnit
{
    public int Price { get; set; } = 30;
    public SaleItem SaleItem { get; } = new SaleItem { NumberOfItems = 2, Discount = 45 };
 }
