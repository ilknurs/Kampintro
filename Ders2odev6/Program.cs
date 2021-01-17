using System;

namespace Ders2odev6
{
    class Program
    {

    
    public static void Main(string[] args)
    {

        Products product1 = new Products();
        product1.ProductId = 1;
        product1.ProductName = "Jane Eyre - Charlotte Bronte"
  
    Products product2 = new Products();
        product2.ProductId = 2;
        product2.ProductName = "Sefiller - Victor Hugo"
  
    Products product3 = new Products();
        product3.ProductId = 3;
        product3.ProductName = "Martin Eden - Jack London"


// Ürünler diziye eklendi.
            Products[] products = new Products()
    {
      product1, product2,product3
    };

        // Ürünler for döngüsünde listelendi.
        Console.WriteLine("-- For Döngüsü --");
        for (i = 0; i < products.Length; i++)
        {
            Console.WriteLine("Product Id : " + products[i].ProductId + "Product Name : " + products[i].ProductName);
        }



        // Ürünler foreach döngüsünde listelendi.
        Console.WriteLine("-- Foreach döngüsü --");
        foreach (var product in products)
        {
            Console.WriteLine("Product Id : " + product.ProductId + "Product Name : " + product.ProductName);
        }


    }
}
}
class Products
{
    public string ProductName { get; set; }
    public int ProductId { get; set; }

}