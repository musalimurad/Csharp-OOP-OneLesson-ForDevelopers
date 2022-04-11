using OOP1;



Product productOne = new()
{
    Id = 1,
    CategoryId = 1,
    ProductName = "Iphone",
    UnitPrice = 1200,
    UnitsInStock = 5
};

Product productTwo = new()
{
    Id = 2,
    CategoryId = 1,
    ProductName = "Samsung",
    UnitPrice = 700,
    UnitsInStock = 10
};

ProductManager.Add(productOne);
ProductManager.Update(productTwo);
ProductManager.Delete(productOne);
