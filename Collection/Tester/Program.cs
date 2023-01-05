
using CollectionSorting;
using System.Collections;


List<Product> list=new List<Product>();

list.Add(new Product(){id=4,name="Facewash",price=250});
list.Add(new Product(){id=3,name="ToothPaste",price=500});
list.Add(new Product(){id=2,name="Perfume",price=200});
Console.WriteLine("List of Products Before Sorting");

foreach(Product prod in list)
{
    Console.WriteLine(prod);
}

Console.WriteLine("List of Products After Sorting by Price");
ProdComparer newprod=new ProdComparer();
list.Sort(newprod);
foreach(Product prod in list)
{
    Console.WriteLine(prod);
}

Console.WriteLine("List of Products After Sorting by ID");
list.Sort();
foreach(Product prod in list)
{
    Console.WriteLine(prod);
}
