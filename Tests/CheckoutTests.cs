using BrightHR;

namespace Tests;
public class CheckoutTests
{

    [Fact]
    public void TotalPriceof2ItemsOfSkuA_Equals50()
    { 
        Checkout checkout = new();
        checkout.Scan(new StockKeepingUnitA());
        checkout.Scan(new StockKeepingUnitA());
        int result = checkout.GetTotalPrice();

        Assert.Equal(50, result);

    }
}
