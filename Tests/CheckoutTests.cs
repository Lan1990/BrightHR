using BrightHR;

namespace Tests;
public class CheckoutTests
{

    [Fact]
    public void TotalPriceof2ItemsOfSkuA_Equals100()
    { 
        Checkout checkout = new();
        checkout.Scan(new StockKeepingUnitA());
        checkout.Scan(new StockKeepingUnitA());
        int result = checkout.GetTotalPrice();

        Assert.Equal(100, result);

    }

    [Fact]
    public void TotalPriceOf2SkuAItems_DoesNotEqual200()
    {
        Checkout checkout = new();
        checkout.Scan(new StockKeepingUnitA());
        checkout.Scan(new StockKeepingUnitA());
        int result = checkout.GetTotalPrice();

        Assert.NotEqual(200, result);
    }

    [Fact]
    public void TotalPriceOf1SkuAItems_DoesNotEqual100()
    {
        Checkout checkout = new();
        checkout.Scan(new StockKeepingUnitA());
        int result = checkout.GetTotalPrice();

        Assert.NotEqual(100, result);
    }


    [Fact]
    public void TotalPriceOf1SkuAItems_Equal50()
    {
        Checkout checkout = new();
        checkout.Scan(new StockKeepingUnitA());
        int result = checkout.GetTotalPrice();

        Assert.Equal(50, result);
    }
}
