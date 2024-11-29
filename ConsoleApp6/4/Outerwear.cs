using System;

public class Outerwear : IPriceable, IDiscountable, IColorable, ISizable
{
    public double Price { get; private set; }
    public byte Color { get; private set; }
    public byte Size { get; private set; }

    public void SetPrice(double price)
    {
        Price = price;
        Console.WriteLine($"Outerwear price set to {price}");
    }

    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Discount '{discount}' applied to the outerwear.");
    }

    public void ApplyPromocode(string promocode)
    {
        Console.WriteLine($"Promocode '{promocode}' applied to the outerwear.");
    }

    public void SetColor(byte color)
    {
        Color = color;
        Console.WriteLine($"Outerwear color set to {color}");
    }

    public void SetSize(byte size)
    {
        Size = size;
        Console.WriteLine($"Outerwear size set to {size}");
    }
}
