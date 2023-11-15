using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//7. Gün
// SOLID
// Open Closed Principle
// Data Transformation Object

ProductManager productManager = new ProductManager(new EfProductDal());
CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

//foreach (var product in productManager.GetAll())
//{
//    Console.WriteLine(product.ProductName);
//}

//foreach (var product in productManager.GetAllByCategoryId(1))
//{
//	Console.WriteLine(product.ProductName);
//}

//foreach (var product in productManager.GetByUnitPrice(30, 50))
//{
//	Console.WriteLine(product.ProductName + "---" + product.UnitPrice);
//}

//foreach (var category in categoryManager.GetAll())
//{
//    Console.WriteLine(category.CategoryId + " " + category.CategoryName);
//}

//var category = categoryManager.GetById(1);
//Console.WriteLine(category.CategoryId + " " + category.CategoryName);

foreach (var product in productManager.GetProductDetails())
{
	Console.WriteLine(product.ProductName + " ||| " + product.CategoryName);
}
