using BrightHR;

namespace Tests;
public class CheckoutTests
{
    private readonly SkuFactory _defaultBuilder;
    public CheckoutTests()
    {
        _defaultBuilder = new SkuFactory(new Dictionary<string, SkuSetterModel> {
            { "a", new SkuSetterModel(50, 3, 130) },
            { "b", new SkuSetterModel(30, 2, 45) },

        });
    }

    [Fact]
    public void TotalPriceof2ItemsOfSkuA_Equals100()
    {
        Checkout checkout = new();
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        int result = checkout.GetTotalPrice();

        Assert.Equal(100, result);

    }

    [Fact]
    public void TotalPriceOf2SkuAItems_DoesNotEqual200()
    {
        Checkout checkout = new();
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        int result = checkout.GetTotalPrice();

        Assert.NotEqual(200, result);
    }

    [Fact]
    public void TotalPriceOf1SkuAItems_DoesNotEqual100()
    {
        Checkout checkout = new();
        checkout.Scan(_defaultBuilder.GetSku("a"));
        int result = checkout.GetTotalPrice();

        Assert.NotEqual(100, result);
    }


    [Fact]
    public void TotalPriceOf1SkuAItems_Equal50()
    {
        Checkout checkout = new();
        checkout.Scan(_defaultBuilder.GetSku("a"));
        int result = checkout.GetTotalPrice();

        Assert.Equal(50, result);
    }

    [Fact]
    public void TotalPriceOf11SkuB_Equals30()
    {
        Checkout checkout = new();
        checkout.Scan(_defaultBuilder.GetSku("b"));
        int result = checkout.GetTotalPrice();

        Assert.Equal(30, result);
    }

    [Fact]
    public void TotalPriceOf1SkuAAnd1SkuB_Equals80()
    {
        Checkout checkout = new();
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("b"));
        int result = checkout.GetTotalPrice();

        Assert.Equal(80, result);
    }

    [Fact]
    public void TotalPriceOf3SkuA_Equals130WithDiscount()
    {
        Checkout checkout = new();
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        int result = checkout.GetTotalPrice();

        Assert.Equal(130, result);
    }

    [Fact]
    public void TotalPriceOf2SkuB_Equals45WithDiscount()
    {
        Checkout checkout = new();
        checkout.Scan(_defaultBuilder.GetSku("b"));
        checkout.Scan(_defaultBuilder.GetSku("b"));
        int result = checkout.GetTotalPrice();

        Assert.Equal(45, result);
    }

    [Fact]
    public void TotalPriceOf2SkuBAnd1SkuA_Equals95WithDiscount()
    {
        Checkout checkout = new();
        checkout.Scan(_defaultBuilder.GetSku("b"));
        checkout.Scan(_defaultBuilder.GetSku("b"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        int result = checkout.GetTotalPrice();

        Assert.Equal(95, result);
    }

    [Fact]
    public void TotalPriceOf3SkuBAnd2SkuB_Equals175WithDiscount()
    {
        Checkout checkout = new();
        checkout.Scan(_defaultBuilder.GetSku("b"));
        checkout.Scan(_defaultBuilder.GetSku("b"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        int result = checkout.GetTotalPrice();

        Assert.Equal(175, result);
    }

    [Fact]
    public void ATotalOF6SkuAShould_Equals260WithDiscount()
    {
        Checkout checkout = new();
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        int result = checkout.GetTotalPrice();

        Assert.Equal(260, result);
    }

    [Fact]
    public void ATotalOF9SkuAShould_Equals390WithDiscount()
    {
        Checkout checkout = new();
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        checkout.Scan(_defaultBuilder.GetSku("a"));
        int result = checkout.GetTotalPrice();

        Assert.Equal(390, result);
    }

    [Fact]
    public void CanHandleBuyOneGetOneFree()
    {
        Checkout checkout = new();
        var builder = new SkuFactory(new Dictionary<string, SkuSetterModel> {
            { "a", new SkuSetterModel(50, 2, 50) }

        });
        checkout.Scan(builder.GetSku("a"));
        checkout.Scan(builder.GetSku("a"));
        int result = checkout.GetTotalPrice();

        Assert.Equal(50, result);
    }

}
