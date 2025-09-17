namespace Northwind.Sales.Backend.BusinessObjects.Interfaces.CreateOrder;

/// <summary>
/// Los puertos (Input, OutPort) son abstracciones (Interfaces) que permiten
/// al INTERACTOR del caso de uso (CreateOrder) recibir los datos de entrada y proporcionar
/// el resultado de caso de uso (CreateOrder)
/// 
/// El inputPort del caso de uso (CreateOrder) es una abstraccion que permite al INTERACTOR
/// recibir los datos necesarios para resolver el caso de uso(CreateOrder), estos datos
/// son proprcionados por algun elemento(objeto) de la capa externa (Controller).
/// Enterminos de POO, el InputPort puede ser definido usando una  intreface o una clase abstracta
/// que el INTERACTOR debe/tiene que implementar y el (Controller) debe/tiene que utilizar.
/// </summary>
public interface ICreateOrderInputPort
{
    Task Handle(CreateOrderDto orderDto);
}
