using System;

public class Book : IPriceable, IDiscountable
{
    public double Price { get; private set; }

    public void SetPrice(double price)
    {
        Price = price;
        Console.WriteLine($"Book price set to {price}");
    }

    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Discount '{discount}' applied to the book.");
    }

    public void ApplyPromocode(string promocode)
    {
        Console.WriteLine($"Promocode '{promocode}' applied to the book.");
    }
}
