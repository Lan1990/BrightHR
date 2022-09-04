namespace BrightHR;
public class StockKeepingUnit 
{
    internal StockKeepingUnit()
    {

    }

    public string Name { get; set; } = string.Empty;

    public int Price { get; set; }

    public SaleItem SaleItem { get; set; } = new SaleItem();
}
