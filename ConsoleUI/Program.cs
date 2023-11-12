using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//7. Gün
// SOLID
// Open Closed Principle

ProductManager productManager = new ProductManager(new EfProductDal());

//foreach (var product in productManager.GetAll())
//{
//    Console.WriteLine(product.ProductName);
//}

//foreach (var product in productManager.GetAllByCategoryId(1))
//{
//	Console.WriteLine(product.ProductName);
//}

foreach (var product in productManager.GetByUnitPrice(30, 50))
{
	Console.WriteLine(product.ProductName + "---" + product.UnitPrice);
}