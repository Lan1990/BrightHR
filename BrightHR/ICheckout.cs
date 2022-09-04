namespace BrightHR;
internal interface ICheckout
{
    void Scan<T>(T item) where T: IStockKeepingUnit ;
    int GetTotalPrice();

}
