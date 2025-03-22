using System;

public class Warehouse
{
    public string ProductName { get; set; }
    public string Unit { get; set; }
    public Money Price { get; set; }
    public int Quantity { get; set; }
    public DateTime LastArrivalDate { get; set; }

    public Warehouse(string productName, string unit, Money price, int quantity, DateTime lastArrivalDate)
    {
        ProductName = productName;
        Unit = unit;
        Price = price;
        Quantity = quantity;
        LastArrivalDate = lastArrivalDate;
    }

    public void DisplayStock()
    {
        Console.WriteLine($"Продукт: {ProductName}, Одиниця виміру: {Unit}, Ціна: {Price.Whole} грн {Price.Cents} коп., Кількість: {Quantity}, Дата останнього завозу: {LastArrivalDate.ToShortDateString()}");
    }
}
