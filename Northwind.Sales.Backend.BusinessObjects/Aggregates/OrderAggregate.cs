
using Northwind.Sales.Backend.BusinessObjects.POCOEntities;
using Northwind.Sales.Backend.BusinessObjects.ValueObjects;
using Northwind.Sales.Entities.Dtos.CreateOrder;
using System.Timers;

namespace Northwind.Sales.Backend.BusinessObjects.Aggregates;
/// <summary>
/// Un agregado es un grupo de objetos de dominio que puede ser
/// tratados como una unidad. Por ejemplo:
/// Una orden con el detalle.
/// </summary>
public class OrderAggregate : Order
{
    //Encabezado de la orden
    //public Order order;
    //El auxiliar para el detalle de la orden
    readonly List<OrderDetaill> OrderDetailsField = [];
    //Detalle de la orden

    public IReadOnlyCollection<OrderDetaill> OrderDetaills => OrderDetailsField;
    //si en la orden se especifican productos con el mismo identificador de producto, solo se agergara un producto con ese identificador
    //y la cantidadregistrada sera la suma de las cantidades de los productos con el mismo identificador

    public void AddDetails(int productId, decimal unitprice, short quantity)
    {
        var ExistingOrderDetail = OrderDetailsField.FirstOrDefault(o => o.ProductId == productId);

        if (ExistingOrderDetail != default)
        {
            quantity += ExistingOrderDetail.Quantity;
            OrderDetailsField.Remove(ExistingOrderDetail);
        }
        OrderDetailsField.Add(new OrderDetaill(productId,unitprice,quantity));
    }
    public static OrderAggregate From(CreateOrderDto orderdto)
    {
        //Collection Expressions: c# 12 y permite inicializar la coleccion

        OrderAggregate orderAggregate = new OrderAggregate
        {
            CustomerId = orderdto.CustomerId,
            ShipAddress = orderdto.ShipAddress,
            ShipCity = orderdto.ShipCity,
            ShipCountry = orderdto.ShipCountry,
            ShipPostalCode = orderdto.ShipPostalCode,
        };
        foreach (var item in orderdto.OrderDetails)
        {
            //si en la orden se especifican productos con el mismo identificador de producto, solo se agergara un producto con ese identificador
            //y la cantidadregistrada sera la suma de las cantidades de los productos con el mismo identificador
            orderAggregate.AddDetails(item.ProductId,item.UnitPrice, item.Quantity);
        }
        return orderAggregate;
    }
}

