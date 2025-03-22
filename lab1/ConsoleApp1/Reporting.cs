using System;
using System.Collections.Generic;

public class Reporting
{
    public List<Warehouse> WarehouseItems { get; set; }

    public Reporting()
    {
        WarehouseItems = new List<Warehouse>();
    }

    public void AddItemToWarehouse(Warehouse warehouseItem)
    {
        WarehouseItems.Add(warehouseItem);
        Console.WriteLine($"Товар {warehouseItem.ProductName} додано на склад.");
    }

    public void GenerateInventoryReport()
    {
        Console.WriteLine("Звіт по інвентаризації:");
        foreach (var item in WarehouseItems)
        {
            item.DisplayStock();
        }
    }
}
