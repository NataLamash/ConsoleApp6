using System;

class Program
{
    static void Main(string[] args)
    {
       
        Book book = new Book();
        book.SetPrice(15.99);
        book.ApplyDiscount("10%");
        book.ApplyPromocode("BOOKSALE");

        
        Outerwear jacket = new Outerwear();
        jacket.SetPrice(49.99);
        jacket.ApplyDiscount("20%");
        jacket.ApplyPromocode("JACKETAUTUMN");
        jacket.SetColor(3); 
        jacket.SetSize(42);

        Console.ReadKey();
    }
}
