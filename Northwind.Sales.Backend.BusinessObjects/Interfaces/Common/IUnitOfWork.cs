namespace Northwind.Sales.Backend.BusinessObjects.Common.Interfaces;

/// <summary>
/// El esta patron de software permite 
/// 1)confirmar los cambios (INSERT, UPDATE, DELETE) en la fuente 
/// de datos (DB relacional, No Sql, Json, texto, etc.) lo que garantiza una
/// TRANSACCIO COMPLETA, sin perdida de datos, es decir de forma atomica
/// 2) Tambien permite resolver conflictos de concurrencia
/// </summary>
internal interface IUnitOfWork
{
    //El metodo regresa un task que permite que la implementacion pueda ser: sincronica o asincronica.
    Task SaveChanges();
}
