namespace ShippoTests.Integration;

using Shippo;
using Shippo.Models.Requests;
using System.Collections.Generic;
using Shippo.Models.Components;

[Collection("Integration")]
public class Orders
{
    SDKFixture sdkFixture;

    public Orders(SDKFixture sdkFixture)
    {
        this.sdkFixture = sdkFixture;
    }

    [Fact]
    public async void TestListOrders()
    {
        ListOrdersRequest req = new ListOrdersRequest() {
            OrderStatus = new List<OrderStatusEnum>() {
                Shippo.Models.Components.OrderStatusEnum.Paid,
            },
            ShopApp = Shippo.Models.Components.OrderShopAppEnum.Shippo,
        };

        var orders = await sdkFixture.SDK.Orders.ListAsync(req);
    }
}