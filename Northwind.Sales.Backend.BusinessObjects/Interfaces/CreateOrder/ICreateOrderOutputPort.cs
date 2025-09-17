
//using Northwind.Sales.Backend.BusinessObjects.Aggregates;

namespace Northwind.Sales.Backend.BusinessObjects.Interfaces.CreateOrder;
/// <summary>
/// El outport del caso de uso (CreateOrder) es una abstraccion que permite al INTERACTOR
/// devolverel resultado del caso de uso (CreateOrder) a un elemnto de la capa externa (Presentar).
/// En terminos de POO, el OutPort puede ser definido usando una interface o una clase abstracta
/// y que el PRESENTER debe/tiene implementar y el INTERACTOR debe/tiene que utilizar
/// El outport que se define a continuacion recibe una instancia de la oden que se vaya a agregar
/// La funcion de PRESENTER es la de convertir los datos del formato mas conveniente al formato mas conveniente 
/// para algun agete externo como: la base de datos, una pagina web, app movil, app de escritorio, web api.
/// Para el ejemplo (CreateOrder) el PRESENTER simplemente va a devolver el id (OrderId) de la orden creada.
/// </summary>
public interface ICreateOrderOutputPort
{
    //Retornar el numero de orden creado que lo utiliza al presentar
    int OrderId { get; }
    Task Handle(OrderAggregate addedOrder);
}
