namespace ShippoTests.Integration;

using Shippo;
using OrderStatusEnum = Shippo.Models.Components.OrderStatusEnum;
using Address = Shippo.Models.Components.Address;
using Transactions = Shippo.Models.Components.Transactions;

[Collection("Integration")]
public class OrdersTest
{
    SDKFixture sdkFixture;

    public OrdersTest(SDKFixture sdkFixture)
    {
        this.sdkFixture = sdkFixture;
    }

    [Fact]
    public async void TestListOrders()
    {
        ListOrdersRequest req = new ListOrdersRequest() {
            OrderStatus = new List<OrderStatusEnum>() {
                OrderStatusEnum.Paid,
            },
            ShopApp = OrderShopAppEnum.Shippo,
        };

        var orders = await sdkFixture.SDK.Orders.ListAsync(req);

        orders.Should().NotBeNull();
        orders.Results.Should().NotBeNull()
            .And.BeOfType<List<Order>>();
        orders.Results.Should().AllSatisfy(order =>
        {
            order.OrderStatus.Should().Be(OrderStatusEnum.Paid);
            order.Should().NotBeNull();
            order.ObjectId.Should().BeOfType<string>();
            order.ToAddress.Should().BeOfType<Address>();
            order.FromAddress.Should().BeOfType<Address>();
            order.Transactions.Should().BeOfType<List<Transactions>>();
        });
    }
}