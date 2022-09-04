namespace BrightHR;

public interface IStockKeepingUnit
{
    int Price { get; set; }

    public SaleItem SaleItem { get; }
}