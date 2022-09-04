namespace BrightHR;
internal interface ICheckout
{
    void Scan(StockKeepingUnit item);
    int GetTotalPrice();

}
