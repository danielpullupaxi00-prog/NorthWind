
//using Northwind.Sales.Backend.BusinessObjects.Common.Interfaces;

namespace Northwind.Sales.Backend.BusinessObjects.Interfaces.Repositories;

/// <summary>
/// El patron "Repository" es un patros de disño de software que utliza con fuente de datos.
/// Este patron permite separar la logica de negocios de la logicq de acceso/recuperacion de datos
/// y los asigna a un modelo de entidad (EntityFramework Core, adonet, Dapper)
/// Un "Repository" es una capa intermedia entre la capa de dominio (Uses Cases) y las capas de 
/// mapeo de datos y actua como una intermediario como una coleccion de objetos en memoria de la PC.
/// La implementacion un "Repository" en una clase que permite ocultar la logica necesaria 
/// almacenar (Insert, Update, Delete) o recuperar datos(select). Por lo tanto al utilizar el
/// patron "repository" a la aplicacion no le importa que tipo de ORM se utilice ya que todo lo
/// relacionado con el uso del ORM se maneja dentro de la capa del "Repositorio". 
/// Esto permite tener una separacion mas limpia de responsabilidades  
/// </summary>

public interface ICommandsRepository : IUnitOfWork
{
    Task CreateOrder(OrderAggregate order);
    //Task InsertOrder(OrderAggregate order);
    //Task DeleteOrder(OrderAggregate order);
    //Task UpdateOrder(OrderAggregate order);
}
