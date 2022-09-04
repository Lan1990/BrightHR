namespace BrightHR;
internal interface ICheckout
{
    void Scan(IStockKeepingUnit item);
    int GetTotalPrice();

}
