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

    [Fact]
    public void TotalPriceOf11SkuB_Equals30()
    {
        Checkout checkout = new();
        checkout.Scan(new StockKeepingUnitB());
        int result = checkout.GetTotalPrice();

        Assert.Equal(30, result);
    }

    [Fact]
    public void TotalPriceOf1SkuAAnd1SkuB_Equals80()
    {
        Checkout checkout = new();
        checkout.Scan(new StockKeepingUnitA());
        checkout.Scan(new StockKeepingUnitB());
        int result = checkout.GetTotalPrice();

        Assert.Equal(80, result);
    }

    [Fact]
    public void TotalPriceOf3SkuA_Equals130WithDiscount()
    {
        Checkout checkout = new();
        checkout.Scan(new StockKeepingUnitA());
        checkout.Scan(new StockKeepingUnitA());
        checkout.Scan(new StockKeepingUnitA());
        int result = checkout.GetTotalPrice();

        Assert.Equal(130, result);
    }

}
