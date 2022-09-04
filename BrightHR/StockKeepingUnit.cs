namespace BrightHR;
public class StockKeepingUnit : IStockKeepingUnit
{
    internal StockKeepingUnit()
    {

    }

    public string Name { get; set; }

    public int Price { get; set; }

    public SaleItem SaleItem { get; set; } = new SaleItem();
}
