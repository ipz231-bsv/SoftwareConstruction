using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Money money1 = new Money(100, 50);
        Money money2 = new Money(200, 75);

        Console.WriteLine("Тестування класу Money:");
        money1.DisplayAmount();
        money2.DisplayAmount();
        Console.WriteLine();

        Product product1 = new Product("Продукт 1", money1);
        Product product2 = new Product("Продукт 2", money2);

        Console.WriteLine("Тестування класу Product:");
        product1.DisplayProduct();
        product2.DisplayProduct();
        Console.WriteLine();

        Warehouse warehouse1 = new Warehouse("Продукт 1", "шт", money1, 50, DateTime.Now);
        Warehouse warehouse2 = new Warehouse("Продукт 2", "кг", money2, 30, DateTime.Now);

        Console.WriteLine("Тестування класу Warehouse:");
        warehouse1.DisplayStock();
        warehouse2.DisplayStock();
        Console.WriteLine();

        Reporting reporting = new Reporting();
        reporting.AddItemToWarehouse(warehouse1);
        reporting.AddItemToWarehouse(warehouse2);

        Console.WriteLine("Тестування класу Reporting (Звіт по інвентаризації):");
        reporting.GenerateInventoryReport();
        Console.WriteLine();

        product1.Discount(50);
        Console.WriteLine("Після знижки:");
        product1.DisplayProduct(); 

        Console.ReadKey();
    }
}
