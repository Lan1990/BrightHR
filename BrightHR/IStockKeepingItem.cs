namespace BrightHR;

public interface IStockKeepingUnit
{
    public string Name { get; set; }
    int Price { get; set; }

    public SaleItem SaleItem { get; }
}