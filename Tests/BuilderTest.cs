using BrightHR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests;
public class BuilderTest
{

    [Fact]
    public void GetSkuThatDoesNotExist_ReturnEmptySku()
    {
        Checkout checkout = new();
        var builder = new SkuFactory(new Dictionary<string, SkuSetterModel> {
            { "a", new SkuSetterModel(50, 3, 130) },
            { "b", new SkuSetterModel(30, 2, 45) },

        });
        checkout.Scan(builder.GetSku("r"));
        int result = checkout.GetTotalPrice();

        Assert.Equal(0, result);
    }
}
