namespace BrightHR;
internal interface ICheckout
{
    void Scan(StockKeepingUnitA item);
    int GetTotalPrice();

}
