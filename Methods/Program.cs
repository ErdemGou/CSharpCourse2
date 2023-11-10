using Methods;

internal class Program
{
    private static void Main(string[] args)
    {
        string urunAdi = "Elma";
        double fiyati = 15;
        string aciklama = "Amasya Elması";

        string[] meyveler = new string[] { "Elma", "Karpuz"};

        Product product1 = new Product();
        product1.Name = "Elma";
        product1.Price = 15;
        product1.Description = "Amasya elması";

        Product product2 = new Product();
        product2.Name = "Karpuz";
        product2.Price = 80;
        product2.Description = "Diyarbakır karpuzu";

        Product[] products = new Product[] { product1, product2 };

        //Type safe -- Tip Güvenli
        foreach (Product product in products)
        {
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
            Console.WriteLine(product.Description);
            Console.WriteLine("------------------");
        }

        Console.WriteLine("-------------Methods-------------");

        //instance - örnek
        //encapsulation

        BasketManager basketManager = new BasketManager();
        basketManager.Add(product1);
        basketManager.Add(product2);

        basketManager.Add2("Armut", "Yeşil armut", 12, 10);
        basketManager.Add2("Elma", "Yeşil elma", 12, 9);
        basketManager.Add2("Karpuz", "Diyarbakır karpuzu", 12, 8);
    }
}


//Dont repeat yourself - DRY - Clean Code - Best Practice