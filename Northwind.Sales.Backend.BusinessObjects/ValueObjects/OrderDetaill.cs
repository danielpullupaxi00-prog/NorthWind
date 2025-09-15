
namespace Northwind.Sales.Backend.BusinessObjects.ValueObjects;

    /// <summary>
    /// Los value objects tienen 2 caractericticas principales:
    /// - No tienen identidad.
    /// - Son mutables
    /// </summary>
    /// <param name="productId"></param>
    /// <param name="unitPrice"></param>
    /// <param name="quantity"></param>
   
    public class OrderDetaill(int productId, decimal unitPrice, short quantity)
    {
    //public int ProductId { get;} = productId;
    public int ProductId => productId;
    public decimal UnitPrice => unitPrice;  
    public short Quantity => quantity;

    }

